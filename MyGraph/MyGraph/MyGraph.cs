using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    abstract class Algorithms
    {
        public static void fill<T>(T[] mas, T value)
        {
            for (int i = 0; i < mas.Length; i++)
                mas[i] = value;
        }

        private const int inf = int.MaxValue;

        public void HungarianAlgorithm(DataGridView Matrix, RichTextBox textBox)
        {
            int[] u = new int[Matrix.Rows.Count + 1];
            int[] v = new int[Matrix.ColumnCount + 1];
            int[] p = new int[Matrix.ColumnCount + 1];
            int[] way = new int[Matrix.ColumnCount + 1];
            for (int i = 1; i <= Matrix.Rows.Count; ++i)
            {
                p[0] = i;
                int j0 = 0;
                int[] minv = new int[Matrix.ColumnCount + 1];
                fill(minv, inf);
                bool[] used = new bool[Matrix.ColumnCount + 1];
                fill(used, false);
                do
                {
                    used[j0] = true;
                    int i0 = p[j0], delta = inf, j1 = 0;
                    for (int j = 1; j <= Matrix.ColumnCount; ++j)
                        if (!used[j])
                        {
                            int cur = Convert.ToInt32(Matrix.Rows[i0 - 1].Cells[j - 1].Value) - u[i0] - v[j];
                            if (cur < minv[j])
                            { minv[j] = cur; way[j] = j0; }
                            if (minv[j] < delta)
                            { delta = minv[j]; j1 = j; }
                        }
                    for (int j = 0; j <= Matrix.ColumnCount; ++j)
                        if (used[j])
                        { u[p[j]] += delta; v[j] -= delta; }
                        else
                            minv[j] -= delta;
                    j0 = j1;
                } while (p[j0] != 0);
                do
                {
                    int j1 = way[j0];
                    p[j0] = p[j1];
                    j0 = j1;
                } while (j0 > 0);
            }
            int[] ans = new int[Matrix.Rows.Count + 1];
            for (int j = 1; j <= Matrix.ColumnCount; ++j)
                ans[p[j]] = j;
            for (int j = 1; j <= Matrix.ColumnCount; ++j)
                textBox.AppendText(j.ToString() + " " + ans[j].ToString() + " ");
        }

    }

    public class Vertex
    {
        public string Name;
        public string Mark;
        public List<Vertex> Adjacent = new List<Vertex>();
        public Vertex(string name) => Name = name;
        public Vertex() { }
    }

    public class Edge
    {
        public int Weight;
        public Vertex Begin, End;
        public Edge(Vertex begin, Vertex end)
        {
            Begin = begin;
            End = end;
            begin.Adjacent.Add(end);
        }
    }
    public class Graph
    {
        public List<Vertex> Vertices = new List<Vertex>();
        public List<Edge> Edges = new List<Edge>();
        bool isDirected;

        public Graph() { }

        public bool areConnected(Vertex vertex, Vertex adjacent)
        {
            foreach (Edge edge in Edges)
                if (edge.Begin == vertex && edge.End == adjacent) return true;
            return false;
        }

        public Edge GetEdge(Vertex Begin, Vertex End)
        {
            foreach (Edge edge in Edges)
                if (edge.Begin == Begin && edge.End == End) return edge;
            return null;
        }

        public void EnterAdjacencyMatrix(string str)
        {
            str = str.Replace(" ", ""); // удаление пробелов
            string[] rows = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int name = 0;
            foreach (string row in rows)
                Vertices.Add(new Vertex((++name).ToString()));

            int RowNumber = -1;

            foreach (string row in rows)
            {
                RowNumber++;
                for (int ColumnNumber = 0; ColumnNumber < row.Count(); ColumnNumber++)
                    if (row[ColumnNumber] == '1')
                        Edges.Add(new Edge(Vertices[RowNumber], Vertices[ColumnNumber]));
            }

            foreach (Edge edge in Edges)
                if (GetEdge(edge.End, edge.Begin) == null) isDirected = true;
        }

        public void OutPut(DataGridView Matrix)
        {
            foreach (Vertex adjacent in Vertices)
            {
                Matrix.Columns.Add(Vertices.IndexOf(adjacent).ToString(), Vertices.IndexOf(adjacent).ToString());
                foreach (Vertex vertex in Vertices)
                {
                    Matrix.Rows.Add();
                    if (areConnected(vertex, adjacent))
                        //if (vertex.Adjacent.Contains(adjacent))
                        Matrix.Rows[Vertices.IndexOf(vertex)].Cells[Vertices.IndexOf(adjacent)].Value = 1;
                    else Matrix.Rows[Vertices.IndexOf(vertex)].Cells[Vertices.IndexOf(adjacent)].Value = 0;
                }
            }
        }

        

        public List<Vertex> DFS(int number)
        {
            bool[] Marks = new bool[Vertices.Count];
            List<Vertex> dfs = new List<Vertex>();
            Stack<Vertex> V = new Stack<Vertex>();
            V.Push(Vertices[number - 1]);
            while (V.Any())
            {
                number = Vertices.IndexOf(V.Pop());
                if (!Marks[number])
                {
                    dfs.Add(Vertices[number]);
                    Marks[number] = true;
                    for (int i = Vertices.Count - 1; i >= 0; i--)
                        if (/*Vertices[number].Adjacent.Contains(Vertices[j])*/ areConnected(Vertices[number], Vertices[i]) && !Marks[i])
                            V.Push(Vertices[i]);
                }
            }
            return dfs;
        }


        public List<Vertex> BFS(Vertex vertex)
        {
            bool[] Marks = new bool[Vertices.Count];
            bool[] Inqueue = new bool[Vertices.Count];
            List<Vertex> bfs = new List<Vertex>();
            Queue<Vertex> V = new Queue<Vertex>();
            V.Enqueue(vertex);
            while (V.Any())
            {
                vertex = V.Dequeue();
                bfs.Add(vertex);
                Marks[Vertices.IndexOf(vertex)] = true;
                for (int i = 0; i < Vertices.Count; i++)
                    if (areConnected(vertex, Vertices[i]) && !Marks[i] && !Inqueue[i])
                    {
                        Inqueue[i] = true;
                        V.Enqueue(Vertices[i]);
                    }
            }
            return bfs;
        }

        public List<List<Vertex>> SimpleCycles()
        {
            List<List<Vertex>> CyclesList = new List<List<Vertex>>();
            Graph SpanningTree = new Graph();
            SpanningTree.Vertices = Vertices;
            SpanningTree.Edges = Edges.ToList();
            foreach (Edge edge in Edges)
            {
                if (!isDirected) SpanningTree.Edges.Remove(GetEdge(edge.End, edge.Begin));
                SpanningTree.Edges.Remove(edge);
                List<Vertex> Cycle = new List<Vertex>();
                Cycle.Add(edge.End);
                int Next = 0;
                while (Cycle.Any())
                {
                    int i;
                    for (i = Next; i < Vertices.Count; i++)
                        if (SpanningTree.areConnected(Cycle.Last(), Vertices[i]) && !Cycle.Contains(Vertices[i]))
                        {
                            Cycle.Add(Vertices[i]);
                            Next = 0;
                            break;
                        }
                    if (i == Vertices.Count || Vertices[i] == edge.Begin)
                    {
                        if (i != Vertices.Count) CyclesList.Add(Cycle.ToList());
                        Next = Vertices.IndexOf(Cycle.Last()) + 1;
                        Cycle.Remove(Cycle.Last());
                    }
                }
            }
            return CyclesList;
        }

        public List<List<Vertex>> ShortestWay(Vertex Start, Vertex Finish)
        {
            List<Vertex> bfs = BFS(Start);
            int[] Marks = new int[Vertices.Count];
            Algorithms.fill(Marks, -1);
            Marks[Vertices.IndexOf(Start)] = 0;
            if (bfs.IndexOf(Finish) == -1) return null;
            else
            {
                List<List<Vertex>> Ways = new List<List<Vertex>>();
                List<Vertex> Way = new List<Vertex>();
                foreach (Vertex vertex in bfs)
                {
                    if (vertex == Finish) break;
                    for (int i = 0; i < vertex.Adjacent.Count; i++)
                        if (Marks[Vertices.IndexOf(vertex.Adjacent[i])] == -1)
                            Marks[Vertices.IndexOf(vertex.Adjacent[i])] = Marks[Vertices.IndexOf(vertex)] + 1;
                }
                Way.Add(Finish);
                int Next = 0;
                while (Way.Any())
                {
                    int i;
                    for (i = Next; i < Way.Last().Adjacent.Count; i++)
                        if (Marks[Vertices.IndexOf(Way.Last())] - Marks[Vertices.IndexOf(Way.Last().Adjacent[i])] == 1)
                        {
                            Way.Add(Way.Last().Adjacent[i]);
                            Next = 0;
                            break;
                        }
                    if (i == Way.Last().Adjacent.Count || Way.Last() == Start)
                    {
                        if (i != Way.Last().Adjacent.Count) Ways.Add(Way.ToList());
                        Next = Vertices.IndexOf(Way.Last());
                        Way.Remove(Way.Last());
                        if (Way.Any()) Next = Way.Last().Adjacent.IndexOf(Vertices[Next]) + 1;
                    }
                }
                foreach (List<Vertex> way in Ways) way.Reverse();
                return Ways;
            }
        }

        public List<Vertex> ShortestWayLength(Vertex Start, Vertex Finish)
        {
            int[] weight = new int[Vertices.Count];
            Algorithms.fill(weight, Int32.MaxValue);
            weight[Vertices.IndexOf(Start)] = 0;
            Queue<Vertex> Buff = new Queue<Vertex>();
            Buff.Enqueue(Start);
            while (Buff.Any())
            {
                Vertex vertex = Buff.Dequeue();
                for (int i = 0; i < vertex.Adjacent.Count; i++)
                    if (weight[Vertices.IndexOf(vertex.Adjacent[i])] > weight[Vertices.IndexOf(vertex)] + GetEdge(vertex, vertex.Adjacent[i]).Weight)
                    {
                        weight[Vertices.IndexOf(vertex.Adjacent[i])] = weight[Vertices.IndexOf(vertex)] + GetEdge(vertex, vertex.Adjacent[i]).Weight;
                        Buff.Enqueue(vertex.Adjacent[i]);
                    }

            }
            return null;
        }

        public List<List<Vertex>> SmallestVertexCoverage()
        {
            List<List<Vertex>> SmallestVertexCoverages = new List<List<Vertex>>();
            List<Vertex> Buff = new List<Vertex>();
            foreach (Vertex vertex in Vertices)
                if (vertex.Adjacent.Count > 0) Buff.Add(vertex);
            for (int count = 1; count <= Buff.Count; count++)
            {
                List<Vertex> SmallestVertexCoverage = new List<Vertex>();
                int Last = 0;
                while (Last < Buff.Count)
                {
                    SmallestVertexCoverage.Add(Buff[Last]);
                    if (SmallestVertexCoverage.Count == count)
                    {
                        bool isVertexCoverage = true;
                        foreach (Edge edge in Edges)
                            if (!SmallestVertexCoverage.Contains(edge.Begin) && !SmallestVertexCoverage.Contains(edge.End))
                                isVertexCoverage = false;
                        if (isVertexCoverage) SmallestVertexCoverages.Add(SmallestVertexCoverage.ToList());
                        Last = Buff.IndexOf(SmallestVertexCoverage.Last());
                        SmallestVertexCoverage.Remove(SmallestVertexCoverage.Last());
                    }
                    Last++;
                }
                if (SmallestVertexCoverages.Count > 0) return SmallestVertexCoverages;
            }
            return SmallestVertexCoverages;
        }
    }

    namespace MyGraph
    {
        public class Graph
        {
            private int[,] M; // Матрица смежности
            private int V;
            public Graph() { }

            public void EnterAdjacencyMatrix(string str)
            {
                str = str.Replace(" ", ""); // удаление пробелов
                while (str[str.Length - 1] == '\n')
                    str = str.Remove(str.Length - 1); // удаление конечных "enter"

                int i = 0, j = -1; // i - номер строки матрицы, j - номер столбца
                V = str.IndexOf('\n');
                M = new int[V, V];
                for (int k = 0; k < str.Length; k++)
                {
                    j++;
                    if (str[k] == '1') M[i, j] = 1;//Convert.ToInt32(treeBFS[k]);
                    if (str[k] == '0') M[i, j] = 0;
                    if (str[k] == '\n') { i++; j = -1; } // следующая строка
                }
            }

            public void EnterIncidenceMatrix(string str)
            {
                str = str.Replace(" ", ""); // удаление пробелов
                while (str[str.Length - 1] == '\n')
                    str = str.Remove(str.Length - 1); // удаление конечных "enter"

                str = str.Replace("-1", "m");
                V = 1;
                int E = str.IndexOf('\n'); // E -количество ребер в графе
                for (int k = 0; k < str.Length; k++)
                    if (str[k] == '\n') V++;
                M = new int[V, V];
                int i, j, v, u;
                for (int edge = 0; edge < E; edge++)
                {
                    i = edge;
                    v = 0;
                    while (str[i] == '0') { i += E + 1; v++; } // ищем вершину, инцидентную ребру edge (начало)
                    j = i + E + 1;
                    u = v + 1;
                    while (j < str.Length && str[j] == '0') { j += E + 1; u++; } // ищем вершину, инцидентную ребру edge (конец)
                    if (j >= str.Length) M[v, v] = 1; // если конец ребра не найден, то он совпадает с началом, то есть edge - петля
                    else
                    {
                        if (str[i] == '1') M[v, u] = 1;
                        if (str[j] == '1') M[u, v] = 1;
                    }
                }
            }

            public void EnterAdjacencyList(string str)
            {
                str = str.Replace(" ", ""); // удаление пробелов
                while (str[str.Length - 1] == '\n')
                    str = str.Remove(str.Length - 1); // удаление конечных "enter"

                int i = 0, j; // i - номер строки матрицы, j - номер столбца
                V = 1;
                string vertex_number = "";
                for (int index = 0; index <= str.Length; index++)
                    if (index == str.Length || str[index] == ',' || str[index] == '\n' || str[index] == ':') // ищем максимальный номер вершины, который равен количеству вершин графа
                    {
                        if (Convert.ToInt32(vertex_number) > V) V = Convert.ToInt32(vertex_number);
                        vertex_number = vertex_number.Remove(0);
                    }
                    else vertex_number += str[index];

                M = new int[V, V];
                for (int index = 0; index <= str.Length; index++)
                {
                    if (index < str.Length && str[index] == ':') // считали вершину начало ребра
                    {
                        i = Convert.ToInt32(vertex_number) - 1;
                        vertex_number = vertex_number.Remove(0);
                    }
                    else if (index == str.Length || str[index] == ',' || str[index] == '\n') // считали вершину конец ребра
                    {
                        j = Convert.ToInt32(vertex_number) - 1;
                        M[i, j] = 1;
                        vertex_number = vertex_number.Remove(0);
                    }
                    else vertex_number += str[index];
                }
            }

            public void EnterEdgeList(string str)
            {
                str = str.Replace(" ", ""); // удаление пробелов
                while (str[str.Length - 1] == '\n')
                    str = str.Remove(str.Length - 1); // удаление конечных "enter"

                V = 1;
                string vertex_number = "";
                for (int index = 0; index <= str.Length; index++)
                    if (index == str.Length || str[index] == ',' || str[index] == '\n') // ищем максимальный номер вершины, который равен количеству вершин графа
                    {
                        if (Convert.ToInt32(vertex_number) > V) V = Convert.ToInt32(vertex_number);
                        vertex_number = vertex_number.Remove(0);
                    }
                    else vertex_number += str[index];

                M = new int[V, V];
                int v = 1, u;
                for (int index = 0; index <= str.Length; index++)
                    if (index < str.Length && str[index] != ',' && str[index] != '\n') vertex_number += str[index];
                    else
                    {
                        if (index == str.Length || str[index] == '\n') // нашли конец ребра
                        {
                            u = Convert.ToInt32(vertex_number) - 1;
                            M[v, u] = 1;
                        }
                        else if (str[index] == ',') v = Convert.ToInt32(vertex_number) - 1; // нашли начало ребра
                        vertex_number = vertex_number.Remove(0);
                    }
            }

            public string IncidenceMatrix()
            {
                string output = "";
                for (int vertex = 0; vertex < V; vertex++)
                {
                    output += (vertex + 1).ToString() + ":";
                    for (int i = 0; i < V; i++)
                        for (int j = 0; j < V; j++)
                            if (M[i, j] == 1)
                                if (vertex == i && vertex == j) output += "  2";
                                else
                                    if (vertex == i) output += "  1";
                                else if (vertex == j) output += " -1";
                                else output += "  0";
                    output += "\n";
                }
                return output;
            }

            public string AdjacencyList()
            {
                string output = "";
                for (int i = 0; i < V; i++)
                {
                    output += (i + 1).ToString() + ": ";
                    for (int j = 0; j < V; j++)
                        if (M[i, j] == 1)
                        {
                            if (output.Last() != ' ') output += ", ";
                            output += (j + 1).ToString();
                        }
                    output += "\n";
                }
                return output;
            }

            public string EdgeList()
            {
                string output = "";
                for (int i = 0; i < V; i++)
                    for (int j = 0; j < V; j++)
                        if (M[i, j] == 1) output += (i + 1).ToString() + ", " + (j + 1).ToString() + "\n";
                output += "\n";
                return output;
            }

            public string AdjacencyMatrix()
            {
                string output = "";
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                        if (M[i, j] == 1) output += "1 ";
                        else output += "0 ";
                    output += "\n";
                }
                return output;
            }

            public int[] DFS(int number)
            {
                bool[] Marks = new bool[V];
                int[] dfs = new int[V];
                int index = -1;
                Stack<int> Vertexes = new Stack<int>();
                Vertexes.Push(number);
                while (Vertexes.Any())
                {
                    number = Vertexes.Pop();
                    if (!Marks[number - 1])
                    {
                        dfs[++index] = number;
                        Marks[number - 1] = true;
                        for (int i = V - 1; i >= 0; i--)
                            if (M[number - 1, i] == 1 && !Marks[i])
                                Vertexes.Push(i + 1);
                    }
                }
                return dfs;
            }

            public int[] BFS(int number)
            {
                bool[] Marks = new bool[V];
                bool[] Inqueue = new bool[V];
                int[] bfs = new int[V];
                int index = -1;
                Queue<int> Vertexes = new Queue<int>();
                Vertexes.Enqueue(number);
                while (Vertexes.Any())
                {
                    number = Vertexes.Dequeue();
                    bfs[++index] = number;
                    Marks[number - 1] = true;
                    for (int i = 0; i < V; i++)
                        if (M[number - 1, i] == 1 && !Marks[i] && !Inqueue[i])
                        {
                            Inqueue[i] = true;
                            Vertexes.Enqueue(i + 1);
                        }
                }
                return bfs;
            }

            public TreeNode treeDFS(int number)
            {
                int[] vertexes = DFS(number);
                TreeNode[] nodes = new TreeNode[V];
                nodes[0] = new TreeNode();
                nodes[0].Text = number.ToString();
                TreeNode tree = nodes[0];
                int parent;
                for (int i = 1; i < V; i++)
                {
                    nodes[i] = new TreeNode();
                    nodes[i].Text = vertexes[i].ToString();
                    parent = i - 1;
                    while (M[vertexes[parent] - 1, vertexes[i] - 1] == 0)
                        parent--;
                    nodes[parent].Nodes.Add(nodes[i]);
                }
                return tree;
            }

            public TreeNode treeBFS(int number)
            {
                int[] vertexes = BFS(number);
                TreeNode[] nodes = new TreeNode[V];
                nodes[0] = new TreeNode();
                nodes[0].Text = number.ToString();
                TreeNode tree = nodes[0];
                int parent = 0;
                for (int i = 1; i < V; i++)
                {
                    nodes[i] = new TreeNode();
                    nodes[i].Text = vertexes[i].ToString();
                    while (M[vertexes[parent] - 1, vertexes[i] - 1] == 0)
                        parent++;
                    nodes[parent].Nodes.Add(nodes[i]);
                }
                return tree;
            }
        }
    }
}
