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
        }

        private void click(object sender, EventArgs e)
        {
            Form task = null;
            if (Convert.ToInt32(((Control)sender).Tag) == 1) task = new Task1();
            if (Convert.ToInt32(((Control)sender).Tag) == 2) task = new Task2();
            if (Convert.ToInt32(((Control)sender).Tag) == 3) task = new Task3();
            if (Convert.ToInt32(((Control)sender).Tag) == 4) task = new Task4();
            if (Convert.ToInt32(((Control)sender).Tag) == 5) task = new Task5();
            task.Location = this.Location;
            task.Show();
            task.FormClosed += (object s, FormClosedEventArgs ev) => { this.Location = task.Location; this.Show(); };
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
