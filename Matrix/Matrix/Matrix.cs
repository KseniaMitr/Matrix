using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    class Matrix
    {
        double [,] data;
        public int rows;
        public int cols;       

        public Matrix(int row, int col)
        {                       
            rows = row;
            cols = col;
            this.data = new double[rows, cols];
        }

        public double this[int i, int j]
        {
            get
            {
                return this.data[i, j];
            }
            set
            {
                this.data[i, j] = value;
            }
        }

        public Matrix Write_in(Matrix dat)
        {
            Matrix data = new Matrix (dat.rows, dat.cols);
            Random rnd = new Random();
            int[,] mass = new int[dat.rows, dat.cols];
             
            for (int i = 0; i < data.rows; i++)
            {
                for (int j = 0; j < data.cols; j++)
                {
                    mass[i, j] = rnd.Next(0, 100);
                    data[i, j] = mass[i, j];
                }
            }            
            return data;
        }
        
        public static Matrix transp(Matrix matr)
        {
            Matrix dat = new Matrix(matr.rows, matr.cols);
            Matrix datT = new Matrix(matr.cols, matr.rows);

            for (int i = 0; i < matr.rows; i++)
            {
                for (int j = 0; j < matr.cols; j++)
                {
                    dat[i, j] = matr[i, j];
                }
            }

            for (int i = 0; i < matr.rows; i++)
            {
                for (int j = 0; j < matr.cols; j++)
                {
                    datT[i, j] = dat[j, i];
                }
            }
            return datT;
        }
        public static Matrix operator!(Matrix m1)
        {
            return transp(m1);
        }
            
        public static Matrix Sum (Matrix m1, Matrix m2)
        {
            Matrix res = new Matrix(m1.rows, m2.cols);
            for (int i = 0; i < res.rows; i++)
            {
                for (int j = 0; j < res.cols; j++)
                {
                    res[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return res;
        }
        public static Matrix operator+ (Matrix m1, Matrix m2)
        {
            return Sum(m1, m2);
        }

        public static Matrix Umnog (Matrix m1, Matrix m2)
        {
            Matrix res = new Matrix(m1.rows, m2.cols);
            for (int i = 0; i < res.rows; i++)
            {
                for (int j = 0; j < res.cols; j++)
                {
                    for (int k = 0; k < res.rows; k++)
                    {
                        res[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return res;
        }
        public static Matrix operator*(Matrix m1, Matrix m2)
        {
            return Umnog(m1, m2);
        }


    }
}
