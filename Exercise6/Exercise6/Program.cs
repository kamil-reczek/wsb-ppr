using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace Exercise6
{
    class Program
    {
        private static int[,] GenerateIntMatrix(uint rows, uint cols)
        {
            if (rows == 0 || cols == 0) throw new ArgumentOutOfRangeException("Cols and rows need to be > 0");
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rand.Next(25);
            return matrix;
        }

        // Task 3 - Transpose 
        private static int[,] Transpose(int[,] m)
        {
            int[,] t = new int[m.GetLength(1), m.GetLength(0)];

            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    t[j, i] = m[i, j];
            return t;
        }

        // Task 4 - Add two matrices
        private static int[,] Add(int[,] a, int[,] b)
        {
            // check if addition is possible
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                throw new ArgumentException("Matrices a and b need to have the same dimensions");
            
            int[,] result = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = a[i, j] + b[i, j];
            return result;
        }

        // Task 5 - Subtract two matrices
        private static int[,] Subtract(int[,] a, int[,] b)
        {
            // check if subtraction is possible
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                throw new ArgumentException("Matrices a and b need to have the same dimensions");

            int[,] result = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = a[i, j] - b[i, j];
            return result;
        }

        // Task 6 - Multiply two matrices
        private static int[,] Multiply(int[,] a, int[,] b)
        {
            // check if multiplication is possible
            if (a.GetLength(1) != b.GetLength(0))
                throw new ArgumentException("Matrices need to have proper dimensions for multiplication");

            int[,] r = new int[a.GetLength(0), b.GetLength(1)];

            int i = 0, j = 0, s = 0;
            while(i < r.GetLength(0))
            {
                while(j < r.GetLength(1))
                {
                    for(int k = 0; k < a.GetLength(1); k++)
                    {
                        s += a[i,k] * b[k,j]; 
                    }
                    r[i, j] = s;
                    s = 0;
                    j++;
                }
                i++;
                j = 0;
            }
            return r;
        }

        // Task 7
        private static bool IsSquareMatrix(int[,] m)
        {
            return m.GetLength(0) == m.GetLength(1);
        }

        // Task 8
        private static int MatrixTrace(int[,] m)
        {
            if (!IsSquareMatrix(m))
                throw new ArgumentException("m is not a square matrix");

            int r = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                r += m[i, i];

            return r;
        }

        // Task 9
        private static int[,] GenerateIdentityMatrix(uint n)
        {
            int[,] r = new int[n, n];
            for(int i = 0; i < n; i++)
                for(int j = 0; j < n; j++)
                {
                    if (i == j) r[i, j] = 1;
                    else r[i, j] = 0;
                }
            return r;
        }

        // Task 10
        private static void GetUpperTrilangularMatrix(int[,] m)
        {
            if (!IsSquareMatrix(m))
                throw new ArgumentException("m is not square matrix");
            for(int i = 0; i < m.GetLength(0); i++)
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if (j < i) m[i, j] = 0;
                }
        }

        // Task 11
        private static int CheckUpperLowerSum(int[,] m)
        {
            if (!IsSquareMatrix(m)) throw new ArgumentException("m is not square matrix");
            int upperSum = 0, lowerSum = 0;
            for(int i = 0; i < m.GetLength(0); i++)
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if (i < j) upperSum = m[i, j];
                    else if (j < i) lowerSum = m[i, j];
                }
            return Math.Sign(upperSum - lowerSum);
        }

        static void Main(string[] args)
        {
            int[,] m = GenerateIntMatrix(4, 6);
            // Test task 3 - Transpose
            Matrix.DisplayMatrix(m);
            m = Transpose(m);
            Matrix.DisplayMatrix(m);

            // Test task 4 and 5
            m = Transpose(m);
            Console.Clear();
            int[,] n = GenerateIntMatrix(4, 6);
            Console.WriteLine("m= ");
            Matrix.DisplayMatrix(m);
            Console.WriteLine("n= ");
            Matrix.DisplayMatrix(n);
            Console.WriteLine("m+n= ");
            Matrix.DisplayMatrix(Add(m,n));
            Console.WriteLine("m-n= ");
            Matrix.DisplayMatrix(Subtract(m, n));

            // Test task 6
            Console.Clear();
            m = GenerateIntMatrix(2, 3);
            n = GenerateIntMatrix(3, 2);
            Console.WriteLine("m= ");
            Matrix.DisplayMatrix(m);
            Console.WriteLine("n= ");
            Matrix.DisplayMatrix(n);
            Console.WriteLine("m*n= ");
            Matrix.DisplayMatrix(Multiply(m, n));

            // Test task 7
            Console.Clear();
            m = GenerateIntMatrix(3, 2);
            Console.WriteLine("m is sqaure matrix= " + IsSquareMatrix(m));
            n = GenerateIntMatrix(3, 3);
            Console.WriteLine("n is square matrix= " + IsSquareMatrix(m));

            // Test task 8
            Console.Clear();
            m = GenerateIntMatrix(4, 4);
            Console.WriteLine("m= ");
            Matrix.DisplayMatrix(m);
            Console.WriteLine("trace= " + MatrixTrace(m));

            // Test task 9
            Console.Clear();
            Console.WriteLine("I(10)= ");
            Matrix.DisplayMatrix(GenerateIdentityMatrix(10));

            // Test task 10
            Console.Clear();
            m = GenerateIntMatrix(4, 4);
            Console.WriteLine("m= ");
            Matrix.DisplayMatrix(m);
            Console.WriteLine("Getting upper triangular matrix");
            GetUpperTrilangularMatrix(m);
            Matrix.DisplayMatrix(m);

            // Test task 11
            Console.Clear();
            m = GenerateIntMatrix(4, 4);
            Console.WriteLine("m= ");
            Matrix.DisplayMatrix(m);
            Console.WriteLine("upper - lower= " + CheckUpperLowerSum(m));
        }
    }
}
