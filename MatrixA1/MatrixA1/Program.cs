using System;

namespace MatrixA1
{
    class Program
    {

        public static int[,] ReadMatrix(string label)
        {
            label = label ?? "matrix";

            int rowsCount = ConsoleHelper.ReadNumber($"{label} no of rows", 3, 3);
            int colsCount = ConsoleHelper.ReadNumber($"{label} no of cols", 3, 3);

            int[,] matrix = new int[rowsCount, colsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    int element = ConsoleHelper.ReadNumber($"element[{row}, {col}]", 3, 0);
                    matrix[row, col] = element;
                }
            }

            return matrix;
        }

        /// <summary>
        /// Prints a matrix to the console.
        /// </summary>
        /// <param name="label">The matrix label.</param>
        /// <param name="matrix">The matrix.</param>
        public static void PrintMatrix(string label, int[,] matrix)
        {
            Console.WriteLine(label ?? "Matrix");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col],6}");
                }

                Console.WriteLine();
            }
        }
    }
}
