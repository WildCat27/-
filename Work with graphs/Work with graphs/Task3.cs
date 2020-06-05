using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyCollections;

namespace Work_with_graphs
{
    public partial class Task3 : Form
    {
        public Task3()
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
            cycles_textbox.Clear();
            try
            {
                Graph graph = new Graph();
                graph.EnterAdjacencyMatrix(graph_textbox.Text);
                List<List<Vertex>> cycles = graph.SimpleCycles();
                if (cycles == null) cycles_textbox.AppendText("не найдено");
                else foreach (List<Vertex> cycle in cycles)
                    {
                        foreach (Vertex vertex in cycle)
                            cycles_textbox.AppendText(vertex.Name + " ");
                        cycles_textbox.AppendText("\n");
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
