namespace Sisan1
{
    partial class Enter_Expert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_Expert));
            this.Problem3 = new System.Windows.Forms.Button();
            this.Problem2 = new System.Windows.Forms.Button();
            this.Problem1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Problem3
            // 
            this.Problem3.Location = new System.Drawing.Point(12, 142);
            this.Problem3.Name = "Problem3";
            this.Problem3.Size = new System.Drawing.Size(215, 43);
            this.Problem3.TabIndex = 5;
            this.Problem3.Text = "Problem3";
            this.Problem3.UseVisualStyleBackColor = true;
            this.Problem3.Visible = false;
            this.Problem3.Click += new System.EventHandler(this.Problem3_Click);
            // 
            // Problem2
            // 
            this.Problem2.Location = new System.Drawing.Point(12, 93);
            this.Problem2.Name = "Problem2";
            this.Problem2.Size = new System.Drawing.Size(215, 43);
            this.Problem2.TabIndex = 4;
            this.Problem2.Text = "Problem2";
            this.Problem2.UseVisualStyleBackColor = true;
            this.Problem2.Visible = false;
            this.Problem2.Click += new System.EventHandler(this.Problem2_Click);
            // 
            // Problem1
            // 
            this.Problem1.Location = new System.Drawing.Point(12, 44);
            this.Problem1.Name = "Problem1";
            this.Problem1.Size = new System.Drawing.Size(215, 43);
            this.Problem1.TabIndex = 3;
            this.Problem1.Text = "Problem1";
            this.Problem1.UseVisualStyleBackColor = true;
            this.Problem1.Visible = false;
            this.Problem1.Click += new System.EventHandler(this.Problem1_Click);
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 26);
            this.Exit.TabIndex = 6;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Enter_Expert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 208);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Problem3);
            this.Controls.Add(this.Problem2);
            this.Controls.Add(this.Problem1);
            this.Name = "Enter_Expert";
            this.Text = "Выбор проблемы";
            this.Load += new System.EventHandler(this.Enter_Expert_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Problem3;
        private System.Windows.Forms.Button Problem2;
        private System.Windows.Forms.Button Problem1;
        private System.Windows.Forms.Button Exit;
    }
}