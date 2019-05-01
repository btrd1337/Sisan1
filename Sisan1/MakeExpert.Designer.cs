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
            this.ProblemsListComboBox = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.EditExpertGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteExpert = new System.Windows.Forms.Button();
            this.SaveEditButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExpertNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditExpertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddExpertButton
            // 
            this.AddExpertButton.Location = new System.Drawing.Point(12, 73);
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
            // ProblemsListComboBox
            // 
            this.ProblemsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProblemsListComboBox.FormattingEnabled = true;
            this.ProblemsListComboBox.Location = new System.Drawing.Point(13, 137);
            this.ProblemsListComboBox.Name = "ProblemsListComboBox";
            this.ProblemsListComboBox.Size = new System.Drawing.Size(334, 21);
            this.ProblemsListComboBox.TabIndex = 5;
            this.ProblemsListComboBox.SelectedIndexChanged += new System.EventHandler(this.ExpertListComboBox_SelectedIndexChanged);
            this.ProblemsListComboBox.Click += new System.EventHandler(this.ExpertListComboBox_Click);
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
            // EditExpertGroupBox
            // 
            this.EditExpertGroupBox.Controls.Add(this.DeleteExpert);
            this.EditExpertGroupBox.Controls.Add(this.SaveEditButton);
            this.EditExpertGroupBox.Controls.Add(this.dataGridView1);
            this.EditExpertGroupBox.Location = new System.Drawing.Point(13, 164);
            this.EditExpertGroupBox.Name = "EditExpertGroupBox";
            this.EditExpertGroupBox.Size = new System.Drawing.Size(425, 215);
            this.EditExpertGroupBox.TabIndex = 10;
            this.EditExpertGroupBox.TabStop = false;
            this.EditExpertGroupBox.Text = "Редактирование";
            this.EditExpertGroupBox.Visible = false;
            // 
            // DeleteExpert
            // 
            this.DeleteExpert.Location = new System.Drawing.Point(349, 48);
            this.DeleteExpert.Name = "DeleteExpert";
            this.DeleteExpert.Size = new System.Drawing.Size(70, 25);
            this.DeleteExpert.TabIndex = 14;
            this.DeleteExpert.Text = "Удалить";
            this.DeleteExpert.UseVisualStyleBackColor = true;
            this.DeleteExpert.Visible = false;
            this.DeleteExpert.Click += new System.EventHandler(this.DeleteExpert_Click);
            // 
            // SaveEditButton
            // 
            this.SaveEditButton.Location = new System.Drawing.Point(349, 19);
            this.SaveEditButton.Name = "SaveEditButton";
            this.SaveEditButton.Size = new System.Drawing.Size(70, 23);
            this.SaveEditButton.TabIndex = 13;
            this.SaveEditButton.Text = "Сохранить";
            this.SaveEditButton.UseVisualStyleBackColor = true;
            this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpertNameColumn,
            this.CheckBoxColumn,
            this.Coefficient});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(333, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ExpertNameColumn
            // 
            this.ExpertNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpertNameColumn.HeaderText = "Эксперт";
            this.ExpertNameColumn.Name = "ExpertNameColumn";
            this.ExpertNameColumn.ReadOnly = true;
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.HeaderText = "";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Width = 40;
            // 
            // Coefficient
            // 
            this.Coefficient.HeaderText = "Вес";
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.ReadOnly = true;
            // 
            // MakeExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 418);
            this.Controls.Add(this.EditExpertGroupBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ProblemsListComboBox);
            this.Controls.Add(this.ExpertNameLabel);
            this.Controls.Add(this.ExpertNameTextBox);
            this.Controls.Add(this.AddExpertButton);
            this.Name = "MakeExpert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeExpert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MakeExpert_FormClosing);
            this.Load += new System.EventHandler(this.MakeExpert_Load);
            this.EditExpertGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddExpertButton;
        private System.Windows.Forms.TextBox ExpertNameTextBox;
        private System.Windows.Forms.Label ExpertNameLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox EditExpertGroupBox;
        private System.Windows.Forms.ComboBox ProblemsListComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveEditButton;
        private System.Windows.Forms.Button DeleteExpert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertNameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficient;
    }
}