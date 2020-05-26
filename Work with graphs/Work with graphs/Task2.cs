using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCollections;

namespace Work_with_graphs
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            matrix.Columns.Add((matrix.Columns.Count + 1).ToString(), (matrix.Columns.Count + 1).ToString());
            matrix.Columns.Add((matrix.Columns.Count + 1).ToString(), (matrix.Columns.Count + 1).ToString());
            matrix.Columns.Add((matrix.Columns.Count + 1).ToString(), (matrix.Columns.Count + 1).ToString());
            matrix.Rows.Add();
            matrix.Rows.Add();
        }

        private void row_add_Click(object sender, EventArgs e)
        {
            if (matrix.Rows.Count < 10) matrix.Rows.Add();
        }

        private void row_delete_Click(object sender, EventArgs e)
        {
            int i = matrix.Rows.Count - 1;
            if (matrix.Rows.Count > 2) matrix.Rows.RemoveAt(i);
        }

        private void column_add_Click(object sender, EventArgs e)
        {
            if(matrix.Rows.Count < 10) matrix.Columns.Add((matrix.Columns.Count + 1).ToString(), (matrix.Columns.Count + 1).ToString());
        }

        private void column_delete_Click(object sender, EventArgs e)
        {
            if (matrix.Columns.Count > 2) matrix.Columns.Remove(matrix.Columns[matrix.Columns.Count - 1]);
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void get_result_Click(object sender, EventArgs e)
        {
            int[,] Matrix = new int[matrix.RowCount, matrix.ColumnCount];
            for (int row = 0; row < matrix.RowCount; row++)
                for (int column = 0; column < matrix.ColumnCount; column++)
                    Matrix[row, column] = Convert.ToInt32(matrix.Rows[row].Cells[column].Value);
            int[] Result = Matrix.HungarianAlgorithm();
            for (int i = 1; i < Result.Count(); i++)
                result.AppendText($"[{i}; {Result[i]}] ");
        }

    }
}
