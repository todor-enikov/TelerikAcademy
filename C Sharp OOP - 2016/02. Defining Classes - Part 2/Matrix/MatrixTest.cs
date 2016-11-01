using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    [Version(1, 12)] //task11
    class MatrixTest
    {
        static void Main()
        {
            var type = typeof(MatrixTest);  //task11
            var attributes = type.GetCustomAttributes(false); //task11
            foreach (Version atr in attributes) //task11
            {
                Console.WriteLine("Version {0}", atr.VersionAttribute);
            }

            Console.WriteLine("\nMatrix");


            var matrix1 = new Matrix<int>(3, 2);
            var matrix2 = new Matrix<int>(2, 2);

            matrix1[0, 0] = 4;
            matrix1[0, 1] = 8;
            matrix1[1, 0] = 0;
            matrix1[1, 1] = 2;
            matrix1[2, 0] = 1;
            matrix1[2, 1] = 6;

            matrix2[0, 0] = 5;
            matrix2[0, 1] = 2;
            matrix2[1, 0] = 9;
            matrix2[1, 1] = 4;


            //var resultMatrixOfSum = matrix1 + matrix2;

            //for (int i = 0; i < resultMatrixOfSum.Rows; i++)
            //{
            //    for (int j = 0; j < resultMatrixOfSum.Cols; j++)
            //    {
            //        Console.Write(resultMatrixOfSum[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}


            //var resultMatrixOfSub = matrix1 - matrix2;

            //for (int i = 0; i < resultMatrixOfSub.Rows; i++)
            //{
            //    for (int j = 0; j < resultMatrixOfSub.Cols; j++)
            //    {
            //        Console.Write(resultMatrixOfSub[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}

            var resultMatrix = matrix1 * matrix2;

            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Cols; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nCheck matrix");

            if (matrix2)
            {
                Console.WriteLine("No zeroes");
            }
            else
            {
                Console.WriteLine("Yes zeroes");
            }
        }
    }
}
