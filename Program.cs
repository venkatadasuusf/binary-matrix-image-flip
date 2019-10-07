using System;

namespace binary_matrix_image_flip
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                int[,] matrix = new int[,] { { 1, 1, 0, 0 }, { 1, 0, 0, 1 }, { 0, 1, 1, 1 }, { 1, 0, 1, 0 } };                
                int[,] flipAndInvertedImage = FlipAndInvertImage(matrix);
                Console.WriteLine("The resulting flipped and inverted image is:\n");
                Display2DArray(flipAndInvertedImage);
                Console.Write("\n");

            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");

            }   // End of catch

        }

        /*
            This method prints the values of an 2D integer array. 
        */
        public static void Display2DArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
        // End of Display2DArray

        public static int[,] FlipAndInvertImage(int[,] matrix)
        {
            try
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);
                
                int[,] flipAndInvertedImage = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    columns = matrix.GetLength(1);
                    for (int j = 0; j < columns; j++)
                    {
                        columns--;

                        flipAndInvertedImage[i, j] = 1 - (matrix[i, columns]);

                        flipAndInvertedImage[i, columns] = 1 - (matrix[i, j]);

                    }
                }                         

                return flipAndInvertedImage;
            }

            catch
            {
                Console.WriteLine("Exception occured while computing FlipAndInvertImage()");
            }

            return new int[,] { };
            
        }
    }
}
