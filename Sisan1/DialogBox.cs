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
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void DialogBox_Load(object sender, EventArgs e)
        {

        }
        public string alternative;

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form1 main = Owner as Form1;
                alternative = textBox1.Text;
                if (textBox1.Text == "")
                    throw new Exception("Введена пустая строка!");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
