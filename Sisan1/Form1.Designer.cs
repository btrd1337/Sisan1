namespace Sisan1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Problem = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ExpertNameFirstLabMethodComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewLab1 = new System.Windows.Forms.DataGridView();
            this.FirstLabExpertsPassedCountLabel = new System.Windows.Forms.Label();
            this.SecondLabExpertsPassedCountLabel = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alternative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(112, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список альтернатив";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(11, 64);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(254, 300);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonExit
            // 
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(11, 11);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExit.Size = new System.Drawing.Size(26, 26);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Problem
            // 
            this.Problem.AutoSize = true;
            this.Problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Problem.Location = new System.Drawing.Point(42, 11);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(223, 26);
            this.Problem.TabIndex = 18;
            this.Problem.Text = "Название проблемы";
            this.Problem.Click += new System.EventHandler(this.Problem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Очистить результаты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExpertNameFirstLabMethodComboBox
            // 
            this.ExpertNameFirstLabMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpertNameFirstLabMethodComboBox.FormattingEnabled = true;
            this.ExpertNameFirstLabMethodComboBox.Location = new System.Drawing.Point(279, 44);
            this.ExpertNameFirstLabMethodComboBox.Name = "ExpertNameFirstLabMethodComboBox";
            this.ExpertNameFirstLabMethodComboBox.Size = new System.Drawing.Size(242, 21);
            this.ExpertNameFirstLabMethodComboBox.TabIndex = 19;
            this.ExpertNameFirstLabMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.ExpertNameFirstLabMethodComboBox_SelectedIndexChanged);
            this.ExpertNameFirstLabMethodComboBox.Click += new System.EventHandler(this.ExpertNameFirstLabMethodComboBox_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.AlternativeName,
            this.ResultScore});
            this.dataGridView3.Location = new System.Drawing.Point(541, 63);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 50;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(242, 300);
            this.dataGridView3.TabIndex = 20;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridViewLab1
            // 
            this.dataGridViewLab1.AllowUserToAddRows = false;
            this.dataGridViewLab1.AllowUserToDeleteRows = false;
            this.dataGridViewLab1.AllowUserToResizeRows = false;
            this.dataGridViewLab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLab1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Alternative,
            this.Weight});
            this.dataGridViewLab1.Location = new System.Drawing.Point(279, 64);
            this.dataGridViewLab1.Name = "dataGridViewLab1";
            this.dataGridViewLab1.ReadOnly = true;
            this.dataGridViewLab1.RowHeadersVisible = false;
            this.dataGridViewLab1.Size = new System.Drawing.Size(242, 300);
            this.dataGridViewLab1.TabIndex = 21;
            // 
            // FirstLabExpertsPassedCountLabel
            // 
            this.FirstLabExpertsPassedCountLabel.AutoSize = true;
            this.FirstLabExpertsPassedCountLabel.Location = new System.Drawing.Point(276, 367);
            this.FirstLabExpertsPassedCountLabel.Name = "FirstLabExpertsPassedCountLabel";
            this.FirstLabExpertsPassedCountLabel.Size = new System.Drawing.Size(154, 13);
            this.FirstLabExpertsPassedCountLabel.TabIndex = 22;
            this.FirstLabExpertsPassedCountLabel.Text = "Пройдено 0 из 0 экспертами";
            // 
            // SecondLabExpertsPassedCountLabel
            // 
            this.SecondLabExpertsPassedCountLabel.AutoSize = true;
            this.SecondLabExpertsPassedCountLabel.Location = new System.Drawing.Point(541, 366);
            this.SecondLabExpertsPassedCountLabel.Name = "SecondLabExpertsPassedCountLabel";
            this.SecondLabExpertsPassedCountLabel.Size = new System.Drawing.Size(154, 13);
            this.SecondLabExpertsPassedCountLabel.TabIndex = 23;
            this.SecondLabExpertsPassedCountLabel.Text = "Пройдено 0 из 0 экспертами";
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.Width = 25;
            // 
            // Alternative
            // 
            this.Alternative.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alternative.HeaderText = "Альтеранитива";
            this.Alternative.Name = "Alternative";
            this.Alternative.ReadOnly = true;
            this.Alternative.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Weight
            // 
            this.Weight.FillWeight = 50F;
            this.Weight.HeaderText = "Вес";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Weight.Width = 50;
            // 
            // RowNumber
            // 
            this.RowNumber.HeaderText = "№";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RowNumber.Width = 25;
            // 
            // AlternativeName
            // 
            this.AlternativeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlternativeName.HeaderText = "Альтернатива";
            this.AlternativeName.Name = "AlternativeName";
            this.AlternativeName.ReadOnly = true;
            this.AlternativeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ResultScore
            // 
            this.ResultScore.HeaderText = "Вес";
            this.ResultScore.Name = "ResultScore";
            this.ResultScore.ReadOnly = true;
            this.ResultScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultScore.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.SecondLabExpertsPassedCountLabel);
            this.Controls.Add(this.FirstLabExpertsPassedCountLabel);
            this.Controls.Add(this.dataGridViewLab1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.ExpertNameFirstLabMethodComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналитик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ExpertNameFirstLabMethodComboBox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridViewLab1;
        private System.Windows.Forms.Label FirstLabExpertsPassedCountLabel;
        private System.Windows.Forms.Label SecondLabExpertsPassedCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternative;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}

