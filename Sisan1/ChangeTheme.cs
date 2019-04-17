using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class ChangeTheme : Form
    {
        public ChangeTheme()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        public string title = ""; 

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 main = Owner as Form1;
                title = textBox1.Text;
                if (textBox1.Text == "")
                    throw new Exception("Введена пустая строка!");
                DialogResult = DialogResult.OK;
                this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
