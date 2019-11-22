using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelperLibrary
{
    public static class Matrix
    {
        public static int[,] CreateIntMatrix()
        {
            return new int[ReadValues.GetUint("rows= "),ReadValues.GetUint("columns= ")];
        }

        public static int[,] CreateSquareIntMatrix()
        {
            uint size = ReadValues.GetUint("matrix size= ");
            return new int[size, size];
        }

        public static bool IsSquareMatrix(int[,] matrix)
        {
            return matrix.GetLength(0) == matrix.GetLength(1);
        }

        public static void PopulateIntMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ReadValues.GetInt($"matrix[{i}, {j}]= ");
                }
            }
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i,j]}\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
