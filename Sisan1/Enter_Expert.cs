using System;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class Enter_Expert : Form
    {
        public Enter_Expert()
        {
            InitializeComponent();

        }

        public static string ChosenProblem;

        private void Enter_Expert_Load(object sender, EventArgs e)
        {
            if (Enter_Analyst.Problems.Count > 0)
            {
                Problem1.Text = Enter_Analyst.Problems[0];
                Problem1.Visible = true;
            }
            if (Enter_Analyst.Problems.Count > 1)
            {
                Problem2.Text = Enter_Analyst.Problems[1];
                Problem2.Visible = true;
            }
            if (Enter_Analyst.Problems.Count > 2)
            {
                Problem3.Text = Enter_Analyst.Problems[2];
                Problem3.Visible = true;
            }
        }

        private void Problem1_Click(object sender, EventArgs e)
        {
            ChosenProblem = Problem1.Text;
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void Problem2_Click(object sender, EventArgs e)
        {
            ChosenProblem = Problem2.Text;
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void Problem3_Click(object sender, EventArgs e)
        {
            ChosenProblem = Problem3.Text;
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }
    }
}
