

namespace rubiksCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RubiksCube cube = new RubiksCube();
            cube.print();
            cube.rotate_z(0);
            cube.print();
        }
    }
}

