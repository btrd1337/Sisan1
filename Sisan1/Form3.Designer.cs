namespace Sisan1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Problem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonExit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AlternativesListDataGridView = new System.Windows.Forms.DataGridView();
            this.AlternativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveExitButton = new System.Windows.Forms.Button();
            this.ForthLabLabel = new System.Windows.Forms.Label();
            this.FourthLabNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthLabNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Problem
            // 
            this.Problem.AutoSize = true;
            this.Problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Problem.Location = new System.Drawing.Point(42, 11);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(223, 26);
            this.Problem.TabIndex = 19;
            this.Problem.Text = "Название проблемы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Список альтернатив";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(11, 65);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(570, 148);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(11, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(570, 51);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Очистить всё";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить альтернативу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить альтернативу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.buttonExit.Size = new System.Drawing.Size(26, 26);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AlternativesListDataGridView
            // 
            this.AlternativesListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlternativesListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlternativeName});
            this.AlternativesListDataGridView.Location = new System.Drawing.Point(11, 63);
            this.AlternativesListDataGridView.Name = "AlternativesListDataGridView";
            this.AlternativesListDataGridView.Size = new System.Drawing.Size(570, 203);
            this.AlternativesListDataGridView.TabIndex = 1;
            this.AlternativesListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlternativesListDataGridView_CellContentClick);
            this.AlternativesListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlternativesListDataGridView_CellValueChanged);
            this.AlternativesListDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.AlternativesListDataGridView_UserDeletingRow);
            this.AlternativesListDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlternativesListDataGridView_KeyDown);
            this.AlternativesListDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlternativesListDataGridView_KeyPress);
            // 
            // AlternativeName
            // 
            this.AlternativeName.HeaderText = "Альтернативы";
            this.AlternativeName.Name = "AlternativeName";
            this.AlternativeName.Width = 525;
            // 
            // SaveExitButton
            // 
            this.SaveExitButton.Location = new System.Drawing.Point(461, 10);
            this.SaveExitButton.Name = "SaveExitButton";
            this.SaveExitButton.Size = new System.Drawing.Size(120, 27);
            this.SaveExitButton.TabIndex = 25;
            this.SaveExitButton.Text = "Сохранить и выйти";
            this.SaveExitButton.UseVisualStyleBackColor = true;
            this.SaveExitButton.Click += new System.EventHandler(this.SaveExitButton_Click);
            // 
            // ForthLabLabel
            // 
            this.ForthLabLabel.AutoSize = true;
            this.ForthLabLabel.Location = new System.Drawing.Point(364, 42);
            this.ForthLabLabel.Name = "ForthLabLabel";
            this.ForthLabLabel.Size = new System.Drawing.Size(112, 13);
            this.ForthLabLabel.TabIndex = 26;
            this.ForthLabLabel.Text = "Размерность шкалы";
            // 
            // FourthLabNumericUpDown
            // 
            this.FourthLabNumericUpDown.Location = new System.Drawing.Point(482, 40);
            this.FourthLabNumericUpDown.Name = "FourthLabNumericUpDown";
            this.FourthLabNumericUpDown.Size = new System.Drawing.Size(99, 20);
            this.FourthLabNumericUpDown.TabIndex = 28;
            this.FourthLabNumericUpDown.ValueChanged += new System.EventHandler(this.FourthLabNumericUpDown_ValueChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 285);
            this.Controls.Add(this.FourthLabNumericUpDown);
            this.Controls.Add(this.ForthLabLabel);
            this.Controls.Add(this.SaveExitButton);
            this.Controls.Add(this.AlternativesListDataGridView);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Problem);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа со списком альтернатив";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthLabNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView AlternativesListDataGridView;
        private System.Windows.Forms.Button SaveExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeName;
        private System.Windows.Forms.Label ForthLabLabel;
        private System.Windows.Forms.NumericUpDown FourthLabNumericUpDown;
    }
}