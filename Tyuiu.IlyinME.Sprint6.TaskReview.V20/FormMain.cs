using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IlyinME.Sprint6.TaskReview.V20.Lib;

namespace Tyuiu.IlyinME.Sprint6.TaskReview.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_IME_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxn_IME.Text);
                int m = Convert.ToInt32(textBoxm_IME.Text);
                int n1 = Convert.ToInt32(textBoxn1_IME.Text);
                int n2 = Convert.ToInt32(textBoxn2_IME.Text);
                int K = Convert.ToInt32(textBoxK_IME.Text);
                int L = Convert.ToInt32(textBoxL_IME.Text);
                int R = Convert.ToInt32(textBoxR_IME.Text);

                int[,] array = ds.GetMatrix(n, m, n1, n2, L, R, K);

                int rows = array.GetLength(0);
                int columns = array.GetLength(1);

                dataGridViewIn_IME.ColumnCount = columns;
                dataGridViewIn_IME.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn_IME.Columns[i].Width = 40;

                }

                for (int i = 0; i < rows; i++)
                {
                    dataGridViewIn_IME.Rows[i].Height = 40;

                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewIn_IME.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRes_IME_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(textBoxn1_IME.Text);
                int n2 = Convert.ToInt32(textBoxn2_IME.Text);
                int n = Convert.ToInt32(textBoxn_IME.Text);
                int m = Convert.ToInt32(textBoxm_IME.Text);
                int K = Convert.ToInt32(textBoxK_IME.Text);
                int L = Convert.ToInt32(textBoxL_IME.Text);
                int R = Convert.ToInt32(textBoxR_IME.Text);
                int[,] array = ds.GetMatrix(n, m, n1, n2, L, R, K);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = Convert.ToInt32(dataGridViewIn_IME.Rows[i].Cells[j].Value);
                    }
                }
                int res = ds.ResultGetMatrix(array, K, L, R);

                textBoxResult_IME.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
