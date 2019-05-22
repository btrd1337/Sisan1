using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class Form2 : Form
    {
        int ScaleSize;
        public static string ChosenProblem;
        public static double SumScore { set; get; }
        Sessions CurrentSession = new Sessions();
        int tmp = 0;
        List<string> ThirdLabTempList = new List<string>();
        public void initChosen()
        {
            Enter_Expert.ChosenProblem = comboBox1.SelectedItem.ToString();
        }
        public Form2()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SumScore = 0;
            this.Location = new System.Drawing.Point(510, 284);
            InitializeComponent();
            for (int i = 0; i < Data.Methods.Count; i++)
            {
                MethodsComboBox.Items.Add(Data.Methods[i]);
            }

            MethodsComboBox.SelectedIndex = 0;
            Data.ProblemsFileName = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Problems.txt";
            CurrentSession.LoadSession();

            for (int i = 0; i < CurrentSession.Problems.Count; i++)
            {
                comboBox1.Items.Add(CurrentSession.Problems[i]);
            }
            comboBox1.SelectedIndex = 0;

            //bindingSource1.DataSource = CurrentSession.Problems;
            //comboBox1.DataSource = bindingSource1.DataSource;
            Data.ProblemsFileName = "ad.txt";
        }

        List<string> Alternatives = new List<string>();
        int alterCount = 0;
        string[,] Matrix;
        string[,] MatrixLab4;

        private void AddAlternative(string db) // Добавление альтернативы
        {
            alterCount++;
            Alternatives.Add(db);
        }


        private void LoadSaved(string MethodName)
        {
            if (File.Exists("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_" + MethodName + "_" + Enter_Expert.ChosenProblem))
            {
                if (MethodsComboBox.SelectedIndex == 1 || MethodsComboBox.SelectedIndex == 2 || MethodsComboBox.SelectedIndex == 3)
                {
                    var sr2 = new StreamReader("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_" + MethodName + "_" + Enter_Expert.ChosenProblem); // Сканируем файл
                                                                                                                                                            // Удаляем из него все разделители
                    var Text = sr2.ReadToEnd().Split(new char[] { ' ', '\t', '\r', '\n', });
                    sr2.Close();
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (Text[i] != "r")
                        {
                            dataGridView2.Rows[i].Cells[1].Value = Text[i];
                        }
                    }
                }
                else
                    if (MethodsComboBox.SelectedIndex == 0)
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

                }
                else if (MethodsComboBox.SelectedIndex == 4)
                {
                    int tempInt = 0;
                    string Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_FourthLab_" + Enter_Expert.ChosenProblem;

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
                                    case "d": i++; break;
                                    case "": i++; break;
                                    case "r": break;
                                    default:
                                        {
                                            if (i > j)
                                            {
                                                if (Convert.ToInt32(Text[k]) < 0 || Convert.ToInt32(Text[k]) > ScaleSize)
                                                {
                                                    dataGridViewLab4.Rows[ConvertQuestionNumberFromText].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);
                                                    CurrentCheckBoxChecked--;
                                                }
                                                dataGridViewLab4.Rows[ConvertQuestionNumberFromText].Cells[1].Value = Text[k];
                                                dataGridViewLab4.Rows[ConvertQuestionNumberFromText].Cells[2].Value = (ScaleSize - Convert.ToInt32(Text[k])).ToString();
                                                ConvertQuestionNumberFromText++;
                                                CurrentCheckBoxChecked++;
                                            }
                                            MatrixLab4[j, i] = Text[k];
                                            MatrixLab4[i, j] = (ScaleSize - Convert.ToInt32(Text[k])).ToString();
                                            i++;
                                            break;
                                        };
                                }
                            }
                        }
                    }
                    sr2.Close();
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                this.Width = 450;
                this.Height = 180;
                if (CurrentCheckBoxChecked == tmp)
                {
                    FinishButton.Enabled = true;
                }

                //FinishButton.Visible = true;
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
            FinishButton.Visible = true;
            this.Text = Enter_Expert.ChosenProblem;
            ProblemNameLabel.Text = Enter_Expert.ChosenProblem;
            ProblemNameLabel.Visible = true;
            helpbutton.Visible = false;
            switch (MethodsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        if (Alternatives.Count > 1)
                        {
                            Lab2Label.Text = "Выберите наиболее предпочтительную альтерантиву";
                            Lab2Label.Visible = true;
                            tmp = 0;
                            for (int i = 1; i < Alternatives.Count; i++)
                            {
                                tmp += i;
                            }
                            int k = 0;
                            this.Size = new System.Drawing.Size(1000, 630);
                            this.Width = 1366;
                            this.Height = 520;

                            comboBox1.Visible = false;
                            this.Location = new System.Drawing.Point(2, 30);
                            Matrix = new string[Alternatives.Count, Alternatives.Count];
                            for (int n = 0; n < Alternatives.Count; n++)
                            {
                                Matrix[n, n] = "d";
                            }
                            button1.Visible = false;
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
                        LoadSaved("Matrix");
                        break;
                    }
                case 1:
                    {
                        if (Alternatives.Count > 0)
                        {
                            CountWeightLabel.Visible = true;
                            Lab2Label.Text = "Распределите 100 баллов между альтерантивами";
                            Lab2Label.Visible = true;
                            this.Size = new System.Drawing.Size(1000, 630);
                            this.Width = 905;
                            this.Height = 520;
                            this.Location = new System.Drawing.Point(233, 60);

                            comboBox1.Visible = false;
                            dataGridView2.Visible = true;
                            FinishButton.Location = new Point(448, 450);
                            FinishButton.Enabled = true;
                            for (int i = 0; i < Alternatives.Count; i++)
                            {
                                dataGridView2.Rows.Add();
                                dataGridView2.Rows[i].Cells[0].Value = Alternatives[i];
                            }
                            LoadSaved("SecondLab");
                        }
                        break;
                    }
                case 2: //Третья лаба первый метод
                    {
                        if (Alternatives.Count > 0)
                        {
                            Lab2Label.Visible = true;
                            Lab2Label.Text = "Пронумеруйте от 1.." + Alternatives.Count + ", начиная с более предпочтительного";
                            this.Size = new System.Drawing.Size(1000, 630);
                            this.Width = 905;
                            this.Height = 520;
                            this.Location = new System.Drawing.Point(233, 60);

                            comboBox1.Visible = false;
                            dataGridView2.Visible = true;
                            FinishButton.Location = new Point(448, 450);
                            FinishButton.Enabled = true;
                            ((DataGridViewTextBoxColumn)dataGridView2.Columns["AlternativeScore"]).MaxInputLength = 2;
                            for (int i = 0; i < Alternatives.Count; i++)
                            {
                                dataGridView2.Rows.Add();
                                dataGridView2.Rows[i].Cells[0].Value = Alternatives[i];

                            }
                            LoadSaved("ThirdLabFirstMethod");
                        }

                        break;
                    }
                case 3:
                    {
                        if (Alternatives.Count > 0)
                        {
                            Lab2Label.Visible = true;
                            Lab2Label.Text = "Введите вес альтернатив (от 0 до 10)";
                            this.Size = new System.Drawing.Size(1000, 630);
                            this.Width = 905;
                            this.Height = 520;
                            this.Location = new System.Drawing.Point(233, 60);

                            comboBox1.Visible = false;
                            dataGridView2.Visible = true;
                            FinishButton.Location = new Point(448, 450);
                            FinishButton.Enabled = true;
                            for (int i = 0; i < Alternatives.Count; i++)
                            {
                                dataGridView2.Rows.Add();
                                dataGridView2.Rows[i].Cells[0].Value = Alternatives[i];

                            }
                            LoadSaved("RankMethod");
                        }
                        break;
                    }
                case 4:
                    {
                        if (Alternatives.Count > 0)
                        {
                            int k = 0;
                            dataGridViewLab4.Visible = true;
                            Lab2Label.Visible = true;
                            ScaleSize = Convert.ToInt32(File.ReadAllText("data/ScaleSize_" + Enter_Expert.ChosenProblem));
                            Lab2Label.Text = "Распределите шкалу между двумя альтернативами, в зависимости от предпочтений";
                            CountWeightLabel.Location = new System.Drawing.Point(1158, 14);
                            //CountWeightLabel.Font.Size = 10;
                            CountWeightLabel.Visible = true;
                            CountWeightLabel.Text = "Размерность шкалы " + ScaleSize;
                            this.Size = new System.Drawing.Size(1000, 630);
                            this.Width = 1366;
                            this.Height = 520;
                            this.Location = new System.Drawing.Point(2, 30);
                            MatrixLab4 = new string[Alternatives.Count, Alternatives.Count];
                            for (int n = 0; n < Alternatives.Count; n++)
                            {
                                MatrixLab4[n, n] = "d";
                            }

                            for (int i = 1; i < Alternatives.Count; i++)
                            {
                                tmp += i;
                            }

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
                                    Array[k].Add(i);
                                    Array[k].Add(j);
                                    k++;
                                    dataGridViewLab4.Rows.Add();
                                    dataGridViewLab4.Rows[questionCount].Cells[0].Value = Alternatives[i];
                                    dataGridViewLab4.Rows[questionCount].Cells[3].Value = Alternatives[j];
                                    questionCount++;
                                }
                            }


                            comboBox1.Visible = false;
                            FinishButton.Enabled = false;

                            LoadSaved("FourthLab");
                        }
                        break;
                    }
            }
            button1.Visible = false;
            MethodsComboBox.Visible = false;

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

            Form2 lgn = new Form2();
            this.Hide();
            lgn.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveSessionInFile();
            Data.ProblemsFileName = "ad.txt";
            if (FinishButton.Visible == true)
            {
                Form2 lgn = new Form2();
                this.Hide();
                lgn.Show();

            }
            else
            {
                Login lgn = new Login();
                this.Hide();
                lgn.Show();

            }

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
                        //File.Delete("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_Matrix_" + Enter_Expert.ChosenProblem);
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
                        File.WriteAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_Matrix_" + Enter_Expert.ChosenProblem, output);
                        Data.ProblemsFileName = "ad.txt";
                        Form2 lgn = new Form2();
                        this.Hide();
                        lgn.Show();
                        break;
                    }
                case 1:
                    {
                        if ((SumScore < 100.0 - Math.Pow(10, -5)) || (SumScore > 100.0 + Math.Pow(10, -5)))
                        {
                            MessageBox.Show("Сумма оценок альтернатив не равно 100");
                        }
                        else
                        {
                            bool flag = false;
                            string Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/SecondLab_" + Enter_Expert.ChosenProblem;
                            string output = string.Empty;
                            for (int n = 0; n < dataGridView2.Rows.Count; n++)
                            {
                                if (dataGridView2.Rows[n].Cells[1].Value == null)
                                {
                                    if (!flag)
                                    {
                                        MessageBox.Show("Неверно заполнено");
                                    }

                                    flag = true;

                                }
                                else
                                {
                                    output += dataGridView2.Rows[n].Cells[1].Value.ToString().Replace('.', ',');
                                }

                                output += "\n";
                            }
                            if (!flag)
                            {
                                File.Delete(Filename);
                                File.WriteAllText(Filename, output);
                                File.WriteAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_SecondLab_" + Enter_Expert.ChosenProblem, output);
                                Form2 lgn = new Form2();
                                this.Hide();
                                lgn.Show();
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        bool flag = false;
                        string Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/ThirdLabFirstMethod_" + Enter_Expert.ChosenProblem;
                        string output = string.Empty;
                        for (int n = 0; n < dataGridView2.Rows.Count; n++)
                        {
                            if (dataGridView2.Rows[n].Cells[1].Value == null)
                            {
                                if (!flag)
                                {
                                    MessageBox.Show("Неверно заполнено");
                                }

                                flag = true;

                            }
                            else
                            {
                                output += dataGridView2.Rows[n].Cells[1].Value.ToString();
                            }

                            output += "\n";
                        }
                        if (!flag)
                        {
                            File.Delete(Filename);
                            File.WriteAllText(Filename, output);
                            File.WriteAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_ThirdLabFirstMethod_" + Enter_Expert.ChosenProblem, output);
                            Form2 lgn = new Form2();
                            this.Hide();
                            lgn.Show();
                        }
                        break;
                    }
                case 3:
                    {
                        bool flag = false;
                        string Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/RankMethod_" + Enter_Expert.ChosenProblem;
                        string output = string.Empty;
                        for (int n = 0; n < dataGridView2.Rows.Count; n++)
                        {
                            if (dataGridView2.Rows[n].Cells[1].Value == null)
                            {
                                if (!flag)
                                {
                                    MessageBox.Show("Неверно заполнено");
                                }

                                flag = true;
                            }
                            else
                            {
                                output += dataGridView2.Rows[n].Cells[1].Value.ToString().Replace('.', ',');
                            }

                            output += "\n";
                        }
                        if (!flag)
                        {
                            File.Delete(Filename);
                            File.WriteAllText(Filename, output);
                            File.WriteAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_RankMethod_" + Enter_Expert.ChosenProblem, output);

                            Form2 lgn = new Form2();
                            this.Hide();
                            lgn.Show();
                        }
                        break;
                    }
                case 4:
                    {
                        bool flag = false;
                        string Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/FourthLab_" + Enter_Expert.ChosenProblem;
                        //File.Delete("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_Matrix_" + Enter_Expert.ChosenProblem);
                        string output = string.Empty;
                        //здесь надо забить MatrixLab4 (шо же я натворил)
                        for (int i = 0; i < dataGridViewLab4.Rows.Count; i++)
                        {
                            if (dataGridViewLab4.Rows[i].Cells[1].Value != null && dataGridViewLab4.Rows[i].Cells[2].Value != null)
                            {
                                MatrixLab4[Array[i][0], Array[i][1]] = dataGridViewLab4.Rows[i].Cells[1].Value.ToString();
                                MatrixLab4[Array[i][1], Array[i][0]] = dataGridViewLab4.Rows[i].Cells[2].Value.ToString();
                            }
                            else
                            {
                                if (!flag)
                                {
                                    MessageBox.Show("Неверно заполнено");
                                }

                                flag = true;

                            }

                        }
                        if (!flag)
                        {
                            for (int n = 0; n < alterCount; n++)
                            {
                                for (int m = 0; m < alterCount; m++)
                                {
                                    output += MatrixLab4[n, m] + "\t";
                                }
                                output += "\n";
                            }
                            File.WriteAllText(Filename, output);
                            File.WriteAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_FourthLab_" + Enter_Expert.ChosenProblem, output);
                            Data.ProblemsFileName = "ad.txt";
                            Form2 lgn = new Form2();
                            this.Hide();
                            lgn.Show();

                        }
                        break;

                    }

            }


        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (comboBox1.SelectedItem != null)
            {
                string[] Filename2 = new string[]
                    {
                        "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Matrix_" + comboBox1.SelectedItem.ToString(),
                        "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/SecondLab_" + comboBox1.SelectedItem.ToString(),
                        "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/ThirdLabFirstMethod_" + comboBox1.SelectedItem.ToString(),
                        "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/RankMethod_" + comboBox1.SelectedItem.ToString(),
                        "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/FourthLab_" + comboBox1.SelectedItem.ToString()
                    };
                int tmpNotAnswered = 0;
                for (int i = 0; i < Data.Methods.Count; i++)
                {
                    if (!System.IO.File.Exists(Filename2[i]))
                    {
                        using (Brush br = new SolidBrush(Color.LightPink))
                        {
                            string text = ((ComboBox)sender).Items[e.Index].ToString();
                            e.Graphics.FillRectangle(br, e.Bounds);
                            e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);
                            tmpNotAnswered++;
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
                if (tmpNotAnswered > 0 && tmpNotAnswered != Data.Methods.Count)
                {
                    using (Brush br = new SolidBrush(Color.FromArgb(255, 255, 153)))
                    {
                        string text = ((ComboBox)sender).Items[e.Index].ToString();
                        e.Graphics.FillRectangle(br, e.Bounds);
                        e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);
                    }
                }

            }

        }


        private void MethodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("");
            comboBox1.Invalidate();
            //comboBox1.Items.RemoveAt(comboBox1.Items.Count-1);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveSessionInFile()
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
            else
            if (dataGridView2.Visible)
            {
                string Filename = "someString";
                switch (MethodsComboBox.SelectedIndex)
                {
                    case 1:
                        {
                            Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_SecondLab_" + Enter_Expert.ChosenProblem;
                            break;
                        }
                    case 2:
                        {
                            Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_ThirdLabFirstMethod_" + Enter_Expert.ChosenProblem;
                            break;
                        }
                    case 3:
                        {
                            Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_RankMethod_" + Enter_Expert.ChosenProblem;
                            break;

                        }

                }
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
            else
                if (dataGridViewLab4.Visible)
            {
                for (int i = 0; i < dataGridViewLab4.Rows.Count; i++)
                {
                    if (dataGridViewLab4.Rows[i].Cells[1].Value != null && dataGridViewLab4.Rows[i].Cells[2].Value != null)
                    {
                        MatrixLab4[Array[i][0], Array[i][1]] = dataGridViewLab4.Rows[i].Cells[1].Value.ToString();
                        MatrixLab4[Array[i][1], Array[i][0]] = dataGridViewLab4.Rows[i].Cells[2].Value.ToString();
                    }
                    else
                    {
                        MatrixLab4[Array[i][0], Array[i][1]] = "";
                        MatrixLab4[Array[i][1], Array[i][0]] = "";

                    }
                }

                string Filename = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Temp_FourthLab_" + Enter_Expert.ChosenProblem;
                string output = string.Empty;
                for (int n = 0; n < alterCount; n++)
                {
                    for (int m = 0; m < alterCount; m++)
                    {
                        output += MatrixLab4[n, m] + "\t";
                    }
                    output += "\n";
                }
                File.Delete(Filename);
                File.WriteAllText(Filename, output);

            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSessionInFile();
            Application.Exit();

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (MethodsComboBox.SelectedIndex)
            {
                case 1: //взвешенных
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
                        {
                            e.Handled = true;
                        }
                        break;
                    }
                case 2://предпочтений
                    {

                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                        break;
                    }
                case 3://ранга
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
                        {
                            e.Handled = true;
                        }
                        break;
                    }
                case 4://полного попарного сопастовления
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                        break;
                    }

            }
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView2.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void MethodsComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (comboBox1.SelectedItem != null)
            {
                string Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Matrix_" + comboBox1.SelectedItem.ToString();
                switch (MethodsComboBox.SelectedIndex)
                {
                    case 0: { Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Matrix_" + comboBox1.SelectedItem.ToString(); break; }
                    case 1: { Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/SecondLab_" + comboBox1.SelectedItem.ToString(); break; }
                    case 2: { Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/ThirdLabFirstMethod_" + comboBox1.SelectedItem.ToString(); break; }
                    case 3: { Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/RankMethod_" + comboBox1.SelectedItem.ToString(); break; }
                    case 4: { Filename2 = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/FourthLab_" + comboBox1.SelectedItem.ToString(); break; }

                }
                if (!System.IO.File.Exists(Filename2))
                {
                    using (Brush br = new SolidBrush(Color.LightPink))
                    {

                        e.Graphics.FillRectangle(br, e.Bounds);
                        e.Graphics.DrawString(((ComboBox)sender).Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
                    }
                }
                else
                {
                    using (Brush br = new SolidBrush(Color.LightGreen))
                    {
                        e.Graphics.FillRectangle(br, e.Bounds);
                        e.Graphics.DrawString(((ComboBox)sender).Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
        }

        private void MethodsComboBox_MouseHover(object sender, EventArgs e)
        {

        }
        int m = 0;
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            switch (MethodsComboBox.SelectedIndex)
            {
                case 1: //парных сравнений
                    {
                        if (e.ColumnIndex == 1 && e.RowIndex > -1 && (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "" /*&& !string.IsNullOrWhiteSpace(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())*/))
                        {
                            SumScore = 0;
                            for (int i = 0; i < dataGridView2.Rows.Count; i++)
                            {
                                if ((dataGridView2.Rows[i].Cells[e.ColumnIndex].Value != null && dataGridView2.Rows[i].Cells[e.ColumnIndex].Value.ToString() != "" && !string.IsNullOrWhiteSpace(dataGridView2.Rows[i].Cells[e.ColumnIndex].Value.ToString())))
                                {
                                    SumScore += Convert.ToDouble(dataGridView2.Rows[i].Cells[e.ColumnIndex].Value.ToString().Replace('.', ','));
                                }
                            }
                            CountWeightLabel.Text = "Общий вес = " + Convert.ToString(SumScore) + " из 100";
                        }

                        break;
                    }
                case 2: //первый метод 3 лабы
                    {
                        bool flag = false;
                        if (e.ColumnIndex == 1 && e.RowIndex > -1)
                        {
                            for (int i = 0; i < ColorRedRows.Count && !flag; i++)
                            {
                                for (int j = 0; !flag && j< ColorRedRows[i].Item1.Count; j++)
                                {
                                    if (ColorRedRows[i].Item1[j] == e.RowIndex /*&& ColorRedRows[i].Item2 == dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString()*/)
                                    {
                                        dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = default(Color);
                                        for (int b=0;b< ColorRedRows[i].Item1.Count;b++)
                                            dataGridView2.Rows[ColorRedRows[i].Item1[b]].DefaultCellStyle.BackColor = default(Color);
                                        flag = true;
                                        ColorRedRows[i].Item1.RemoveAt(j);
                                        if (ColorRedRows[i].Item1.Count < 2)
                                            ColorRedRows.RemoveAt(i);

                                    }
                                }
                            }
                            if (flag)
                            {
                                m--;
                            }
                            //if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && Convert.ToByte(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > dataGridView2.Rows.Count || Convert.ToByte(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < 1)
                            //{
                            //    dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);
                            //    CurrentCheckBoxChecked--;
                            //}
                            //else
                            //{
                            //    dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = default(Color);
                            //    CurrentCheckBoxChecked++;
                            //}
                            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                            {
                                if (Convert.ToByte(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > dataGridView2.Rows.Count)
                                {
                                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dataGridView2.Rows.Count;
                                }
                                else
                                {
                                    if (Convert.ToByte(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < 1)
                                        dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                                    else
                                    {
                                        dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = default(Color);
                                    }
                                }
                            }
                        }
                        bool LockFinishButton = false;
                        for (int i = 0; i < dataGridView2.Rows.Count && LockFinishButton == false; i++)
                        {
                            if (Convert.ToByte(dataGridView2.Rows[i].Cells[1].Value) > dataGridView2.Rows.Count || Convert.ToByte(dataGridView2.Rows[i].Cells[1].Value) == 0)
                            {
                                LockFinishButton = true;
                            }
                        }
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView2.Rows.Count; j++)
                            {
                                if (j != i && dataGridView2.Rows[j].Cells[1].Value != null && dataGridView2.Rows[i].Cells[1].Value != null)
                                {
                                    if (dataGridView2.Rows[i].Cells[1].Value.ToString() == dataGridView2.Rows[j].Cells[1].Value.ToString() && dataGridView2.Rows[i].DefaultCellStyle.BackColor != Color.FromArgb(252, 228, 214))
                                    {
                                        dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);
                                        dataGridView2.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);
                                        ColorRedRows.Add(Tuple.Create(new List<int>(), dataGridView2.Rows[i].Cells[1].Value.ToString()));
                                        ColorRedRows[m].Item1.Add(i);
                                        ColorRedRows[m].Item1.Add(j);
                                        m++;
                                        CurrentCheckBoxChecked--;
                                        LockFinishButton = true;
                                    }
                                }
                            }
                        }
                        if (LockFinishButton == true)
                        {
                            FinishButton.Enabled = false;
                        }
                        else
                        {
                            FinishButton.Enabled = true;
                        }

                        break;
                    }
                case 3: //метод ранга
                    {
                        //if (e.ColumnIndex == 1 && e.RowIndex > -1)
                        //{
                        //    if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                        //    {
                        //        if (Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', ',')) > 10.0 || Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', ',')) < 0.0)
                        //        {
                        //            //dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);
                        //            CurrentCheckBoxChecked--;
                        //        }
                        //        else
                        //        {
                        //            dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = default(Color);
                        //            CurrentCheckBoxChecked++;
                        //        }
                        //    }
                        //}
                        bool LockFinishButton = false;
                        for (int i = 0; i < dataGridView2.Rows.Count && LockFinishButton == false; i++)
                        {
                            if (dataGridView2.Rows[i].Cells[1].Value != null)
                            {
                                if (Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value.ToString().Replace('.', ',')) > 10.0 )
                                {
                                    dataGridView2[1, i].Value = 10.0;
                                }
                                else
                                {
                                    if (Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value.ToString().Replace('.', ',')) < 0.0)
                                        dataGridView2[1, i].Value = 0.0;
                                }
                            }
                        }
                        if (LockFinishButton == true)
                        {
                            FinishButton.Enabled = false;
                        }
                        else
                        {
                            FinishButton.Enabled = true;
                        }

                        break;
                    }
            }
        }

        private void dataGridViewLab4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && e.RowIndex > -1)
            {
                if (dataGridViewLab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (Convert.ToInt32(dataGridViewLab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) > ScaleSize)
                    {
                        dataGridViewLab4[e.ColumnIndex, e.RowIndex].Value = ScaleSize;
                    }
                    else
                    {
                        if (Convert.ToInt32(dataGridViewLab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) < 0)
                        {
                            dataGridViewLab4[e.ColumnIndex, e.RowIndex].Value = 0;
                        }
                    }
                    dataGridViewLab4.Rows[e.RowIndex].Cells[(e.ColumnIndex % 2) + 1].Value = ScaleSize - Convert.ToInt32(dataGridViewLab4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
            }
            bool LockFinishButton = false;
            if (LockFinishButton == true)
            {
                FinishButton.Enabled = false;
            }
            else
            {
                FinishButton.Enabled = true;
            }

        }

        List<Tuple<List<int>, string>> ColorRedRows = new List<Tuple<List<int>, string>>(); //номер колонки и значение в ней

        private void dataGridViewLab4_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridViewLab4.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }

        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Зеленым цветом обозначена та проблема, на которую вы дали оценку всеми методами\nЖелтым цветом обозначена та пробелма, на которую вы дали оценку хотя бы одним методом\nКрасным цветом обозначена та проблема, на которую вы не дали свою экспертную оценку");
        }
    }
}
