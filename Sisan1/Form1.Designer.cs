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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Problem = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ExpertNameFirstLabMethodComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewLab2 = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLab1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alternative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstLabExpertsPassedCountLabel = new System.Windows.Forms.Label();
            this.SecondLabExpertsPassedCountLabel = new System.Windows.Forms.Label();
            this.AlternativesDataGridView = new System.Windows.Forms.DataGridView();
            this.AlternativeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLab3FirstMethod = new System.Windows.Forms.DataGridView();
            this.Lab3FirstMethodNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdLabFirstMethodAlternative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdLabFirstMethodWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdLabFirstMethodExpertsPassedCountLabel = new System.Windows.Forms.Label();
            this.dataGridViewRankMethod = new System.Windows.Forms.DataGridView();
            this.dataGridViewRankMethodNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRankMethodAlterntaive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRankMethodWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankMethodExpertsPassedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab3FirstMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRankMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(112, 172);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
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
            // dataGridViewLab2
            // 
            this.dataGridViewLab2.AllowUserToAddRows = false;
            this.dataGridViewLab2.AllowUserToDeleteRows = false;
            this.dataGridViewLab2.AllowUserToResizeColumns = false;
            this.dataGridViewLab2.AllowUserToResizeRows = false;
            this.dataGridViewLab2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.AlternativeName,
            this.ResultScore});
            this.dataGridViewLab2.Location = new System.Drawing.Point(541, 63);
            this.dataGridViewLab2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLab2.Name = "dataGridViewLab2";
            this.dataGridViewLab2.ReadOnly = true;
            this.dataGridViewLab2.RowHeadersVisible = false;
            this.dataGridViewLab2.RowHeadersWidth = 50;
            this.dataGridViewLab2.RowTemplate.Height = 24;
            this.dataGridViewLab2.Size = new System.Drawing.Size(242, 300);
            this.dataGridViewLab2.TabIndex = 20;
            this.dataGridViewLab2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
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
            // dataGridViewLab1
            // 
            this.dataGridViewLab1.AllowUserToAddRows = false;
            this.dataGridViewLab1.AllowUserToDeleteRows = false;
            this.dataGridViewLab1.AllowUserToResizeColumns = false;
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
            this.SecondLabExpertsPassedCountLabel.Location = new System.Drawing.Point(538, 367);
            this.SecondLabExpertsPassedCountLabel.Name = "SecondLabExpertsPassedCountLabel";
            this.SecondLabExpertsPassedCountLabel.Size = new System.Drawing.Size(154, 13);
            this.SecondLabExpertsPassedCountLabel.TabIndex = 23;
            this.SecondLabExpertsPassedCountLabel.Text = "Пройдено 0 из 0 экспертами";
            // 
            // AlternativesDataGridView
            // 
            this.AlternativesDataGridView.AllowUserToAddRows = false;
            this.AlternativesDataGridView.AllowUserToDeleteRows = false;
            this.AlternativesDataGridView.AllowUserToResizeColumns = false;
            this.AlternativesDataGridView.AllowUserToResizeRows = false;
            this.AlternativesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlternativesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlternativeNum,
            this.AlternativeNameColumn});
            this.AlternativesDataGridView.Location = new System.Drawing.Point(16, 63);
            this.AlternativesDataGridView.Name = "AlternativesDataGridView";
            this.AlternativesDataGridView.ReadOnly = true;
            this.AlternativesDataGridView.RowHeadersVisible = false;
            this.AlternativesDataGridView.Size = new System.Drawing.Size(242, 300);
            this.AlternativesDataGridView.TabIndex = 24;
            // 
            // AlternativeNum
            // 
            this.AlternativeNum.HeaderText = "№";
            this.AlternativeNum.Name = "AlternativeNum";
            this.AlternativeNum.ReadOnly = true;
            this.AlternativeNum.Width = 25;
            // 
            // AlternativeNameColumn
            // 
            this.AlternativeNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlternativeNameColumn.HeaderText = "Список альтернатив";
            this.AlternativeNameColumn.Name = "AlternativeNameColumn";
            this.AlternativeNameColumn.ReadOnly = true;
            // 
            // dataGridViewLab3FirstMethod
            // 
            this.dataGridViewLab3FirstMethod.AllowUserToAddRows = false;
            this.dataGridViewLab3FirstMethod.AllowUserToDeleteRows = false;
            this.dataGridViewLab3FirstMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLab3FirstMethod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lab3FirstMethodNum,
            this.ThirdLabFirstMethodAlternative,
            this.ThirdLabFirstMethodWeight});
            this.dataGridViewLab3FirstMethod.Location = new System.Drawing.Point(803, 63);
            this.dataGridViewLab3FirstMethod.Name = "dataGridViewLab3FirstMethod";
            this.dataGridViewLab3FirstMethod.ReadOnly = true;
            this.dataGridViewLab3FirstMethod.RowHeadersVisible = false;
            this.dataGridViewLab3FirstMethod.Size = new System.Drawing.Size(242, 299);
            this.dataGridViewLab3FirstMethod.TabIndex = 25;
            this.dataGridViewLab3FirstMethod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLab3FirstMethod_CellContentClick);
            // 
            // Lab3FirstMethodNum
            // 
            this.Lab3FirstMethodNum.HeaderText = "№";
            this.Lab3FirstMethodNum.Name = "Lab3FirstMethodNum";
            this.Lab3FirstMethodNum.ReadOnly = true;
            this.Lab3FirstMethodNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lab3FirstMethodNum.Width = 25;
            // 
            // ThirdLabFirstMethodAlternative
            // 
            this.ThirdLabFirstMethodAlternative.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThirdLabFirstMethodAlternative.HeaderText = "Альтерантива";
            this.ThirdLabFirstMethodAlternative.Name = "ThirdLabFirstMethodAlternative";
            this.ThirdLabFirstMethodAlternative.ReadOnly = true;
            // 
            // ThirdLabFirstMethodWeight
            // 
            this.ThirdLabFirstMethodWeight.HeaderText = "Вес";
            this.ThirdLabFirstMethodWeight.Name = "ThirdLabFirstMethodWeight";
            this.ThirdLabFirstMethodWeight.ReadOnly = true;
            // 
            // ThirdLabFirstMethodExpertsPassedCountLabel
            // 
            this.ThirdLabFirstMethodExpertsPassedCountLabel.AutoSize = true;
            this.ThirdLabFirstMethodExpertsPassedCountLabel.Location = new System.Drawing.Point(800, 367);
            this.ThirdLabFirstMethodExpertsPassedCountLabel.Name = "ThirdLabFirstMethodExpertsPassedCountLabel";
            this.ThirdLabFirstMethodExpertsPassedCountLabel.Size = new System.Drawing.Size(154, 13);
            this.ThirdLabFirstMethodExpertsPassedCountLabel.TabIndex = 26;
            this.ThirdLabFirstMethodExpertsPassedCountLabel.Text = "Пройдено 0 из 0 экспертами";
            // 
            // dataGridViewRankMethod
            // 
            this.dataGridViewRankMethod.AllowUserToAddRows = false;
            this.dataGridViewRankMethod.AllowUserToDeleteRows = false;
            this.dataGridViewRankMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRankMethod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewRankMethodNum,
            this.dataGridViewRankMethodAlterntaive,
            this.dataGridViewRankMethodWeight});
            this.dataGridViewRankMethod.Location = new System.Drawing.Point(1067, 63);
            this.dataGridViewRankMethod.Name = "dataGridViewRankMethod";
            this.dataGridViewRankMethod.ReadOnly = true;
            this.dataGridViewRankMethod.RowHeadersVisible = false;
            this.dataGridViewRankMethod.Size = new System.Drawing.Size(242, 299);
            this.dataGridViewRankMethod.TabIndex = 27;
            // 
            // dataGridViewRankMethodNum
            // 
            this.dataGridViewRankMethodNum.HeaderText = "№";
            this.dataGridViewRankMethodNum.Name = "dataGridViewRankMethodNum";
            this.dataGridViewRankMethodNum.ReadOnly = true;
            this.dataGridViewRankMethodNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRankMethodNum.Width = 25;
            // 
            // dataGridViewRankMethodAlterntaive
            // 
            this.dataGridViewRankMethodAlterntaive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRankMethodAlterntaive.HeaderText = "Альтерантива";
            this.dataGridViewRankMethodAlterntaive.Name = "dataGridViewRankMethodAlterntaive";
            this.dataGridViewRankMethodAlterntaive.ReadOnly = true;
            // 
            // dataGridViewRankMethodWeight
            // 
            this.dataGridViewRankMethodWeight.HeaderText = "Вес";
            this.dataGridViewRankMethodWeight.Name = "dataGridViewRankMethodWeight";
            this.dataGridViewRankMethodWeight.ReadOnly = true;
            // 
            // RankMethodExpertsPassedLabel
            // 
            this.RankMethodExpertsPassedLabel.AutoSize = true;
            this.RankMethodExpertsPassedLabel.Location = new System.Drawing.Point(1064, 367);
            this.RankMethodExpertsPassedLabel.Name = "RankMethodExpertsPassedLabel";
            this.RankMethodExpertsPassedLabel.Size = new System.Drawing.Size(154, 13);
            this.RankMethodExpertsPassedLabel.TabIndex = 28;
            this.RankMethodExpertsPassedLabel.Text = "Пройдено 0 из 0 экспертами";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1321, 393);
            this.Controls.Add(this.RankMethodExpertsPassedLabel);
            this.Controls.Add(this.dataGridViewRankMethod);
            this.Controls.Add(this.ThirdLabFirstMethodExpertsPassedCountLabel);
            this.Controls.Add(this.dataGridViewLab3FirstMethod);
            this.Controls.Add(this.AlternativesDataGridView);
            this.Controls.Add(this.SecondLabExpertsPassedCountLabel);
            this.Controls.Add(this.FirstLabExpertsPassedCountLabel);
            this.Controls.Add(this.dataGridViewLab1);
            this.Controls.Add(this.dataGridViewLab2);
            this.Controls.Add(this.ExpertNameFirstLabMethodComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналитик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab3FirstMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRankMethod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ExpertNameFirstLabMethodComboBox;
        private System.Windows.Forms.DataGridView dataGridViewLab2;
        private System.Windows.Forms.DataGridView dataGridViewLab1;
        private System.Windows.Forms.Label FirstLabExpertsPassedCountLabel;
        private System.Windows.Forms.Label SecondLabExpertsPassedCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternative;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridView AlternativesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeNameColumn;
        private System.Windows.Forms.DataGridView dataGridViewLab3FirstMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lab3FirstMethodNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdLabFirstMethodAlternative;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdLabFirstMethodWeight;
        private System.Windows.Forms.Label ThirdLabFirstMethodExpertsPassedCountLabel;
        private System.Windows.Forms.DataGridView dataGridViewRankMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewRankMethodNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewRankMethodAlterntaive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewRankMethodWeight;
        private System.Windows.Forms.Label RankMethodExpertsPassedLabel;
    }
}

