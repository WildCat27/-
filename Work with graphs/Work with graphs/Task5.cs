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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void open_graph_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл
            graph_textbox.AppendText(filename);
        }

        private void save_graph_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, graph_textbox.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void get_result_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.EnterAdjacencyMatrix(graph_textbox.Text);
            int start = Convert.ToInt32(start_textbox.Text) - 1;
            int finish = Convert.ToInt32(finish_textbox.Text) - 1;
            List<List<Vertex>> ways = graph.ShortestWay(graph.Vertices[start],graph.Vertices[finish]);
            foreach (List<Vertex> way in ways)
            {
                foreach (Vertex vertex in way)
                    coverages_textbox.AppendText(vertex.Name + " ");
                coverages_textbox.AppendText("\n");
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
