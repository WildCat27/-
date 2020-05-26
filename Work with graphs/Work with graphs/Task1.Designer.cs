namespace Work_with_graphs
{
    partial class Task1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task1));
            this.graph_textbox = new System.Windows.Forms.RichTextBox();
            this.addition_textbox = new System.Windows.Forms.RichTextBox();
            this.clique_textbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.open_graph = new System.Windows.Forms.Button();
            this.get_result = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.save_graph = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // graph_textbox
            // 
            this.graph_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.graph_textbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graph_textbox.Location = new System.Drawing.Point(250, 40);
            this.graph_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.graph_textbox.Name = "graph_textbox";
            this.graph_textbox.Size = new System.Drawing.Size(350, 300);
            this.graph_textbox.TabIndex = 0;
            this.graph_textbox.Text = "";
            // 
            // addition_textbox
            // 
            this.addition_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addition_textbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition_textbox.Location = new System.Drawing.Point(250, 500);
            this.addition_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.addition_textbox.Name = "addition_textbox";
            this.addition_textbox.Size = new System.Drawing.Size(350, 50);
            this.addition_textbox.TabIndex = 1;
            this.addition_textbox.Text = "";
            // 
            // clique_textbox
            // 
            this.clique_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clique_textbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clique_textbox.Location = new System.Drawing.Point(250, 420);
            this.clique_textbox.Margin = new System.Windows.Forms.Padding(5);
            this.clique_textbox.Name = "clique_textbox";
            this.clique_textbox.Size = new System.Drawing.Size(350, 50);
            this.clique_textbox.TabIndex = 2;
            this.clique_textbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите граф";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "или загрузите";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "из файла";
            // 
            // open_graph
            // 
            this.open_graph.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.open_graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_graph.Location = new System.Drawing.Point(30, 250);
            this.open_graph.Margin = new System.Windows.Forms.Padding(5);
            this.open_graph.Name = "open_graph";
            this.open_graph.Size = new System.Drawing.Size(180, 40);
            this.open_graph.TabIndex = 6;
            this.open_graph.Text = "Загрузить граф";
            this.open_graph.UseVisualStyleBackColor = false;
            this.open_graph.Click += new System.EventHandler(this.open_file_Click);
            // 
            // get_result
            // 
            this.get_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.get_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_result.Location = new System.Drawing.Point(30, 590);
            this.get_result.Margin = new System.Windows.Forms.Padding(5);
            this.get_result.Name = "get_result";
            this.get_result.Size = new System.Drawing.Size(150, 40);
            this.get_result.TabIndex = 7;
            this.get_result.Text = "Получить";
            this.get_result.UseVisualStyleBackColor = false;
            this.get_result.Click += new System.EventHandler(this.get_result_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.Location = new System.Drawing.Point(470, 590);
            this.menu.Margin = new System.Windows.Forms.Padding(5);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(150, 40);
            this.menu.TabIndex = 8;
            this.menu.Text = "Главное меню";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 430);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите клику";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 510);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "graph";
            // 
            // save_graph
            // 
            this.save_graph.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_graph.Location = new System.Drawing.Point(30, 300);
            this.save_graph.Margin = new System.Windows.Forms.Padding(5);
            this.save_graph.Name = "save_graph";
            this.save_graph.Size = new System.Drawing.Size(180, 40);
            this.save_graph.TabIndex = 11;
            this.save_graph.Text = "Сохранить граф";
            this.save_graph.UseVisualStyleBackColor = false;
            this.save_graph.Click += new System.EventHandler(this.save_graph_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 653);
            this.Controls.Add(this.save_graph);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.get_result);
            this.Controls.Add(this.open_graph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clique_textbox);
            this.Controls.Add(this.addition_textbox);
            this.Controls.Add(this.graph_textbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Task1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox graph_textbox;
        private System.Windows.Forms.RichTextBox addition_textbox;
        private System.Windows.Forms.RichTextBox clique_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button open_graph;
        private System.Windows.Forms.Button get_result;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button save_graph;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}