using System;

public class RubiksCube
{
    CubeFace Top;
    CubeFace Bottom;
    CubeFace Front;
    CubeFace Back;
    CubeFace Left;
    CubeFace Right;

    // Fields, properties, methods and events go here...
    public RubiksCube()
    {
        Top = new CubeFace('w');
        Bottom = new CubeFace('y');
        Front = new CubeFace('b');
        Back = new CubeFace('g');
        Left = new CubeFace('r');
        Right = new CubeFace('o');
    }

    public void print()
    {
        Console.WriteLine("Top:");
        Top.print();
        Console.WriteLine("Bottom:");
        Bottom.print();
        Console.WriteLine("Front:");
        Front.print();
        Console.WriteLine("Back:");
        Back.print();
        Console.WriteLine("Left:");
        Left.print();
        Console.WriteLine("Right:");
        Right.print();
    }

    public void rotate_z(int row)
    {
        char[] temp = Front.getRow(row);
        Front.setRow(row, Right.getRow(row));
        Right.setRow(row, Back.getRow(row));
        Back.setRow(row, Left.getRow(row));
        Left.setRow(row, temp);
    }

    public class CubeFace
    {
        public char[,] face;

        public CubeFace(char c)
        {
            face = new char[3, 3] { { c, c, c }, { c, c, c }, { c, c, c } };
        }

        public char[] getRow(int row)
        {
            char[] ret = new char[3];

            ret[0] = face[row, 0];
            ret[1] = face[row, 1];
            ret[2] = face[row, 2];

            return ret;
        }

        public char[] getCol(int col)
        {
            char[] ret = new char[3];

            ret[0] = face[0, col];
            ret[1] = face[1, col];
            ret[2] = face[2, col];

            return ret;
        }

        public void setRow(int row, char[] values)
        {
            face[row, 0] = values[0];
            face[row, 1] = values[1];
            face[row, 2] = values[2];
        }

        public void setCol(int col, char[] values)
        {
            face[0, col] = values[0];
            face[1, col] = values[1];
            face[2, col] = values[2];
        }

        public void print()
        {
            for (int j = 0; j < face.GetLength(0); j++)
            {
                for (int k = 0; k < face.GetLength(1); k++)
                    Console.Write(string.Format("{0} ", face[j, k]));
                Console.WriteLine();
            }
        }
    }

}
