namespace Work_with_graphs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hungarian_algorithm = new System.Windows.Forms.Button();
            this.algebraic_addition = new System.Windows.Forms.Button();
            this.simple_cycles = new System.Windows.Forms.Button();
            this.vertex_coverage = new System.Windows.Forms.Button();
            this.shortest_way = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hungarian_algorithm
            // 
            this.hungarian_algorithm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hungarian_algorithm.BackColor = System.Drawing.Color.White;
            this.hungarian_algorithm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hungarian_algorithm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.hungarian_algorithm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.hungarian_algorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hungarian_algorithm.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hungarian_algorithm.ForeColor = System.Drawing.Color.Black;
            this.hungarian_algorithm.Location = new System.Drawing.Point(60, 140);
            this.hungarian_algorithm.Margin = new System.Windows.Forms.Padding(7);
            this.hungarian_algorithm.Name = "hungarian_algorithm";
            this.hungarian_algorithm.Size = new System.Drawing.Size(530, 60);
            this.hungarian_algorithm.TabIndex = 0;
            this.hungarian_algorithm.Text = "Задача о назначениях венгерским алгоритмом";
            this.hungarian_algorithm.UseVisualStyleBackColor = false;
            this.hungarian_algorithm.Click += new System.EventHandler(this.hungarian_algorithm_Click);
            // 
            // algebraic_addition
            // 
            this.algebraic_addition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.algebraic_addition.BackColor = System.Drawing.Color.White;
            this.algebraic_addition.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.algebraic_addition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.algebraic_addition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.algebraic_addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algebraic_addition.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.algebraic_addition.ForeColor = System.Drawing.Color.Black;
            this.algebraic_addition.Location = new System.Drawing.Point(60, 60);
            this.algebraic_addition.Margin = new System.Windows.Forms.Padding(7);
            this.algebraic_addition.Name = "algebraic_addition";
            this.algebraic_addition.Size = new System.Drawing.Size(530, 60);
            this.algebraic_addition.TabIndex = 1;
            this.algebraic_addition.Text = "Наименьшее покрытие алгебраического дополнения";
            this.algebraic_addition.UseVisualStyleBackColor = false;
            this.algebraic_addition.Click += new System.EventHandler(this.algebraic_addition_Click);
            // 
            // simple_cycles
            // 
            this.simple_cycles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simple_cycles.BackColor = System.Drawing.Color.White;
            this.simple_cycles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.simple_cycles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.simple_cycles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.simple_cycles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simple_cycles.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simple_cycles.ForeColor = System.Drawing.Color.Black;
            this.simple_cycles.Location = new System.Drawing.Point(57, 220);
            this.simple_cycles.Margin = new System.Windows.Forms.Padding(7);
            this.simple_cycles.Name = "simple_cycles";
            this.simple_cycles.Size = new System.Drawing.Size(530, 60);
            this.simple_cycles.TabIndex = 3;
            this.simple_cycles.Text = "Вывести все простые циклы";
            this.simple_cycles.UseVisualStyleBackColor = false;
            this.simple_cycles.Click += new System.EventHandler(this.simple_cycles_Click);
            // 
            // vertex_coverage
            // 
            this.vertex_coverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vertex_coverage.BackColor = System.Drawing.Color.Transparent;
            this.vertex_coverage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.vertex_coverage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.vertex_coverage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.vertex_coverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vertex_coverage.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vertex_coverage.ForeColor = System.Drawing.Color.Black;
            this.vertex_coverage.Location = new System.Drawing.Point(60, 300);
            this.vertex_coverage.Margin = new System.Windows.Forms.Padding(7);
            this.vertex_coverage.Name = "vertex_coverage";
            this.vertex_coverage.Size = new System.Drawing.Size(530, 60);
            this.vertex_coverage.TabIndex = 4;
            this.vertex_coverage.Text = "Построить наименьшее покрытие";
            this.vertex_coverage.UseVisualStyleBackColor = false;
            this.vertex_coverage.Click += new System.EventHandler(this.vertex_coverage_Click);
            // 
            // shortest_way
            // 
            this.shortest_way.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shortest_way.BackColor = System.Drawing.Color.Transparent;
            this.shortest_way.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.shortest_way.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.shortest_way.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.shortest_way.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortest_way.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shortest_way.ForeColor = System.Drawing.Color.Black;
            this.shortest_way.Location = new System.Drawing.Point(60, 380);
            this.shortest_way.Margin = new System.Windows.Forms.Padding(7);
            this.shortest_way.Name = "shortest_way";
            this.shortest_way.Size = new System.Drawing.Size(530, 60);
            this.shortest_way.TabIndex = 5;
            this.shortest_way.Text = "Алгоритм Ли нахождения кратчайшего пути";
            this.shortest_way.UseVisualStyleBackColor = false;
            this.shortest_way.Click += new System.EventHandler(this.shortest_way_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 320);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(642, 653);
            this.Controls.Add(this.shortest_way);
            this.Controls.Add(this.vertex_coverage);
            this.Controls.Add(this.simple_cycles);
            this.Controls.Add(this.algebraic_addition);
            this.Controls.Add(this.hungarian_algorithm);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hungarian_algorithm;
        private System.Windows.Forms.Button algebraic_addition;
        private System.Windows.Forms.Button simple_cycles;
        private System.Windows.Forms.Button vertex_coverage;
        private System.Windows.Forms.Button shortest_way;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

