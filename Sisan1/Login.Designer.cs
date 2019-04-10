namespace Sisan1
{
    partial class Login
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
            this.analyst = new System.Windows.Forms.Button();
            this.expert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // analyst
            // 
            this.analyst.Location = new System.Drawing.Point(12, 12);
            this.analyst.Name = "analyst";
            this.analyst.Size = new System.Drawing.Size(118, 50);
            this.analyst.TabIndex = 0;
            this.analyst.Text = "Аналитик";
            this.analyst.UseVisualStyleBackColor = true;
            this.analyst.Click += new System.EventHandler(this.analyst_Click);
            // 
            // expert
            // 
            this.expert.Location = new System.Drawing.Point(156, 12);
            this.expert.Name = "expert";
            this.expert.Size = new System.Drawing.Size(118, 50);
            this.expert.TabIndex = 1;
            this.expert.Text = "Эксперт";
            this.expert.UseVisualStyleBackColor = true;
            this.expert.Click += new System.EventHandler(this.expert_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(286, 74);
            this.Controls.Add(this.expert);
            this.Controls.Add(this.analyst);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button analyst;
        private System.Windows.Forms.Button expert;
    }
}