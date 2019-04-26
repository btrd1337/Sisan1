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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.FinishButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.Lab2Label = new System.Windows.Forms.Label();
            this.CountWeightLabel = new System.Windows.Forms.Label();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Начать тестирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPrev);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 165);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите наилучший вариант";
            this.groupBox1.Visible = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(6, 136);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 4;
            this.buttonPrev.Text = "Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(346, 136);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(145, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Варианты равнозначны";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FinishButton
            // 
            this.FinishButton.Enabled = false;
            this.FinishButton.Location = new System.Drawing.Point(683, 426);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Закончить";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Тестирование пройдено";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(41, 14);
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
            this.button2.Location = new System.Drawing.Point(11, 17);
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
            this.comboBox1.Location = new System.Drawing.Point(41, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DrawItem);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_DrawItem);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 173);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(427, 16);
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alternative1,
            this.AlternativeAgree,
            this.AlternativeNeutral,
            this.AlternativeDisagree,
            this.Alternative2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
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
            this.MethodsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MethodsComboBox.FormattingEnabled = true;
            this.MethodsComboBox.Location = new System.Drawing.Point(226, 18);
            this.MethodsComboBox.Name = "MethodsComboBox";
            this.MethodsComboBox.Size = new System.Drawing.Size(179, 21);
            this.MethodsComboBox.TabIndex = 28;
            this.MethodsComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodsComboBox_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlternativeName,
            this.AlternativeScore});
            this.dataGridView2.Location = new System.Drawing.Point(11, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(870, 379);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // AlternativeName
            // 
            this.AlternativeName.HeaderText = "Альтернатива";
            this.AlternativeName.Name = "AlternativeName";
            this.AlternativeName.ReadOnly = true;
            this.AlternativeName.Width = 625;
            // 
            // AlternativeScore
            // 
            this.AlternativeScore.HeaderText = "Вес";
            this.AlternativeScore.Name = "AlternativeScore";
            this.AlternativeScore.Width = 200;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressLabel.Location = new System.Drawing.Point(146, 173);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(41, 13);
            this.ProgressLabel.TabIndex = 26;
            this.ProgressLabel.Text = "label1";
            // 
            // Lab2Label
            // 
            this.Lab2Label.AutoSize = true;
            this.Lab2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lab2Label.Location = new System.Drawing.Point(204, 16);
            this.Lab2Label.Name = "Lab2Label";
            this.Lab2Label.Size = new System.Drawing.Size(395, 20);
            this.Lab2Label.TabIndex = 30;
            this.Lab2Label.Text = "Введите вес альтернативам по шкале от 0 до 100";
            this.Lab2Label.Visible = false;
            // 
            // CountWeightLabel
            // 
            this.CountWeightLabel.AutoSize = true;
            this.CountWeightLabel.Location = new System.Drawing.Point(629, 20);
            this.CountWeightLabel.Name = "CountWeightLabel";
            this.CountWeightLabel.Size = new System.Drawing.Size(117, 13);
            this.CountWeightLabel.TabIndex = 31;
            this.CountWeightLabel.Text = "Общий вес = 0 из 100";
            this.CountWeightLabel.Visible = false;
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(Sisan1.Form2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 461);
            this.Controls.Add(this.CountWeightLabel);
            this.Controls.Add(this.Lab2Label);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MethodsComboBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Эксперт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.ComboBox MethodsComboBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label Lab2Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeScore;
        private System.Windows.Forms.Label CountWeightLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternative1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AlternativeAgree;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AlternativeNeutral;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AlternativeDisagree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternative2;
    }
}