namespace Sisan1
{
    partial class Enter_Analyst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_Analyst));
            this.NewProblem = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Delete1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NewProblemTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnalyticsFormButton = new System.Windows.Forms.Button();
            this.ProcessingToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.database1DataSet = new Sisan1.Database1DataSet();
            this.alternativesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alternativesTableTableAdapter = new Sisan1.Database1DataSetTableAdapters.AlternativesTableTableAdapter();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alternativesTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativesTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewProblem
            // 
            this.NewProblem.Location = new System.Drawing.Point(12, 70);
            this.NewProblem.Name = "NewProblem";
            this.NewProblem.Size = new System.Drawing.Size(265, 54);
            this.NewProblem.TabIndex = 3;
            this.NewProblem.Text = "Создать проблему";
            this.NewProblem.UseVisualStyleBackColor = true;
            this.NewProblem.Click += new System.EventHandler(this.NewProblem_Click);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(0, 18);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 26);
            this.Exit.TabIndex = 7;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Delete1
            // 
            this.Delete1.Image = ((System.Drawing.Image)(resources.GetObject("Delete1.Image")));
            this.Delete1.Location = new System.Drawing.Point(233, 130);
            this.Delete1.Name = "Delete1";
            this.Delete1.Size = new System.Drawing.Size(44, 42);
            this.Delete1.TabIndex = 8;
            this.Delete1.UseVisualStyleBackColor = true;
            this.Delete1.Visible = false;
            this.Delete1.Click += new System.EventHandler(this.Delete1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // NewProblemTextBox
            // 
            this.NewProblemTextBox.Location = new System.Drawing.Point(32, 22);
            this.NewProblemTextBox.Name = "NewProblemTextBox";
            this.NewProblemTextBox.Size = new System.Drawing.Size(233, 20);
            this.NewProblemTextBox.TabIndex = 12;
            this.NewProblemTextBox.TextChanged += new System.EventHandler(this.NewProblemTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.NewProblemTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "        Введите название новой проблемы";
            // 
            // AnalyticsFormButton
            // 
            this.AnalyticsFormButton.Image = ((System.Drawing.Image)(resources.GetObject("AnalyticsFormButton.Image")));
            this.AnalyticsFormButton.Location = new System.Drawing.Point(183, 130);
            this.AnalyticsFormButton.Name = "AnalyticsFormButton";
            this.AnalyticsFormButton.Size = new System.Drawing.Size(44, 42);
            this.AnalyticsFormButton.TabIndex = 14;
            this.AnalyticsFormButton.UseVisualStyleBackColor = true;
            this.AnalyticsFormButton.Click += new System.EventHandler(this.AnalyticsFormButton_Click);
            // 
            // ProcessingToolTip
            // 
            this.ProcessingToolTip.ToolTipTitle = "Перейти к обработке";
            // 
            // DeleteToolTip
            // 
            this.DeleteToolTip.ToolTipTitle = "Удалить проблему";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alternativesTableBindingSource
            // 
            this.alternativesTableBindingSource.DataMember = "AlternativesTable";
            this.alternativesTableBindingSource.DataSource = this.database1DataSet;
            // 
            // alternativesTableTableAdapter
            // 
            this.alternativesTableTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSetBindingSource1
            // 
            this.database1DataSetBindingSource1.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource1.Position = 0;
            // 
            // alternativesTableBindingSource1
            // 
            this.alternativesTableBindingSource1.DataMember = "AlternativesTable";
            this.alternativesTableBindingSource1.DataSource = this.database1DataSet;
            // 
            // Enter_Analyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 184);
            this.Controls.Add(this.AnalyticsFormButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Delete1);
            this.Controls.Add(this.NewProblem);
            this.Name = "Enter_Analyst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор проблемы";
            this.Load += new System.EventHandler(this.Enter_Analyst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativesTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewProblem;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Delete1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource alternativesTableBindingSource;
        private Database1DataSetTableAdapters.AlternativesTableTableAdapter alternativesTableTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.BindingSource alternativesTableBindingSource1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox NewProblemTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AnalyticsFormButton;
        private System.Windows.Forms.ToolTip ProcessingToolTip;
        private System.Windows.Forms.ToolTip DeleteToolTip;
    }
}