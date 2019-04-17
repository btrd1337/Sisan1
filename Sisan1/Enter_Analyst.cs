using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class Enter_Analyst : Form
    {
        //string[] colorsNames = { "Красный", "Синий", "Зеленый" };
        Color[] colors = { Color.LightPink, Color.LightGreen };

        public Enter_Analyst()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitOldSessions();
            InitializeComponent();
            RefreshForm();
        }

        private void InitOldSessions()
        {
            CurSession.LoadSession();
            if (CurSession.Problems.Count < Constants.MAX_ITEMS && CurSession.Problems.Count > 0)
            {
                for (int i = 0; i < CurSession.Problems.Count; ++i)
                {
                    if (!Problems.Contains(CurSession.Problems[i]))
                    {
                        //comboBox1.Items[i].ToString();
                        Problems.Add(CurSession.Problems[i]);
                        ChosenProblemA = CurSession.Problems[i];
                    }
                }
            }
            CurSession.initalized = true;

        }

        Sessions CurSession = new Sessions();
        public static List<string> Problems = new List<string>();
        //public static List<string> Problems;
        public static string ChosenProblemA;

        public void RefreshForm()
        {
            NewProblem.Enabled = true;
            //Problem1.Visible = false;
            Delete1.Visible = true;
            AnalyticsFormButton.Visible = true;
            //Problem2.Visible = false;
            //Delete2.Visible = false;
            //Problem3.Visible = false;
            //Delete3.Visible = false;
            Problems = CurSession.Problems;
            if (Problems.Count == 0)
            {
                Delete1.Enabled = false;
                AnalyticsFormButton.Visible = false;
            }
            if (Problems.Count > 0)
            {
                bindingSource1.DataSource = Problems;
                comboBox1.DataSource = bindingSource1.DataSource;
                //comboBox1.Items[1].ToString() = Problems[0];
                //Problem1.Visible = true;
                Delete1.Visible = true;
            }

        }

        private void NewProblem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Problems.Count < Constants.MAX_ITEMS)
                {

                    string ProblemName = NewProblemTextBox.Text;
                    if (ProblemName == "")
                    {
                        throw new Exception("Введена пустая строка!");
                    }


                    ////////////////////////
                    //var db = new ChangeTheme();
                    //db.Owner = this;
                    //db.ShowDialog();

                    //if (db.DialogResult == DialogResult.OK)
                    //{
                    if (!Problems.Contains(ProblemName))

                    {
                        Problems.Add(ProblemName);
                        ChosenProblemA = ProblemName;

                        CurSession.SaveSession(ChosenProblemA);

                        Form3 form = new Form3();
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        throw new Exception("Проблема с таким названием уже существует");
                    }
                    //}

                }
                else
                {
                    throw new Exception("Сликшом много проблем.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Enter_Analyst_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.AlternativesTable". При необходимости она может быть перемещена или удалена.
            this.alternativesTableTableAdapter.Fill(this.database1DataSet.AlternativesTable);
            DeleteToolTip.SetToolTip(this.Delete1, "Удалить проблему");
            ProcessingToolTip.SetToolTip(this.AnalyticsFormButton, "Перейти к обработке");
            comboBox1.DrawItem += comboBox1_DrawItem;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            RefreshForm();
        }

        private void Problem1_Click(object sender, EventArgs e)
        {
            ChosenProblemA = comboBox1.Items[1].ToString();
            if (CurSession.CheckMatrix(comboBox1.Items[1].ToString()))
            {
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Эксперт еще не прошел тестирование по теме: " + comboBox1.Items[1].ToString());
            }
        }

        private void Problem2_Click(object sender, EventArgs e)
        {
            ChosenProblemA = comboBox1.Items[2].ToString();
            if (CurSession.CheckMatrix(comboBox1.Items[2].ToString()))
            {
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Эксперт еще не прошел тестирование по теме: " + comboBox1.Items[2].ToString());
            }
        }

        private void Problem3_Click(object sender, EventArgs e)
        {
            ChosenProblemA = comboBox1.Items[3].ToString();
            if (CurSession.CheckMatrix(comboBox1.Items[3].ToString()))
            {
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Эксперт еще не прошел тестирование по теме: " + comboBox1.Items[3].ToString());
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void Delete1_Click(object sender, EventArgs e)
        {
            CurSession.RemoveProblem(comboBox1.SelectedItem.ToString());
            Problems.RemoveAt(comboBox1.SelectedIndex);
            //comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            //comboBox1.DataSource = bindingSource1.DataSource;
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = bindingSource1.DataSource;
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            RefreshForm();
            /* CurSession.RemoveProblem(Problems[0]);
             Problems.RemoveAt(0);
             RefreshForm();
         */
        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            CurSession.RemoveProblem(Problems[1]);
            Problems.RemoveAt(1);
            RefreshForm();
        }

        private void Delete3_Click(object sender, EventArgs e)
        {
            CurSession.RemoveProblem(Problems[2]);
            Problems.RemoveAt(2);
            RefreshForm();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AnalyticsFormButton_Click(object sender, EventArgs e)
        {
            ChosenProblemA = comboBox1.SelectedItem.ToString();
            string Filename2 = "data/Matrix_" + Enter_Analyst.ChosenProblemA;
            if (!System.IO.File.Exists(Filename2))
            {
                MessageBox.Show($"Эксперт не выбрал альтернативы для проблемы {Enter_Analyst.ChosenProblemA}");
                //this.Hide();
                //Enter_Analyst backForm = new Enter_Analyst();
                //backForm.Show();
                return;
            }
            else
            {
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
        }

        private void NewProblemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string Filename2 = "data/Matrix_" + comboBox1.SelectedItem.ToString();
                if (!System.IO.File.Exists(Filename2))
                {
                    //comboBox1.BackColor = Color.Red;
                    EditProblemButton.Enabled = true;
                    ChosenProblemA = comboBox1.SelectedItem.ToString();
                    Exit.Focus();
                    return;
                }
                else
                {
                    //comboBox1.BackColor = Color.Green;
                    EditProblemButton.Enabled = false;
                    AnalyticsFormButton.Focus();
                }
            }
            else
            {
                if (comboBox1.SelectedIndex > 0)
                {
                    comboBox1.SelectedIndex--;
                }
                else
                {
                    comboBox1.SelectedIndex++;
                }
            }

        }

        private void EditProblemButton_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.Show();

        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string Filename2 = "data/Matrix_" + comboBox1.SelectedItem.ToString();
                if (!System.IO.File.Exists(Filename2))
                {
                    using (Brush br = new SolidBrush(Color.LightPink))
                    {
                        string text = ((ComboBox)sender).Items[e.Index].ToString();
                        e.Graphics.FillRectangle(br, e.Bounds);
                        e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);
                    }
                }
                else
                {
                    using (Brush br = new SolidBrush(Color.LightGreen))
                    {
                        string text = ((ComboBox)sender).Items[e.Index].ToString();
                        e.Graphics.FillRectangle(br, e.Bounds);
                        e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);
                    }
                }
            }
            //string Filename2 = "data/Matrix_" + comboBox1.SelectedItem.ToString();
            //if (!System.IO.File.Exists(Filename2))
            //{
            //    brush = Brushes.Red;
            //}
            //else
            //    brush = Brushes.Green;
            //e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void EditExpertsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
