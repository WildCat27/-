using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using MaterialSkin.Animations;
using MaterialSkin;

namespace Work_with_graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
             0111100
             1011001
             1101100
             1110010
             1010000
             0001001
             0100010
             */
            /*
             011100
             100110
             100100
             111001
             010000
             000100
             */
            /*
             01110
             10101
             11001
             10001
             01110
   */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form task1 = new Task1();
            task1.Location = this.Location;
            task1.Show();
            task1.FormClosed += (object s, FormClosedEventArgs ev) => { this.Location = task1.Location;  this.Show(); };
            this.Hide();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        /*
void matrix_naznach()
{
dataGridView1.Columns.Add("1", "1");
dataGridView1.Columns.Add("2", "2");
dataGridView1.Columns.Add("3", "3");
dataGridView1.Rows.Add();
dataGridView1.Rows.Add();
dataGridView1.Rows[0].Cells[0].Value = 5;
dataGridView1.Rows[0].Cells[1].Value = 9;
dataGridView1.Rows[0].Cells[2].Value = 2;
dataGridView1.Rows[1].Cells[0].Value = 10;
dataGridView1.Rows[1].Cells[1].Value = 3;
dataGridView1.Rows[1].Cells[2].Value = 2;
dataGridView1.Rows[2].Cells[0].Value = 8;
dataGridView1.Rows[2].Cells[1].Value = 7;
dataGridView1.Rows[2].Cells[2].Value = 4;
}*/

    }
}
