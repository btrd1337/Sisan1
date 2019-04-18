namespace Sisan1
{
    partial class MakeExpert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeExpert));
            this.AddExpertButton = new System.Windows.Forms.Button();
            this.ExpertNameTextBox = new System.Windows.Forms.TextBox();
            this.ExpertNameLabel = new System.Windows.Forms.Label();
            this.ExpertCoefficientLabel = new System.Windows.Forms.Label();
            this.ExpertListComboBox = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.ExpertCoefficientNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EditExpertGroupBox = new System.Windows.Forms.GroupBox();
            this.EditExpertCoefficientNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EditExpertCoefficientLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProblemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SaveEditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExpertCoefficientNumericUpDown)).BeginInit();
            this.EditExpertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditExpertCoefficientNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddExpertButton
            // 
            this.AddExpertButton.Location = new System.Drawing.Point(12, 102);
            this.AddExpertButton.Name = "AddExpertButton";
            this.AddExpertButton.Size = new System.Drawing.Size(223, 58);
            this.AddExpertButton.TabIndex = 0;
            this.AddExpertButton.Text = "Добавить эксперта";
            this.AddExpertButton.UseVisualStyleBackColor = true;
            this.AddExpertButton.Click += new System.EventHandler(this.AddExpertButton_Click);
            // 
            // ExpertNameTextBox
            // 
            this.ExpertNameTextBox.Location = new System.Drawing.Point(13, 47);
            this.ExpertNameTextBox.Name = "ExpertNameTextBox";
            this.ExpertNameTextBox.Size = new System.Drawing.Size(334, 20);
            this.ExpertNameTextBox.TabIndex = 1;
            this.ExpertNameTextBox.TextChanged += new System.EventHandler(this.ExpertNameTextBox_TextChanged);
            // 
            // ExpertNameLabel
            // 
            this.ExpertNameLabel.AutoSize = true;
            this.ExpertNameLabel.Location = new System.Drawing.Point(353, 50);
            this.ExpertNameLabel.Name = "ExpertNameLabel";
            this.ExpertNameLabel.Size = new System.Drawing.Size(85, 13);
            this.ExpertNameLabel.TabIndex = 2;
            this.ExpertNameLabel.Text = "ФИО Эксперта";
            // 
            // ExpertCoefficientLabel
            // 
            this.ExpertCoefficientLabel.AutoSize = true;
            this.ExpertCoefficientLabel.Location = new System.Drawing.Point(353, 76);
            this.ExpertCoefficientLabel.Name = "ExpertCoefficientLabel";
            this.ExpertCoefficientLabel.Size = new System.Drawing.Size(77, 13);
            this.ExpertCoefficientLabel.TabIndex = 4;
            this.ExpertCoefficientLabel.Text = "Коэффициент";
            // 
            // ExpertListComboBox
            // 
            this.ExpertListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpertListComboBox.FormattingEnabled = true;
            this.ExpertListComboBox.Location = new System.Drawing.Point(12, 166);
            this.ExpertListComboBox.Name = "ExpertListComboBox";
            this.ExpertListComboBox.Size = new System.Drawing.Size(334, 21);
            this.ExpertListComboBox.TabIndex = 5;
            this.ExpertListComboBox.SelectedIndexChanged += new System.EventHandler(this.ExpertListComboBox_SelectedIndexChanged);
            this.ExpertListComboBox.Click += new System.EventHandler(this.ExpertListComboBox_Click);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 26);
            this.Exit.TabIndex = 8;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ExpertCoefficientNumericUpDown
            // 
            this.ExpertCoefficientNumericUpDown.DecimalPlaces = 2;
            this.ExpertCoefficientNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ExpertCoefficientNumericUpDown.Location = new System.Drawing.Point(13, 76);
            this.ExpertCoefficientNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ExpertCoefficientNumericUpDown.Name = "ExpertCoefficientNumericUpDown";
            this.ExpertCoefficientNumericUpDown.Size = new System.Drawing.Size(333, 20);
            this.ExpertCoefficientNumericUpDown.TabIndex = 9;
            // 
            // EditExpertGroupBox
            // 
            this.EditExpertGroupBox.Controls.Add(this.SaveEditButton);
            this.EditExpertGroupBox.Controls.Add(this.dataGridView1);
            this.EditExpertGroupBox.Controls.Add(this.EditExpertCoefficientNumericUpDown);
            this.EditExpertGroupBox.Controls.Add(this.EditExpertCoefficientLabel);
            this.EditExpertGroupBox.Location = new System.Drawing.Point(13, 194);
            this.EditExpertGroupBox.Name = "EditExpertGroupBox";
            this.EditExpertGroupBox.Size = new System.Drawing.Size(425, 215);
            this.EditExpertGroupBox.TabIndex = 10;
            this.EditExpertGroupBox.TabStop = false;
            this.EditExpertGroupBox.Text = "Редактирование";
            this.EditExpertGroupBox.Visible = false;
            // 
            // EditExpertCoefficientNumericUpDown
            // 
            this.EditExpertCoefficientNumericUpDown.DecimalPlaces = 2;
            this.EditExpertCoefficientNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EditExpertCoefficientNumericUpDown.Location = new System.Drawing.Point(6, 19);
            this.EditExpertCoefficientNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EditExpertCoefficientNumericUpDown.Name = "EditExpertCoefficientNumericUpDown";
            this.EditExpertCoefficientNumericUpDown.Size = new System.Drawing.Size(333, 20);
            this.EditExpertCoefficientNumericUpDown.TabIndex = 11;
            // 
            // EditExpertCoefficientLabel
            // 
            this.EditExpertCoefficientLabel.AutoSize = true;
            this.EditExpertCoefficientLabel.Location = new System.Drawing.Point(346, 19);
            this.EditExpertCoefficientLabel.Name = "EditExpertCoefficientLabel";
            this.EditExpertCoefficientLabel.Size = new System.Drawing.Size(77, 13);
            this.EditExpertCoefficientLabel.TabIndex = 10;
            this.EditExpertCoefficientLabel.Text = "Коэффициент";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProblemNameColumn,
            this.CheckBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(333, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProblemNameColumn
            // 
            this.ProblemNameColumn.HeaderText = "Проблема";
            this.ProblemNameColumn.Name = "ProblemNameColumn";
            this.ProblemNameColumn.ReadOnly = true;
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.HeaderText = "";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.ReadOnly = true;
            // 
            // SaveEditButton
            // 
            this.SaveEditButton.Location = new System.Drawing.Point(349, 45);
            this.SaveEditButton.Name = "SaveEditButton";
            this.SaveEditButton.Size = new System.Drawing.Size(70, 23);
            this.SaveEditButton.TabIndex = 13;
            this.SaveEditButton.Text = "Сохранить";
            this.SaveEditButton.UseVisualStyleBackColor = true;
            this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
            // 
            // MakeExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 421);
            this.Controls.Add(this.EditExpertGroupBox);
            this.Controls.Add(this.ExpertCoefficientNumericUpDown);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ExpertListComboBox);
            this.Controls.Add(this.ExpertCoefficientLabel);
            this.Controls.Add(this.ExpertNameLabel);
            this.Controls.Add(this.ExpertNameTextBox);
            this.Controls.Add(this.AddExpertButton);
            this.Name = "MakeExpert";
            this.Text = "MakeExpert";
            this.Load += new System.EventHandler(this.MakeExpert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpertCoefficientNumericUpDown)).EndInit();
            this.EditExpertGroupBox.ResumeLayout(false);
            this.EditExpertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditExpertCoefficientNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddExpertButton;
        private System.Windows.Forms.TextBox ExpertNameTextBox;
        private System.Windows.Forms.Label ExpertNameLabel;
        private System.Windows.Forms.Label ExpertCoefficientLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.NumericUpDown ExpertCoefficientNumericUpDown;
        private System.Windows.Forms.GroupBox EditExpertGroupBox;
        private System.Windows.Forms.NumericUpDown EditExpertCoefficientNumericUpDown;
        private System.Windows.Forms.Label EditExpertCoefficientLabel;
        private System.Windows.Forms.ComboBox ExpertListComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemNameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.Button SaveEditButton;
    }
}