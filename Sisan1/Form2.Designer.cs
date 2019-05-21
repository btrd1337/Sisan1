namespace Sisan1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alternative1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeAgree = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AlternativeNeutral = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AlternativeDisagree = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Alternative2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MethodsComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AlternativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab2Label = new System.Windows.Forms.Label();
            this.CountWeightLabel = new System.Windows.Forms.Label();
            this.ProblemNameLabel = new System.Windows.Forms.Label();
            this.dataGridViewLab4 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpbutton = new System.Windows.Forms.Button();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Начать тестирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Enabled = false;
            this.FinishButton.Location = new System.Drawing.Point(684, 449);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Закончить";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Visible = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(42, 37);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 27);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Выйти и сохранить";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alternative1,
            this.AlternativeAgree,
            this.AlternativeNeutral,
            this.AlternativeDisagree,
            this.Alternative2});
            this.dataGridView1.Location = new System.Drawing.Point(13, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1323, 374);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // Alternative1
            // 
            this.Alternative1.HeaderText = "Альтернатива 1";
            this.Alternative1.Name = "Alternative1";
            this.Alternative1.ReadOnly = true;
            this.Alternative1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Alternative1.Width = 601;
            // 
            // AlternativeAgree
            // 
            this.AlternativeAgree.HeaderText = " ";
            this.AlternativeAgree.Name = "AlternativeAgree";
            this.AlternativeAgree.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AlternativeAgree.ToolTipText = "Альтернатива 1 предпочтительнее";
            this.AlternativeAgree.Width = 20;
            // 
            // AlternativeNeutral
            // 
            this.AlternativeNeutral.HeaderText = " ";
            this.AlternativeNeutral.Name = "AlternativeNeutral";
            this.AlternativeNeutral.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AlternativeNeutral.ToolTipText = "Альтернативы равнозначны";
            this.AlternativeNeutral.Width = 20;
            // 
            // AlternativeDisagree
            // 
            this.AlternativeDisagree.HeaderText = " ";
            this.AlternativeDisagree.Name = "AlternativeDisagree";
            this.AlternativeDisagree.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AlternativeDisagree.ToolTipText = "Альтерантива 2 предпочтительнее";
            this.AlternativeDisagree.Width = 20;
            // 
            // Alternative2
            // 
            this.Alternative2.HeaderText = "Альтернатива 2";
            this.Alternative2.Name = "Alternative2";
            this.Alternative2.ReadOnly = true;
            this.Alternative2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Alternative2.Width = 602;
            // 
            // MethodsComboBox
            // 
            this.MethodsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MethodsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MethodsComboBox.FormattingEnabled = true;
            this.MethodsComboBox.Location = new System.Drawing.Point(223, 40);
            this.MethodsComboBox.Name = "MethodsComboBox";
            this.MethodsComboBox.Size = new System.Drawing.Size(179, 21);
            this.MethodsComboBox.TabIndex = 28;
            this.MethodsComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MethodsComboBox_DrawItem);
            this.MethodsComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodsComboBox_SelectedIndexChanged);
            this.MethodsComboBox.MouseHover += new System.EventHandler(this.MethodsComboBox_MouseHover);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlternativeName,
            this.AlternativeScore});
            this.dataGridView2.Location = new System.Drawing.Point(12, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(870, 379);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // AlternativeName
            // 
            this.AlternativeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlternativeName.HeaderText = "Альтернатива";
            this.AlternativeName.Name = "AlternativeName";
            this.AlternativeName.ReadOnly = true;
            this.AlternativeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AlternativeScore
            // 
            this.AlternativeScore.HeaderText = "Вес";
            this.AlternativeScore.Name = "AlternativeScore";
            this.AlternativeScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AlternativeScore.Width = 200;
            // 
            // Lab2Label
            // 
            this.Lab2Label.AutoSize = true;
            this.Lab2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lab2Label.Location = new System.Drawing.Point(38, 41);
            this.Lab2Label.Name = "Lab2Label";
            this.Lab2Label.Size = new System.Drawing.Size(395, 20);
            this.Lab2Label.TabIndex = 30;
            this.Lab2Label.Text = "Введите вес альтернативам по шкале от 0 до 100";
            this.Lab2Label.Visible = false;
            // 
            // CountWeightLabel
            // 
            this.CountWeightLabel.AutoSize = true;
            this.CountWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountWeightLabel.Location = new System.Drawing.Point(630, 43);
            this.CountWeightLabel.Name = "CountWeightLabel";
            this.CountWeightLabel.Size = new System.Drawing.Size(140, 16);
            this.CountWeightLabel.TabIndex = 31;
            this.CountWeightLabel.Text = "Общий вес = 0 из 100";
            this.CountWeightLabel.Visible = false;
            // 
            // ProblemNameLabel
            // 
            this.ProblemNameLabel.AutoSize = true;
            this.ProblemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ProblemNameLabel.Name = "ProblemNameLabel";
            this.ProblemNameLabel.Size = new System.Drawing.Size(121, 20);
            this.ProblemNameLabel.TabIndex = 32;
            this.ProblemNameLabel.Text = "Проблема ли";
            this.ProblemNameLabel.Visible = false;
            // 
            // dataGridViewLab4
            // 
            this.dataGridViewLab4.AllowUserToAddRows = false;
            this.dataGridViewLab4.AllowUserToDeleteRows = false;
            this.dataGridViewLab4.AllowUserToResizeColumns = false;
            this.dataGridViewLab4.AllowUserToResizeRows = false;
            this.dataGridViewLab4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLab4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewLab4.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewLab4.Name = "dataGridViewLab4";
            this.dataGridViewLab4.RowHeadersVisible = false;
            this.dataGridViewLab4.Size = new System.Drawing.Size(1326, 378);
            this.dataGridViewLab4.TabIndex = 33;
            this.dataGridViewLab4.Visible = false;
            this.dataGridViewLab4.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLab4_CellEndEdit);
            this.dataGridViewLab4.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewLab4_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Альтернатива 1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = " ";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = " ";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Альтернатива 2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // helpbutton
            // 
            this.helpbutton.Location = new System.Drawing.Point(408, 39);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(22, 22);
            this.helpbutton.TabIndex = 34;
            this.helpbutton.Text = "?";
            this.helpbutton.UseVisualStyleBackColor = true;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(Sisan1.Form2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 477);
            this.Controls.Add(this.Lab2Label);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.dataGridViewLab4);
            this.Controls.Add(this.ProblemNameLabel);
            this.Controls.Add(this.CountWeightLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MethodsComboBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Эксперт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.ComboBox MethodsComboBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Lab2Label;
        private System.Windows.Forms.Label CountWeightLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternative1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AlternativeAgree;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AlternativeNeutral;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AlternativeDisagree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternative2;
        private System.Windows.Forms.Label ProblemNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeScore;
        private System.Windows.Forms.DataGridView dataGridViewLab4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button helpbutton;
    }
}