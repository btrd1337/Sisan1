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

        Sessions CurrectSession = new Sessions();
        int CurrentProgress = 0;
        int tmp = 0;
        public void initChosen()
        {
            Enter_Expert.ChosenProblem = comboBox1.SelectedItem.ToString();
            //Problem.Text = Enter_Expert.ChosenProblem;
        }
        public Form2()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Location = new System.Drawing.Point(500, 284);
            InitializeComponent();
            for (int i = 0; i < Data.Methods.Count; i++)
            {
                MethodsComboBox.Items.Add(Data.Methods[i]);
            }

            MethodsComboBox.SelectedIndex = 0;
            Data.ProblemsFileName = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Problems.txt";
            CurrectSession.LoadSession();
            bindingSource1.DataSource = CurrectSession.Problems;
            comboBox1.DataSource = bindingSource1.DataSource;
        }

        List<string> Alternatives = new List<string>();
        int alterCount = 0;
        int i = 0, j = 1;
        string[,] Matrix;

        private void AddAlternative(string db) // Добавление альтернативы
        {
            alterCount++;
            Alternatives.Add(db);
        }

        private void DrawNext(int i, int j)
        {
            radioButton1.Text = Alternatives[i].ToString();
            radioButton2.Text = Alternatives[j].ToString();
            if ((i == 0) && (j == 1))
            {
                buttonPrev.Visible = false;
            }
        }

        private void LoadSavedSecondLab()
        {
            var sr2 = new StreamReader("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_SecondLab_" + Enter_Expert.ChosenProblem); // Сканируем файл
                                                   // Удаляем из него все разделители
            var Text = sr2.ReadToEnd().Split(new char[] { ' ', '\t', '\r', '\n', });
            sr2.Close();
            for (int i=0;i<dataGridView2.Rows.Count;i++)
            {
                if (Text[i] != "r")
                    dataGridView2.Rows[i].Cells[1].Value = Text[i];
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Problem.Text = Enter_Expert.ChosenProblem;
            try
            {
                this.Width = 439;
                this.Height = 160;
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
                if (CurrentCheckBoxChecked == tmp)
                {
                    FinishButton.Enabled = true;
                }

                FinishButton.Visible = true;
                button1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        List<List<int>> Array = new List<List<int>>();

        public void button1_Click(object sender, EventArgs e) // Начать тестирование
        {
            int questionCount = 0;
            switch (MethodsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        if (Alternatives.Count > 1)
                        {
                            int k = 0;
                            this.Size = new System.Drawing.Size(1000, 600);
                            this.Width = 1366;
                            this.Height = 500;

                            initProgressBar();
                            comboBox1.Visible = false;
                            buttonPrev.Visible = false;
                            buttonNext.Visible = false;
                            this.Location = new System.Drawing.Point(2, 30);
                            Matrix = new string[Alternatives.Count, Alternatives.Count];
                            for (int n = 0; n < Alternatives.Count; n++)
                            {
                                Matrix[n, n] = "d";
                            }

                            button1.Visible = false;
                            //groupBox1.Visible = true;
                            //buttonNext.Enabled = false;
                            DrawNext(i, j);
                            initProgressBar();
                            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                            //dataGridView1.Columns.AddRange(checkBoxColumn);
                            //dataGridView1.DataSource = Alternatives;
                            //for (int questionCount = 0; questionCount < tmp; questionCount++)
                            //{
                            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);
                            dataGridView1.Visible = true;
                            dataGridView1.Columns[1].ReadOnly = false;
                            List<int> row = new List<int>();
                            for (int i = 0; i < tmp; ++i)
                            {
                                row = new List<int>();
                                Array.Add(row);
                            }

                            for (int i = 0; i < Alternatives.Count; i++)
                            {
                                for (int j = i + 1; j < Alternatives.Count; j++)
                                {
                                    dataGridView1.Rows.Add();
                                    Array[k].Add(i);
                                    Array[k].Add(j);
                                    k++;
                                    dataGridView1.Rows[questionCount].Cells[0].Value = Alternatives[i];
                                    dataGridView1.Rows[questionCount].Cells[1].Value = false;
                                    dataGridView1.Rows[questionCount].Cells[2].Value = false;
                                    dataGridView1.Rows[questionCount].Cells[3].Value = false;
                                    dataGridView1.Rows[questionCount].Cells[4].Value = Alternatives[j];
                                    questionCount++;
                                }
                            }
                            //dataGridView1.Rows.RemoveAt(questionCount);
                            //}

                        }
                        if (File.Exists("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_Matrix_" + Enter_Expert.ChosenProblem))
                        {
                            int tempInt = 0;
                            string Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_Matrix_" + Enter_Expert.ChosenProblem;
                            //if (!File.Exists(Filename2))
                            //{
                            //    MessageBox.Show($"Не существует файла {Enter_Analyst.ChosenProblemA}");
                            //    this.Hide();
                            //    Enter_Analyst backForm = new Enter_Analyst();
                            //    backForm.Show();
                            //    return;
                            //}

                            var sr2 = new StreamReader(Filename2); // Сканируем файл
                                                                   // Удаляем из него все разделители
                            var Text = sr2.ReadToEnd().Split(new char[] { ' ', '\t', '\r', '\n', });
                            for (int s = 0; s < Text.Length; s++)
                            {
                                if (tempInt == alterCount)
                                {
                                    Text[s] = "r";
                                    tempInt = -1;
                                }
                                tempInt++;
                            }

                            var j = 0;
                            var i = 0;
                            int ConvertQuestionNumberFromText = 0;
                            for (var k = 0; k < Text.Length; k++)
                            {
                                // Переход на следующую строку
                                if (i == alterCount)
                                {
                                    j++;
                                    i = 0;
                                }
                                if (i == j && Text[k] != "d") // Проверка на диагональный элемент
                                {
                                    throw new Exception("Матрица в файле имеет посторонние элементы на диагонали \n + Примечение: диагональный элемент в файле должен быть помечен символом d");
                                }

                                else
                                {

                                    {
                                        switch (Text[k])// Добвление значений в матрицу
                                        {
                                            case "1":
                                                if (i > j)
                                                {
                                                    dataGridView1.Rows[ConvertQuestionNumberFromText].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                                                    dataGridView1.Rows[ConvertQuestionNumberFromText].Cells[1].Value = true;
                                                    ConvertQuestionNumberFromText++;
                                                    CurrentCheckBoxChecked++;
                                                }
                                                Matrix[i, j] = "1";
                                                Matrix[j, i] = "0";
                                                i++;
                                                break;
                                            case "0.5":
                                                if (i > j)
                                                {
                                                    dataGridView1.Rows[ConvertQuestionNumberFromText].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                                                    dataGridView1.Rows[ConvertQuestionNumberFromText].Cells[2].Value = true;
                                                    ConvertQuestionNumberFromText++;
                                                    CurrentCheckBoxChecked++;
                                                }
                                                Matrix[i, j] = "0.5";
                                                Matrix[j, i] = "0.5";
                                                i++;
                                                break;
                                            case "0,5":
                                                if (i > j)
                                                {
                                                    dataGridView1.Rows[ConvertQuestionNumberFromText].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                                                    dataGridView1.Rows[ConvertQuestionNumberFromText].Cells[2].Value = true;
                                                    ConvertQuestionNumberFromText++;
                                                    CurrentCheckBoxChecked++;
                                                }
                                                Matrix[i, j] = "0,5";
                                                Matrix[j, i] = "0,5";
                                                i++;
                                                break;
                                            case "0":
                                                if (i > j)
                                                {
                                                    dataGridView1.Rows[ConvertQuestionNumberFromText].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                                                    dataGridView1.Rows[ConvertQuestionNumberFromText].Cells[3].Value = true;
                                                    ConvertQuestionNumberFromText++;
                                                    CurrentCheckBoxChecked++;
                                                }
                                                Matrix[i, j] = "0";
                                                Matrix[j, i] = "1";
                                                i++;
                                                break;
                                            case "d": i++; break;
                                            case "": i++; break;
                                            case "r": break;
                                            default:
                                                throw new Exception("Матрица в файле имеет посторонние элементы");
                                        }
                                    }
                                }
                            }
                            sr2.Close();
                            //for (int i = 0; i < Alternatives.Count; i++)
                            //{
                            //    for (int j=i;j<Alternatives.Count;j++)
                            //    {
                            //        dataGridView1.Rows[tempInt].Cells[]
                            //            tempInt++;
                            //    }

                            //}
                        }
                        break;
                    }
                case 1:
                    {
                        if (Alternatives.Count > 0)
                        {
                            Lab2Label.Visible = true;
                            this.Size = new System.Drawing.Size(1000, 600);
                            this.Width = 900;
                            this.Height = 500;
                            this.Location = new System.Drawing.Point(233, 60);

                            comboBox1.Visible = false;
                            buttonPrev.Visible = false;
                            buttonNext.Visible = false;
                            dataGridView2.Visible = true;
                            FinishButton.Location = new Point(450, 426);
                            FinishButton.Enabled = true;
                            for (int i = 0; i < Alternatives.Count; i++)
                            {
                                dataGridView2.Rows.Add();
                                dataGridView2.Rows[i].Cells[0].Value = Alternatives[i];
                            }
                            LoadSavedSecondLab();
                        }
                        break;
                    }
            }
            MethodsComboBox.Visible = false;

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
            for (int i = 1; i < Alternatives.Count; i++)
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
            if (dataGridView1.Visible)
            {
                string Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_Matrix_" + Enter_Expert.ChosenProblem;
                string output = string.Empty;
                for (int n = 0; n < alterCount; n++)
                {
                    for (int m = 0; m < alterCount; m++)
                    {
                        output += Matrix[n, m] + "\t";
                    }
                    output += "\n";
                }
                File.Delete(Filename);
                File.WriteAllText(Filename, output);
            }
            if (dataGridView2.Visible)
            {
                string Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_SecondLab_" + Enter_Expert.ChosenProblem;
                string output = string.Empty;
                for (int n = 0; n < dataGridView2.Rows.Count; n++)
                {
                    if (dataGridView2.Rows[n].Cells[1].Value == null)
                    {
                        output += "r";
                    }
                    else
                    {
                        output += dataGridView2.Rows[n].Cells[1].Value.ToString();
                    }

                    output += "\n";
                }
                File.Delete(Filename);
                File.WriteAllText(Filename, output);

            }
            Data.ProblemsFileName = "ad.txt";
            Login lgn = new Login();
            this.Hide();
            lgn.Show();

            //Login form = new Login();
            //this.Hide();
            //form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Matrix_" + comboBox1.SelectedItem.ToString();
                if (!System.IO.File.Exists(Filename2))
                {
                    //comboBox1.BackColor = Color.Red;
                    button2.Focus();

                }
                else
                {
                    //comboBox1.BackColor = Color.LightGreen;
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
            Alternatives.Clear();
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
        protected int CurrentCheckBoxChecked = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (e.ColumnIndex)
                {
                    case 1:
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[1].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked++;
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            CurrentCheckBoxChecked--;
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);

                        }

                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked--;
                            //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);

                        }

                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = false;

                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked--;

                        }

                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = false;
                        break;
                    case 2:
                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[1].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked--;
                            //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);

                        }

                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = false;

                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked++;
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            CurrentCheckBoxChecked--;
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);

                        }

                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked--;
                            // dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);

                        }

                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = false;
                        break;
                    case 3:
                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[1].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked--;
                            //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);

                        }

                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = false;

                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked--;
                            //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);

                        }

                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = false;

                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value).Equals(true))
                        {
                            CurrentCheckBoxChecked++;
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            CurrentCheckBoxChecked--;
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);

                        }

                        break;

                    default:
                        break;
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.Equals(true))
                {
                    Matrix[Array[e.RowIndex][0], Array[e.RowIndex][1]] = "1";
                    Matrix[Array[e.RowIndex][1], Array[e.RowIndex][0]] = "0";
                    // Matrix[(e.RowIndex + 1) / Alternatives.Count, e.RowIndex % (Alternatives.Count - 1) + 1] = "1";
                    // Matrix[e.RowIndex % (Alternatives.Count - 1) + 1, (e.RowIndex + 1) / Alternatives.Count] = "0";
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.Equals(true))
                {
                    Matrix[Array[e.RowIndex][0], Array[e.RowIndex][1]] = "0,5";
                    Matrix[Array[e.RowIndex][1], Array[e.RowIndex][0]] = "0,5";
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals(true))
                {
                    Matrix[Array[e.RowIndex][0], Array[e.RowIndex][1]] = "0";
                    Matrix[Array[e.RowIndex][1], Array[e.RowIndex][0]] = "1";
                }
                if (CurrentCheckBoxChecked == tmp)
                {
                    FinishButton.Enabled = true;
                }
                else
                {
                    FinishButton.Enabled = false;
                }
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            switch (MethodsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        string Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Matrix_" + Enter_Expert.ChosenProblem;
                        File.Delete("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_Matrix_" + Enter_Expert.ChosenProblem);
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
                        Data.ProblemsFileName = "ad.txt";
                        Login lgn = new Login();
                        this.Hide();
                        lgn.Show();
                        break;
                    }
                case 1:
                    {
                        double SumScore = 0;
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            if (dataGridView2.Rows[i].Cells[1].Value != null)
                            {
                                SumScore += Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value.ToString().Replace('.', ','));
                            }
                        }

                        if (SumScore != 100)
                        {
                            MessageBox.Show("Сумма оценок альтернатив не равно 100");
                        }
                        else
                        {
                            List<string> tempList = new List<string>();
                            for (int i = 0; i < dataGridView2.Rows.Count; i++)
                            {
                                tempList.Add(Convert.ToString(Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value.ToString().Replace('.', ',')) / 100));
                            }
                            File.WriteAllLines("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/SecondLab_" + Enter_Expert.ChosenProblem, tempList);
                            Login lgn = new Login();
                            this.Hide();
                            lgn.Show();

                        }
                        break;
                    }

            }


        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Matrix_" + comboBox1.SelectedItem.ToString();
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
        }

        private void comboBox1_DrawItem(object sender, EventArgs e)
        {

        }

        private void MethodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
