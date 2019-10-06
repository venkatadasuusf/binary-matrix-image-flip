using System;

namespace binary_matrix_image_flip
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[,] A = new int[,] { { 1, 1, 0, 0 }, { 1, 0, 0, 1 }, { 0, 1, 1, 1 }, { 1, 0, 1, 0 } };
                Console.WriteLine("Length: " + A.Length);
                Console.WriteLine("Rank: " + A.Rank);


                int rows = A.GetLength(0);
                int columns = A.GetLength(1);
                Console.WriteLine("Rows: " + rows);
                Console.WriteLine("Columns: " + columns);

                int[,] B = new int[rows, columns];


                for (int i = 0; i < rows; i++)
                {
                    columns = A.GetLength(1);
                    for (int j = 0; j < columns; j++)
                    {
                        columns--;

                        B[i, j] = 1 - (A[i, columns]);


                        B[i, columns] = 1 - (A[i, j]);


                    }
                }

                foreach (int item in B)
                {
                    Console.WriteLine(item + " ");
                }


            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");

            }   // End of catch

        }
    }
}
