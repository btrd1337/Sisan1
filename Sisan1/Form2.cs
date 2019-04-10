using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class Form2 : Form
    {
        public static string ChosenProblem;
        public Sessions CurrectSession = new Sessions();
        int CurrentProgress = 0;
        int tmp = 0;
        public void initChosen()
        {
            Enter_Expert.ChosenProblem = comboBox1.SelectedItem.ToString();
            //Problem.Text = Enter_Expert.ChosenProblem;
        }
        public Form2()
        {
            InitializeComponent();
            CurrectSession.LoadSession();
            bindingSource1.DataSource = CurrectSession.Problems;
            comboBox1.DataSource = bindingSource1.DataSource;
        }

        List<string> alterntaivs = new List<string>();
        int alterCount = 0;
        int i = 0, j = 1;
        //int counter = 0;
        string[,] Matrix;

        private void AddAlternative(string db) // Добавление альтернативы
        {
            alterCount++;
            alterntaivs.Add(db);
        }

        private void DrawNext(int i, int j)
        {
            radioButton1.Text = alterntaivs[i].ToString();
            radioButton2.Text = alterntaivs[j].ToString();
            if ((i == 0) && (j == 1))
            {
                buttonPrev.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Problem.Text = Enter_Expert.ChosenProblem;
            try
            {
                this.Width = 260;
                this.Height = 120;
                //if (CurrectSession.Problems.Count > 0)
                //{
                //comboBox1.Items[1].ToString() = Problems[0];
                //Problem1.Visible = true;
                //}
                //Enter_Expert.ChosenProblem = comboBox1.SelectedItem.ToString();
                //Problem.Text = Enter_Expert.ChosenProblem;
                //string Filename = "data/Alternatives_" + Enter_Expert.ChosenProblem;
                //var sr = new StreamReader(Filename); // Сканируем файл
                //var text = new List<string>();

                //string line;
                //while ((line = sr.ReadLine()) != null)
                //{
                //    AddAlternative(line);
                //    counter++;
                //}
                //sr.Close();

                button1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void button1_Click(object sender, EventArgs e) // Начать тестирование
        {

            if (alterntaivs.Count > 1)
            {
                this.Size = new System.Drawing.Size(1000, 600);
                this.Width = 476;
                this.Height = 407;

                initProgressBar();
                comboBox1.Visible = false;
                buttonPrev.Visible = false;
                Matrix = new string[alterntaivs.Count, alterntaivs.Count];
                for (int n = 0; n < alterntaivs.Count; n++)
                {
                    Matrix[n, n] = "d";
                }

                button1.Visible = false;
                groupBox1.Visible = true;
                buttonNext.Enabled = false;
                DrawNext(i, j);
                initProgressBar();
                //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                //dataGridView1.Columns.AddRange(checkBoxColumn);
                //dataGridView1.DataSource = alterntaivs;
                //for (int questionCount = 0; questionCount < tmp; questionCount++)
                //{
                int questionCount = 0;
                int[,] sootv = new int[28, 2];
                dataGridView1.Columns[1].ReadOnly = false;
                for (int i = 0; i < alterntaivs.Count; i++)
                {
                    for (int j = i + 1; j < alterntaivs.Count; j++)
                    {
                        dataGridView1.Rows.Add();
                        sootv[j,0] = i;
                        sootv[j, 1] = j;
                        dataGridView1.Rows[questionCount].Cells[0].Value = alterntaivs[i];
                        dataGridView1.Rows[questionCount].Cells[1].Value = false;
                        dataGridView1.Rows[questionCount].Cells[2].Value = false;
                        dataGridView1.Rows[questionCount].Cells[3].Value = false;
                        dataGridView1.Rows[questionCount].Cells[4].Value = alterntaivs[j];
                        questionCount++;
                    }
                }
                //dataGridView1.Rows.RemoveAt(questionCount);
                //}

            }
            else
            {
                MessageBox.Show("Нет Альтернатив");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = (RadioButton)sender;
            if (radioButton1.Checked)
            {
                Matrix[i, j] = "1";
                Matrix[j, i] = "0";
                buttonNext.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton2 = (RadioButton)sender;
            if (radioButton2.Checked)
            {
                Matrix[i, j] = "0";
                Matrix[j, i] = "1";
                buttonNext.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton3 = (RadioButton)sender;
            if (radioButton3.Checked)
            {
                Matrix[i, j] = "0,5";
                Matrix[j, i] = "0,5";
                buttonNext.Enabled = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            string Filename = "data/Matrix_" + Enter_Expert.ChosenProblem;
            string output = string.Empty;
            for (int n = 0; n < alterCount; n++)
            {
                for (int m = 0; m < alterCount; m++)
                {
                    output += Matrix[n, m] + "\t";
                }
                output += "\n";
            }
            File.WriteAllText(Filename, output);

            Login lgn = new Login();
            this.Hide();
            lgn.Show();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            //progressBar1.Value--;
            CurrentProgress--;
            ProgressLabel.Text = "Пройдено " + CurrentProgress.ToString() + " из " + tmp.ToString() + " вопросов";

            if (j > i + 1)
            {
                j--;
            }
            else
            {
                i--;
                j = alterCount - 1;
            }
            DrawNext(i, j);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            if (Matrix[i, j] == "1")
            {
                radioButton1.Checked = true;
            }

            if (Matrix[i, j] == "0")
            {
                radioButton2.Checked = true;
            }

            if (Matrix[i, j] == "0,5")
            {
                radioButton3.Checked = true;
            }
        }

        private void initProgressBar()
        {
            tmp = 0;
            for (int i = 1; i < alterntaivs.Count; i++)
            {
                tmp += i;
            }
            ProgressLabel.Text = "Пройдено " + CurrentProgress.ToString() + " из " + tmp.ToString() + " вопросов";
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = tmp;
            //progressBar1.Step = 1;
            //progressBar1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string Filename2 = "data/Matrix_" + comboBox1.SelectedItem.ToString();
                if (!System.IO.File.Exists(Filename2))
                {
                    comboBox1.BackColor = Color.Red;
                    button2.Focus();

                }
                else
                {
                    comboBox1.BackColor = Color.Green;
                    button1.Focus();
                    //AnalyticsFormButton.Focus();
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



            Enter_Expert.ChosenProblem = comboBox1.SelectedItem.ToString();
            //Problem.Text = Enter_Expert.ChosenProblem;
            string Filename = "data/Alternatives_" + Enter_Expert.ChosenProblem;
            var sr = new StreamReader(Filename); // Сканируем файл
            var text = new List<string>();
            /////
            //counter = 0;
            alterCount = 0;
            alterntaivs.Clear();
            /////
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                AddAlternative(line);
                //counter++;
            }
            sr.Close();

            button1.Visible = true;
            //

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1: dataGridView1.Rows[e.RowIndex].Cells[1].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[1].Value);  dataGridView1.Rows[e.RowIndex].Cells[2].Value = false; dataGridView1.Rows[e.RowIndex].Cells[3].Value = false; break;
                case 2: dataGridView1.Rows[e.RowIndex].Cells[1].Value = false; dataGridView1.Rows[e.RowIndex].Cells[2].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value);  dataGridView1.Rows[e.RowIndex].Cells[3].Value = false; break;
                case 3: dataGridView1.Rows[e.RowIndex].Cells[1].Value = false; dataGridView1.Rows[e.RowIndex].Cells[2].Value = false; dataGridView1.Rows[e.RowIndex].Cells[3].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value); break;
                default: break;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.Equals(true))
            {
                Matrix[(e.RowIndex + 1) / alterntaivs.Count, e.RowIndex % (alterntaivs.Count - 1) + 1] = "1";
                Matrix[e.RowIndex % (alterntaivs.Count - 1) + 1, (e.RowIndex + 1) / alterntaivs.Count] = "0";
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.Equals(true))
            {
                Matrix[(e.RowIndex + 1) / alterntaivs.Count, e.RowIndex % (alterntaivs.Count - 1)] = "0,5";
                Matrix[e.RowIndex % (alterntaivs.Count - 1), (e.RowIndex + 1) / alterntaivs.Count] = "0,5";
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals(true))
            {
                Matrix[(e.RowIndex + 1) / alterntaivs.Count, e.RowIndex % (alterntaivs.Count - 1) + 1] = "0";
                Matrix[e.RowIndex % (alterntaivs.Count - 1) + 1, (e.RowIndex + 1) / alterntaivs.Count] = "1";
            }

        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            string Filename = "data/Matrix_" + Enter_Expert.ChosenProblem;
            string output = string.Empty;
            for (int n = 0; n < alterCount; n++)
            {
                for (int m = 0; m < alterCount; m++)
                {
                    output += Matrix[n, m] + "\t";
                }
                output += "\n";
            }
            File.WriteAllText(Filename, output);

            Login lgn = new Login();
            this.Hide();
            lgn.Show();

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonPrev.Visible = true;

            //progressBar1.Value++;
            CurrentProgress++;
            ProgressLabel.Text = "Пройдено " + CurrentProgress.ToString() + " из " + tmp.ToString() + " вопросов";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            buttonNext.Enabled = false;
            if (j < alterCount - 1)
            {
                j++;
                DrawNext(i, j);
            }
            else
            {
                if ((i == alterCount - 2) && (j == alterCount - 1))
                {
                    groupBox1.Visible = false;
                    buttonExit.Visible = true; // Сохранение матрицы в файл и выход
                    this.Width = 260;
                    this.Height = 140;

                    label2.Visible = true; // Надпись спасибо что прошли тест
                    comboBox1.Visible = false;
                    progressBar1.Visible = false;
                }
                else
                {
                    i++;
                    j = i + 1;
                    DrawNext(i, j);
                }
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            if (Matrix[i, j] == "1")
            {
                radioButton1.Checked = true;
            }

            if (Matrix[i, j] == "0")
            {
                radioButton2.Checked = true;
            }

            if (Matrix[i, j] == "0,5")
            {
                radioButton3.Checked = true;
            }
        }
    }
}
