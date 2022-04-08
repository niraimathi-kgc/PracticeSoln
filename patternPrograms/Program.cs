using System;

namespace patternPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            halfPyramid hp1 = new halfPyramid();
            invertedHPyramid ihp1 = new invertedHPyramid();
            DiagonalPyramid dp1 = new DiagonalPyramid();
            InvertedDiagonal id1 = new InvertedDiagonal();
            Pyramid py = new Pyramid();
            InvertedPyramid ipy = new InvertedPyramid();
            hp1.halfPyramid1();

            Console.WriteLine();

            ihp1.invertedHalfPyramid();

            Console.WriteLine();

            dp1.diagonalPyramid1();

            Console.WriteLine();

            id1.invertedDiagonalPyramid();

            Console.WriteLine();

            py.Pyramid1();

            Console.WriteLine();

            ipy.invertedPy1();
        }
    }
}
