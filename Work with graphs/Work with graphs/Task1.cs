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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void open_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // читаем файл
            graph_textbox.AppendText(System.IO.File.ReadAllText(filename));
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Graph graph = new Graph();
            graph.EnterAdjacencyMatrix(graph_textbox.Text);
            string[] vertexArray = clique_textbox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Vertex> Clique = new List<Vertex>();
            foreach (string vertex_number in vertexArray)
                Clique.Add(graph.Vertices[Convert.ToInt32(vertex_number) - 1]);
            List<Vertex> Addition = graph.VertexAddition(Clique);
            foreach (Vertex vertex in Addition)
                addition_textbox.AppendText(vertex.Name + " ");
        }
    }
}
