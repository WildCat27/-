namespace Work_with_graphs
{
    partial class Task3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task3));
            this.graph_textbox = new System.Windows.Forms.RichTextBox();
            this.cycles_textbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.get_result = new System.Windows.Forms.Button();
            this.open_graph = new System.Windows.Forms.Button();
            this.save_graph = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            // cycles_textbox
            // 
            this.cycles_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cycles_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cycles_textbox.ForeColor = System.Drawing.Color.Black;
            this.cycles_textbox.Location = new System.Drawing.Point(360, 70);
            this.cycles_textbox.Name = "cycles_textbox";
            this.cycles_textbox.Size = new System.Drawing.Size(260, 350);
            this.cycles_textbox.TabIndex = 1;
            this.cycles_textbox.Text = "";
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
            this.label2.Location = new System.Drawing.Point(360, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Простые циклы";
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
            this.get_result.Location = new System.Drawing.Point(470, 450);
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
            this.open_graph.Location = new System.Drawing.Point(30, 500);
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
            this.save_graph.Location = new System.Drawing.Point(30, 450);
            this.save_graph.Margin = new System.Windows.Forms.Padding(5);
            this.save_graph.Name = "save_graph";
            this.save_graph.Size = new System.Drawing.Size(180, 40);
            this.save_graph.TabIndex = 12;
            this.save_graph.Text = "Сохранить граф";
            this.save_graph.UseVisualStyleBackColor = false;
            this.save_graph.Click += new System.EventHandler(this.save_graph_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 653);
            this.Controls.Add(this.save_graph);
            this.Controls.Add(this.open_graph);
            this.Controls.Add(this.get_result);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cycles_textbox);
            this.Controls.Add(this.graph_textbox);
            this.Name = "Task3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox graph_textbox;
        private System.Windows.Forms.RichTextBox cycles_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button get_result;
        private System.Windows.Forms.Button open_graph;
        private System.Windows.Forms.Button save_graph;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}