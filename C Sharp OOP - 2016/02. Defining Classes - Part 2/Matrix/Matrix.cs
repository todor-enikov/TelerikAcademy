using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T> //task8
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col] //task9
        {
            get
            {
                OutOfRange(row, col);
                return matrix[row, col];
            }
            set
            {
                OutOfRange(row, col);
                matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public static Matrix<T> operator +(Matrix<T> furst, Matrix<T> second) //task10
        {
            furst.CheckMatrix();
            second.CheckMatrix();

            if (furst.Rows != second.Rows || furst.Cols != second.Cols)
            {
                throw new ArgumentException("Cannot addition matrices with diferent sizes!");
            }

            var result = new Matrix<T>(furst.Rows, furst.Cols);
            for (int i = 0; i < furst.Rows; i++)
            {
                for (int j = 0; j < furst.Cols; j++)
                {
                    result[i, j] = (dynamic)furst[i, j] + second[i, j];
                }
            }
            return result;

        }

        public static Matrix<T> operator -(Matrix<T> furst, Matrix<T> second) //task10
        {

            furst.CheckMatrix();
            second.CheckMatrix();

            if (furst.Rows != second.Rows || furst.Cols != second.Cols)
            {
                throw new ArgumentException("Cannot substract matrices with diferent sizes!");
            }

            var result = new Matrix<T>(furst.Rows, furst.Cols);
            for (int i = 0; i < furst.Rows; i++)
            {
                for (int j = 0; j < furst.Cols; j++)
                {
                    result[i, j] = (dynamic)furst[i, j] - second[i, j];
                }
            }
            return result;

        }

        public static Matrix<T> operator *(Matrix<T> furst, Matrix<T> second) //task10
        {
            furst.CheckMatrix();
            second.CheckMatrix();

            if (furst.Cols != second.Rows)
            {
                throw new ArgumentException("Invalid matrices size! The matrices cannot be multiplied!");
            }

            var result = new Matrix<T>(furst.Rows, second.Cols);
            T sum;

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    sum = (dynamic)0;
                    for (int k = 0; k < furst.Cols; k++)
                    {
                        sum += (dynamic)furst[i, k] * second[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix) //task10
        {
            var output = true;

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    dynamic value = matrix[row, col];

                    if (value == 0)
                    {
                        output = false;
                    }
                }
            }

            return output;
        }
        public static bool operator false(Matrix<T> matrix) //task10
        {
            var output = false;

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    dynamic value = matrix[row, col];

                    if (value == 0)
                    {
                        output = true;
                    }
                }
            }

            return output;
        }
        public void CheckMatrix()
        {
            if (typeof(T) != typeof(int) && typeof(T) != typeof(long) && typeof(T) != typeof(short) && typeof(T) != typeof(float) &&
                typeof(T) != typeof(double) && typeof(T) != typeof(decimal))
            {
                throw new ArgumentException("Cannot apply this operator on this type of matrix!");
            }
        }

        public void OutOfRange(int row, int col)
        {
            if (row < 0 || col < 0 || row > this.matrix.GetLength(0) - 1 || col > this.matrix.GetLength(1) - 1)
            {
                throw new IndexOutOfRangeException("Index Out Of Range!");
            }
        }
    }
}