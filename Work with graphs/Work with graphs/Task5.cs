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
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void open_graph_Click(object sender, EventArgs e)
        {
            graph_textbox.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // читаем файл
            graph_textbox.AppendText(System.IO.File.ReadAllText(filename));
        }

        private void save_graph_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, graph_textbox.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void get_result_Click(object sender, EventArgs e)
        {
            ways_textbox.Clear();
            try
            {
                Graph graph = new Graph();
                graph.EnterAdjacencyMatrix(graph_textbox.Text);
                int start = Convert.ToInt32(start_textbox.Text) - 1;
                int finish = Convert.ToInt32(finish_textbox.Text) - 1;
                List<Vertex> bfs = graph.BFS(graph.Vertices[start]);
                List<List<Vertex>> ways = graph.ShortestWay(graph.Vertices[start], graph.Vertices[finish]);
                if (ways == null) ways_textbox.AppendText("не найдено");
                else foreach (List<Vertex> way in ways)
                    {
                        foreach (Vertex vertex in way)
                            ways_textbox.AppendText(vertex.Name + " ");
                        ways_textbox.AppendText("\n");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
