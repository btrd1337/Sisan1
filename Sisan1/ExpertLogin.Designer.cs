namespace Sisan1
{
    partial class ExpertLogin
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
            this.ExpertsListComboBox = new System.Windows.Forms.ComboBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpertsListComboBox
            // 
            this.ExpertsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpertsListComboBox.FormattingEnabled = true;
            this.ExpertsListComboBox.Location = new System.Drawing.Point(12, 23);
            this.ExpertsListComboBox.Name = "ExpertsListComboBox";
            this.ExpertsListComboBox.Size = new System.Drawing.Size(252, 21);
            this.ExpertsListComboBox.TabIndex = 0;
            this.ExpertsListComboBox.SelectedIndexChanged += new System.EventHandler(this.ExpertsListComboBox_SelectedIndexChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(12, 66);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(Sisan1.Form2);
            // 
            // ExpertLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ExpertsListComboBox);
            this.Name = "ExpertLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpertLogin";
            this.Load += new System.EventHandler(this.ExpertLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ExpertsListComboBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.BindingSource form2BindingSource;
    }
}