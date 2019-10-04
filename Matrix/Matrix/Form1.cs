using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            no.Visible = false;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = true;
            int k;
            if (razmM.Text == "" || Convert.ToInt32(razmM.Text) <= 0)
            {
                no.Visible = true;
                flag = false;
            }

            if (flag)
            {
                k = Convert.ToInt32(razmM.Text);
                no.Visible = false;
                Matrix kM = new Matrix(k, k);
                //kM.Matrix(k,k);                
                label5.Text = kM.cols.ToString();

                matr1.ColumnCount = kM.cols;
                matr1.RowCount = kM.rows;

                matr2.ColumnCount = kM.cols;
                matr2.RowCount = kM.rows;

                matrResult.ColumnCount = kM.cols;
                matrResult.RowCount = kM.rows;

                matr1.AutoResizeColumns();
                matr1.RowHeadersVisible = false;
                matr1.ColumnHeadersVisible = false;
                matr1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                matr1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                matr1.ClearSelection();

                matr2.AutoResizeColumns();
                matr2.RowHeadersVisible = false;
                matr2.ColumnHeadersVisible = false;
                matr2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                matr2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                matr2.ClearSelection();

                matrResult.AutoResizeColumns();
                matrResult.RowHeadersVisible = false;
                matrResult.ColumnHeadersVisible = false;
                matrResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                matrResult.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                matrResult.ClearSelection();
            }
            else no.Visible = true;
        }

        private void sluch1_Click(object sender, EventArgs e)
        {
            Matrix dat1 = new Matrix(matr1.RowCount, matr1.ColumnCount);
            dat1 = dat1.Write_in(dat1);

            for (int i = 0; i < matr1.RowCount; i++)
            {
                for (int j = 0; j < matr1.ColumnCount; j++)
                {
                    matr1[i, j].Value = dat1[i, j];
                }
            }
        }

        private void sluch2_Click(object sender, EventArgs e)
        {
            Matrix dat2 = new Matrix(matr2.RowCount, matr2.ColumnCount);
            dat2 = dat2.Write_in(dat2);

            for (int i = 0; i < matr1.RowCount; i++)
            {
                for (int j = 0; j < matr1.ColumnCount; j++)
                {
                    matr2[i, j].Value = dat2[j, i];
                }
            }
        }

        private void butTran1_Click(object sender, EventArgs e)
        {
            Matrix dat1 = new Matrix(matr1.RowCount, matr1.ColumnCount);

            for (int i = 0; i < matr1.RowCount; i++)
            {
                for (int j = 0; j < matr1.ColumnCount; j++)
                {
                    dat1[i, j] = Convert.ToDouble(matr1[i, j].Value);
                }
            }

            dat1 = !dat1;

            for (int i = 0; i < matr1.RowCount; i++)
            {
                for (int j = 0; j < matr1.ColumnCount; j++)
                {
                    matr1[i, j].Value = dat1[i, j];
                }
            }

        }

        private void butTran2_Click(object sender, EventArgs e)
        {
            Matrix dat2 = new Matrix(matr2.RowCount, matr2.ColumnCount);

            for (int i = 0; i < matr2.RowCount; i++)
            {
                for (int j = 0; j < matr2.ColumnCount; j++)
                {
                    dat2[i, j] = Convert.ToDouble(matr2[i, j].Value);
                }
            }

            dat2 = !dat2;

            for (int i = 0; i < matr2.RowCount; i++)
            {
                for (int j = 0; j < matr2.ColumnCount; j++)
                {
                    matr2[i, j].Value = dat2[i, j];
                }
            }

        }

        private void butTran3_Click(object sender, EventArgs e)
        {
            Matrix dat3 = new Matrix(matrResult.RowCount, matrResult.ColumnCount);

            for (int i = 0; i < matrResult.RowCount; i++)
            {
                for (int j = 0; j < matrResult.ColumnCount; j++)
                {
                    dat3[i, j] = Convert.ToDouble(matrResult[i, j].Value);
                }
            }

            dat3 = !dat3;

            for (int i = 0; i < matrResult.RowCount; i++)
            {
                for (int j = 0; j < matrResult.ColumnCount; j++)
                {
                    matrResult[i, j].Value = dat3[i, j];
                }
            }

        }

        private void butSum_Click(object sender, EventArgs e)
        {
            Matrix dat1 = new Matrix(matr1.RowCount, matr1.ColumnCount);
            Matrix dat2 = new Matrix(matr2.RowCount, matr2.ColumnCount);
            Matrix res = new Matrix(matr1.RowCount, matr2.ColumnCount);

            for (int i = 0; i < matr1.RowCount; i++)
            {
                for (int j = 0; j < matr1.ColumnCount; j++)
                {
                    dat1[i, j] = Convert.ToDouble(matr1[i, j].Value);
                    dat2[i, j] = Convert.ToDouble(matr2[i, j].Value);
                }
            }
            res = dat1 + dat2;

            for (int i = 0; i < matrResult.RowCount; i++)
            {
                for (int j = 0; j < matrResult.ColumnCount; j++)
                {
                    matrResult[i, j].Value = res[i, j];
                }
            }

        }

        private void butUmnog_Click(object sender, EventArgs e)
        {
            Matrix dat1 = new Matrix(matr1.RowCount, matr1.ColumnCount);
            Matrix dat2 = new Matrix(matr2.RowCount, matr2.ColumnCount);
            Matrix res = new Matrix(matr1.RowCount, matr2.ColumnCount);

            for (int i = 0; i < matr1.RowCount; i++)
            {
                for (int j = 0; j < matr1.ColumnCount; j++)
                {
                    dat1[i, j] = Convert.ToDouble(matr1[i, j].Value);
                    dat2[i, j] = Convert.ToDouble(matr2[i, j].Value);
                }
            }
            res = dat1 * dat2;

            for (int i = 0; i < matrResult.RowCount; i++)
            {
                for (int j = 0; j < matrResult.ColumnCount; j++)
                {
                    matrResult[i, j].Value = res[i, j];
                }
            }
        }
    }
          
}
