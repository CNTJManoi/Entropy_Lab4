namespace entropy_lab4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ClearButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PowerBox = new System.Windows.Forms.TextBox();
            this.EnsembleData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.EntropyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxEntropyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EnoughBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.digramsData = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.H1Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EnsembleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digramsData)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(434, 109);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(6);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(146, 33);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(400, 61);
            this.InputBox.Margin = new System.Windows.Forms.Padding(6);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(180, 39);
            this.InputBox.TabIndex = 1;
            this.InputBox.Text = "подлинник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сообщение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Определение безусловной энтропии";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(267, 109);
            this.RunButton.Margin = new System.Windows.Forms.Padding(6);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(146, 33);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Выполнить";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Мощность алфавита:";
            // 
            // PowerBox
            // 
            this.PowerBox.Location = new System.Drawing.Point(235, 210);
            this.PowerBox.Margin = new System.Windows.Forms.Padding(6);
            this.PowerBox.Name = "PowerBox";
            this.PowerBox.ReadOnly = true;
            this.PowerBox.Size = new System.Drawing.Size(109, 39);
            this.PowerBox.TabIndex = 6;
            // 
            // EnsembleData
            // 
            this.EnsembleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnsembleData.Location = new System.Drawing.Point(17, 277);
            this.EnsembleData.Name = "EnsembleData";
            this.EnsembleData.RowHeadersWidth = 51;
            this.EnsembleData.Size = new System.Drawing.Size(327, 290);
            this.EnsembleData.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ансамбль источника сообщения";
            // 
            // EntropyBox
            // 
            this.EntropyBox.Location = new System.Drawing.Point(694, 169);
            this.EntropyBox.Margin = new System.Windows.Forms.Padding(6);
            this.EntropyBox.Name = "EntropyBox";
            this.EntropyBox.ReadOnly = true;
            this.EntropyBox.Size = new System.Drawing.Size(139, 39);
            this.EntropyBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Безусловная энтропия:";
            // 
            // MaxEntropyBox
            // 
            this.MaxEntropyBox.Location = new System.Drawing.Point(694, 208);
            this.MaxEntropyBox.Margin = new System.Windows.Forms.Padding(6);
            this.MaxEntropyBox.Name = "MaxEntropyBox";
            this.MaxEntropyBox.ReadOnly = true;
            this.MaxEntropyBox.Size = new System.Drawing.Size(139, 39);
            this.MaxEntropyBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Максимальная энтропия:";
            // 
            // EnoughBox
            // 
            this.EnoughBox.Location = new System.Drawing.Point(694, 246);
            this.EnoughBox.Margin = new System.Windows.Forms.Padding(6);
            this.EnoughBox.Name = "EnoughBox";
            this.EnoughBox.ReadOnly = true;
            this.EnoughBox.Size = new System.Drawing.Size(139, 39);
            this.EnoughBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Недогруженность алфавита:";
            // 
            // digramsData
            // 
            this.digramsData.AllowUserToAddRows = false;
            this.digramsData.AllowUserToDeleteRows = false;
            this.digramsData.AllowUserToResizeColumns = false;
            this.digramsData.AllowUserToResizeRows = false;
            this.digramsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.digramsData.Location = new System.Drawing.Point(635, 316);
            this.digramsData.Name = "digramsData";
            this.digramsData.RowHeadersVisible = false;
            this.digramsData.RowHeadersWidth = 51;
            this.digramsData.Size = new System.Drawing.Size(234, 250);
            this.digramsData.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Список биграмм";
            // 
            // H1Box
            // 
            this.H1Box.Location = new System.Drawing.Point(434, 369);
            this.H1Box.Margin = new System.Windows.Forms.Padding(6);
            this.H1Box.Name = "H1Box";
            this.H1Box.ReadOnly = true;
            this.H1Box.Size = new System.Drawing.Size(139, 39);
            this.H1Box.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Энтропия первого порядка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 579);
            this.Controls.Add(this.H1Box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.digramsData);
            this.Controls.Add(this.EnoughBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxEntropyBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EntropyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnsembleData);
            this.Controls.Add(this.PowerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ClearButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Безусловная энтропия";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnsembleData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digramsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PowerBox;
        private System.Windows.Forms.DataGridView EnsembleData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EntropyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaxEntropyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EnoughBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView digramsData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox H1Box;
        private System.Windows.Forms.Label label9;
    }
}

