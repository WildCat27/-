namespace Work_with_graphs
{
    partial class Task2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task2));
            this.matrix = new System.Windows.Forms.DataGridView();
            this.row_add = new System.Windows.Forms.Button();
            this.row_delete = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.column_add = new System.Windows.Forms.Button();
            this.column_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.get_result = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.AllowUserToResizeColumns = false;
            this.matrix.AllowUserToResizeRows = false;
            this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrix.BackgroundColor = System.Drawing.Color.White;
            this.matrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Location = new System.Drawing.Point(30, 60);
            this.matrix.Margin = new System.Windows.Forms.Padding(4);
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersWidth = 50;
            this.matrix.RowTemplate.Height = 24;
            this.matrix.Size = new System.Drawing.Size(580, 350);
            this.matrix.TabIndex = 0;
            // 
            // row_add
            // 
            this.row_add.BackColor = System.Drawing.Color.LightGreen;
            this.row_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.row_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.row_add.Location = new System.Drawing.Point(30, 420);
            this.row_add.Margin = new System.Windows.Forms.Padding(4);
            this.row_add.Name = "row_add";
            this.row_add.Size = new System.Drawing.Size(120, 50);
            this.row_add.TabIndex = 1;
            this.row_add.Text = "Добавить строку";
            this.row_add.UseCompatibleTextRendering = true;
            this.row_add.UseVisualStyleBackColor = false;
            this.row_add.Click += new System.EventHandler(this.row_add_Click);
            // 
            // row_delete
            // 
            this.row_delete.BackColor = System.Drawing.Color.LightCoral;
            this.row_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.row_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.row_delete.Location = new System.Drawing.Point(160, 420);
            this.row_delete.Margin = new System.Windows.Forms.Padding(4);
            this.row_delete.Name = "row_delete";
            this.row_delete.Size = new System.Drawing.Size(120, 50);
            this.row_delete.TabIndex = 2;
            this.row_delete.Text = "Удалить строку";
            this.row_delete.UseCompatibleTextRendering = true;
            this.row_delete.UseVisualStyleBackColor = false;
            this.row_delete.Click += new System.EventHandler(this.row_delete_Click);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(30, 550);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(420, 90);
            this.result.TabIndex = 3;
            this.result.Text = "";
            // 
            // column_add
            // 
            this.column_add.BackColor = System.Drawing.Color.LightGreen;
            this.column_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.column_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.column_add.Location = new System.Drawing.Point(360, 420);
            this.column_add.Margin = new System.Windows.Forms.Padding(4);
            this.column_add.Name = "column_add";
            this.column_add.Size = new System.Drawing.Size(120, 50);
            this.column_add.TabIndex = 4;
            this.column_add.Text = "Добавить столбец";
            this.column_add.UseCompatibleTextRendering = true;
            this.column_add.UseVisualStyleBackColor = false;
            this.column_add.Click += new System.EventHandler(this.column_add_Click);
            // 
            // column_delete
            // 
            this.column_delete.BackColor = System.Drawing.Color.LightCoral;
            this.column_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.column_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.column_delete.Location = new System.Drawing.Point(490, 420);
            this.column_delete.Margin = new System.Windows.Forms.Padding(4);
            this.column_delete.Name = "column_delete";
            this.column_delete.Size = new System.Drawing.Size(120, 50);
            this.column_delete.TabIndex = 5;
            this.column_delete.Text = "Удалить столбец";
            this.column_delete.UseCompatibleTextRendering = true;
            this.column_delete.UseVisualStyleBackColor = false;
            this.column_delete.Click += new System.EventHandler(this.column_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите значения в матрицу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 520);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Результат";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.Location = new System.Drawing.Point(470, 600);
            this.menu.Margin = new System.Windows.Forms.Padding(5);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(150, 40);
            this.menu.TabIndex = 9;
            this.menu.Text = "Главное меню";
            this.menu.UseCompatibleTextRendering = true;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // get_result
            // 
            this.get_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.get_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_result.Location = new System.Drawing.Point(470, 550);
            this.get_result.Margin = new System.Windows.Forms.Padding(5);
            this.get_result.Name = "get_result";
            this.get_result.Size = new System.Drawing.Size(150, 40);
            this.get_result.TabIndex = 10;
            this.get_result.Text = "Получить";
            this.get_result.UseCompatibleTextRendering = true;
            this.get_result.UseVisualStyleBackColor = false;
            this.get_result.Click += new System.EventHandler(this.get_result_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 653);
            this.Controls.Add(this.get_result);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.column_delete);
            this.Controls.Add(this.column_add);
            this.Controls.Add(this.result);
            this.Controls.Add(this.row_delete);
            this.Controls.Add(this.row_add);
            this.Controls.Add(this.matrix);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Task2";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button row_add;
        private System.Windows.Forms.Button row_delete;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button column_add;
        private System.Windows.Forms.Button column_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button get_result;
    }
}