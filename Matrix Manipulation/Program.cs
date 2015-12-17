using System;
using System.Collections.Generic;

namespace Matrix_Manipulation
{
    class Program
    {
        struct Coordinates
        {
            public int column;
            public int row;
        }

        static int[,] Matrix_Zerofy(int[,] matrix)
        {
            List<Coordinates> zeroCoordinates = new List<Coordinates>();
            int amountOfRows = matrix.GetLength(0);
            int amountOfColumns = matrix.GetLength(1);


            for (int row = 0; row < amountOfRows; row++)
            {
                for (int column = 0; column < amountOfColumns; column++)
                {
                    if (matrix[row, column] == 0)
                    {
                        Coordinates coordinates = new Coordinates();
                        coordinates.row = row;
                        coordinates.column = column;
                        zeroCoordinates.Add(coordinates);
                    }
                }
            }

            foreach (Coordinates item in zeroCoordinates)
            {
                for (int row = 0; row < amountOfRows; row++)
                {
                    matrix[row, item.column] = 0;
                }
                for (int column = 0; column < amountOfColumns; column++)
                {
                    matrix[item.row, column] = 0;
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 9]
            {
                { 2, 1, 2, 5 , 6, 7, 8, 1, 1 },
                { 5, -8, 6, 5, -8, 6, 5, -8, 6 },
                { 4, 3, 6, 4, 3, 6, 4, 3, 0 },
                { 1, 9, 6, 1, 0, 6, 1, 9, 6 },
                { 0, -5, 6, 0, -5, 6, 0, -5, 6 },
                { 2, 7, 6, 2, 7, 6, 2, 7, 6 },
                { 0, 1, 6, 0, 1, 6, 0, 1, 6 },
                { 1, 4, 9, 1, 4, 9, 1, 4, 9 }
            };

            int[,] changedMatrix = Matrix_Zerofy(matrix);

            for (int i = 0; i < changedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < changedMatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", changedMatrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
