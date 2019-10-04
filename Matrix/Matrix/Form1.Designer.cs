namespace Matrix
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matr1 = new System.Windows.Forms.DataGridView();
            this.matr2 = new System.Windows.Forms.DataGridView();
            this.matrResult = new System.Windows.Forms.DataGridView();
            this.butExit = new System.Windows.Forms.Button();
            this.butSum = new System.Windows.Forms.Button();
            this.butUmnog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butTran1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.razmM = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butTran2 = new System.Windows.Forms.Button();
            this.butTran3 = new System.Windows.Forms.Button();
            this.sluch1 = new System.Windows.Forms.Button();
            this.sluch2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrResult)).BeginInit();
            this.SuspendLayout();
            // 
            // matr1
            // 
            this.matr1.AllowDrop = true;
            this.matr1.AllowUserToAddRows = false;
            this.matr1.AllowUserToOrderColumns = true;
            this.matr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.matr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matr1.DefaultCellStyle = dataGridViewCellStyle13;
            this.matr1.Location = new System.Drawing.Point(29, 139);
            this.matr1.MultiSelect = false;
            this.matr1.Name = "matr1";
            this.matr1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.matr1.RowTemplate.Height = 24;
            this.matr1.Size = new System.Drawing.Size(345, 345);
            this.matr1.TabIndex = 0;
            // 
            // matr2
            // 
            this.matr2.AllowUserToAddRows = false;
            this.matr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matr2.DefaultCellStyle = dataGridViewCellStyle14;
            this.matr2.Location = new System.Drawing.Point(441, 139);
            this.matr2.Name = "matr2";
            this.matr2.RowTemplate.Height = 24;
            this.matr2.Size = new System.Drawing.Size(345, 345);
            this.matr2.TabIndex = 1;
            // 
            // matrResult
            // 
            this.matrResult.AllowUserToAddRows = false;
            this.matrResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrResult.DefaultCellStyle = dataGridViewCellStyle15;
            this.matrResult.Enabled = false;
            this.matrResult.Location = new System.Drawing.Point(855, 139);
            this.matrResult.Name = "matrResult";
            this.matrResult.RowTemplate.Height = 24;
            this.matrResult.Size = new System.Drawing.Size(345, 345);
            this.matrResult.TabIndex = 2;
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.Location = new System.Drawing.Point(1124, 504);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(100, 46);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "EXIT";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butSum
            // 
            this.butSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSum.Location = new System.Drawing.Point(379, 218);
            this.butSum.Name = "butSum";
            this.butSum.Size = new System.Drawing.Size(57, 94);
            this.butSum.TabIndex = 4;
            this.butSum.Text = "+";
            this.butSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSum.UseVisualStyleBackColor = true;
            this.butSum.Click += new System.EventHandler(this.butSum_Click);
            // 
            // butUmnog
            // 
            this.butUmnog.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butUmnog.Location = new System.Drawing.Point(378, 318);
            this.butUmnog.Name = "butUmnog";
            this.butUmnog.Size = new System.Drawing.Size(59, 98);
            this.butUmnog.TabIndex = 6;
            this.butUmnog.Text = "*";
            this.butUmnog.UseVisualStyleBackColor = true;
            this.butUmnog.Click += new System.EventHandler(this.butUmnog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Первая матрица";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вторая матрица";
            // 
            // butTran1
            // 
            this.butTran1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTran1.Location = new System.Drawing.Point(378, 139);
            this.butTran1.Name = "butTran1";
            this.butTran1.Size = new System.Drawing.Size(32, 38);
            this.butTran1.TabIndex = 10;
            this.butTran1.Text = "!";
            this.butTran1.UseVisualStyleBackColor = true;
            this.butTran1.Click += new System.EventHandler(this.butTran1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(345, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите размерность матриц:";
            // 
            // razmM
            // 
            this.razmM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razmM.Location = new System.Drawing.Point(670, 42);
            this.razmM.Name = "razmM";
            this.razmM.Size = new System.Drawing.Size(100, 30);
            this.razmM.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(784, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(652, 79);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(172, 17);
            this.no.TabIndex = 17;
            this.no.Text = "Введите число больше 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // butTran2
            // 
            this.butTran2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTran2.Location = new System.Drawing.Point(790, 139);
            this.butTran2.Name = "butTran2";
            this.butTran2.Size = new System.Drawing.Size(32, 38);
            this.butTran2.TabIndex = 19;
            this.butTran2.Text = "!";
            this.butTran2.UseVisualStyleBackColor = true;
            this.butTran2.Click += new System.EventHandler(this.butTran2_Click);
            // 
            // butTran3
            // 
            this.butTran3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTran3.Location = new System.Drawing.Point(1202, 139);
            this.butTran3.Name = "butTran3";
            this.butTran3.Size = new System.Drawing.Size(32, 38);
            this.butTran3.TabIndex = 20;
            this.butTran3.Text = "!";
            this.butTran3.UseVisualStyleBackColor = true;
            this.butTran3.Click += new System.EventHandler(this.butTran3_Click);
            // 
            // sluch1
            // 
            this.sluch1.Location = new System.Drawing.Point(29, 490);
            this.sluch1.Name = "sluch1";
            this.sluch1.Size = new System.Drawing.Size(345, 31);
            this.sluch1.TabIndex = 21;
            this.sluch1.Text = "заполнить случайными числами";
            this.sluch1.UseVisualStyleBackColor = true;
            this.sluch1.Click += new System.EventHandler(this.sluch1_Click);
            // 
            // sluch2
            // 
            this.sluch2.Location = new System.Drawing.Point(441, 490);
            this.sluch2.Name = "sluch2";
            this.sluch2.Size = new System.Drawing.Size(345, 31);
            this.sluch2.TabIndex = 23;
            this.sluch2.Text = "заполнить случайными числами";
            this.sluch2.UseVisualStyleBackColor = true;
            this.sluch2.Click += new System.EventHandler(this.sluch2_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(792, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 304);
            this.label6.TabIndex = 24;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sluch2);
            this.Controls.Add(this.sluch1);
            this.Controls.Add(this.butTran3);
            this.Controls.Add(this.butTran2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.no);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.razmM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butTran1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butUmnog);
            this.Controls.Add(this.butSum);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.matrResult);
            this.Controls.Add(this.matr2);
            this.Controls.Add(this.matr1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.matr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matr1;
        private System.Windows.Forms.DataGridView matr2;
        private System.Windows.Forms.DataGridView matrResult;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butSum;
        private System.Windows.Forms.Button butUmnog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butTran1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox razmM;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butTran2;
        private System.Windows.Forms.Button butTran3;
        private System.Windows.Forms.Button sluch1;
        private System.Windows.Forms.Button sluch2;
        private System.Windows.Forms.Label label6;
    }
}

