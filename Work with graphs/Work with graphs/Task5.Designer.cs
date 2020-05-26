namespace Work_with_graphs
{
    partial class Task5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task5));
            this.graph_textbox = new System.Windows.Forms.RichTextBox();
            this.coverages_textbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.get_result = new System.Windows.Forms.Button();
            this.open_graph = new System.Windows.Forms.Button();
            this.save_graph = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.start_textbox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finish_textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // graph_textbox
            // 
            this.graph_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graph_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graph_textbox.Location = new System.Drawing.Point(30, 70);
            this.graph_textbox.Name = "graph_textbox";
            this.graph_textbox.Size = new System.Drawing.Size(300, 350);
            this.graph_textbox.TabIndex = 0;
            this.graph_textbox.Text = "";
            // 
            // coverages_textbox
            // 
            this.coverages_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coverages_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coverages_textbox.ForeColor = System.Drawing.Color.Black;
            this.coverages_textbox.Location = new System.Drawing.Point(30, 530);
            this.coverages_textbox.Name = "coverages_textbox";
            this.coverages_textbox.Size = new System.Drawing.Size(400, 100);
            this.coverages_textbox.TabIndex = 1;
            this.coverages_textbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите граф";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(370, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введить начальную и";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.Location = new System.Drawing.Point(470, 590);
            this.menu.Margin = new System.Windows.Forms.Padding(5);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(150, 40);
            this.menu.TabIndex = 9;
            this.menu.Text = "Главное меню";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // get_result
            // 
            this.get_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.get_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_result.Location = new System.Drawing.Point(470, 530);
            this.get_result.Margin = new System.Windows.Forms.Padding(5);
            this.get_result.Name = "get_result";
            this.get_result.Size = new System.Drawing.Size(150, 40);
            this.get_result.TabIndex = 10;
            this.get_result.Text = "Получить";
            this.get_result.UseVisualStyleBackColor = false;
            this.get_result.Click += new System.EventHandler(this.get_result_Click);
            // 
            // open_graph
            // 
            this.open_graph.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.open_graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_graph.Location = new System.Drawing.Point(370, 130);
            this.open_graph.Margin = new System.Windows.Forms.Padding(5);
            this.open_graph.Name = "open_graph";
            this.open_graph.Size = new System.Drawing.Size(180, 40);
            this.open_graph.TabIndex = 11;
            this.open_graph.Text = "Загрузить граф";
            this.open_graph.UseVisualStyleBackColor = false;
            this.open_graph.Click += new System.EventHandler(this.open_graph_Click);
            // 
            // save_graph
            // 
            this.save_graph.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.save_graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_graph.Location = new System.Drawing.Point(370, 70);
            this.save_graph.Margin = new System.Windows.Forms.Padding(5);
            this.save_graph.Name = "save_graph";
            this.save_graph.Size = new System.Drawing.Size(180, 40);
            this.save_graph.TabIndex = 12;
            this.save_graph.Text = "Сохранить граф";
            this.save_graph.UseVisualStyleBackColor = false;
            this.save_graph.Click += new System.EventHandler(this.save_graph_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(370, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "конечную вершины пути";
            // 
            // start_textbox
            // 
            this.start_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.start_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_textbox.Location = new System.Drawing.Point(470, 300);
            this.start_textbox.Name = "start_textbox";
            this.start_textbox.Size = new System.Drawing.Size(120, 40);
            this.start_textbox.TabIndex = 14;
            this.start_textbox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(370, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Начало";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(374, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Конец";
            // 
            // finish_textbox
            // 
            this.finish_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finish_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finish_textbox.Location = new System.Drawing.Point(470, 380);
            this.finish_textbox.Name = "finish_textbox";
            this.finish_textbox.Size = new System.Drawing.Size(120, 40);
            this.finish_textbox.TabIndex = 17;
            this.finish_textbox.Text = "";
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 653);
            this.Controls.Add(this.finish_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save_graph);
            this.Controls.Add(this.open_graph);
            this.Controls.Add(this.get_result);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coverages_textbox);
            this.Controls.Add(this.graph_textbox);
            this.Name = "Task5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox graph_textbox;
        private System.Windows.Forms.RichTextBox coverages_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button get_result;
        private System.Windows.Forms.Button open_graph;
        private System.Windows.Forms.Button save_graph;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox start_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox finish_textbox;
    }
}