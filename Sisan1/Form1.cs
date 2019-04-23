using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Data.AllExpertsCoefForCurrrentProblem = new List<Tuple<string, double>>();
            Data.AllExpertsCoefForCurrrentProblem.Clear();
            UserClicked = 0;
            InitializeComponent();
            InitSecondLabPassedExperts();
        }
        List<Tuple<string, double, List<string>>> ComboBoxExperts;

        List<Pair<float, string>> pairs = new List<Pair<float, string>>();
        List<Tuple<string, double>> SecondLabResultVector = new List<Tuple<string, double>>();//название альтернативы и итоговая оценка
        List<Tuple<string, double, List<double>>> SecondLabExpertsPassed = new List<Tuple<string, double, List<double>>>();
        List<float> results = new List<float>();
        List<string> elements = new List<string>() { "1", "0,5", "0" };
        List<string> Alternatives = new List<string>();

        int alterCount = 0;
        float r = 0;
        double SumForOtnositCoef;

        void InitSecondLabPassedExperts()
        {
            string path = "data/Experts/";
            foreach (string s in Directory.GetDirectories(path))
            {

                if (File.Exists(s + "/SecondLab_" + Enter_Analyst.ChosenProblemA))
                {
                    List<double> tmpDouble = new List<double>();

                    string Filename1 = s + "/SecondLab_" + Enter_Analyst.ChosenProblemA;
                    var sr1 = new StreamReader(Filename1); // Сканируем файл
                    string line;
                    while ((line = sr1.ReadLine()) != null)
                    {
                        tmpDouble.Add(Convert.ToDouble(line));
                    }
                    sr1.Close();

                    SecondLabExpertsPassed.Add(new Tuple<string, double, List<double>>(s.Remove(0, path.Length), Convert.ToDouble(File.ReadAllText(s + "/Coefficient.txt")), tmpDouble));

                }

            }
            Data.ProblemsFileName = "ad.txt";

        }

        private void InitSecondLabResultTable()
        {
            List<double> tempList = new List<double>(SecondLabExpertsPassed[0].Item3.Count);
            for (int i = 0; i < Alternatives.Count ; i++)
            {
                tempList.Add(0);
            }
            for (int i = 0; i < SecondLabExpertsPassed.Count; i++)
            {
                for (int j = 0; j < SecondLabExpertsPassed[i].Item3.Count; j++)
                {
                    tempList[j] += SecondLabExpertsPassed[i].Item3[j]*SecondLabExpertsPassed[i].Item2;
                }
            }
            for (int i = 0; i < Alternatives.Count; i++)
            {
                SecondLabResultVector.Add(Tuple.Create(Alternatives[i], tempList[i]));
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].Cells[0].Value = Alternatives[i];
                dataGridView3.Rows[i].Cells[1].Value = tempList[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e) // Открытие формы
        {
            try
            {
                UserClicked++;
                initProblemsNameFirstLabMethodComboBox();
                Problem.Text = Enter_Analyst.ChosenProblemA;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView2.Columns.Add("inter_results", "Cj");
                //dataGridView2.Columns.GetColumnsWidth()

                // Загрузка альтернатив из файла
                string Filename1 = "data/Alternatives_" + Enter_Analyst.ChosenProblemA;
                var sr1 = new StreamReader(Filename1); // Сканируем файл
                var text = new List<string>();

                int counter = 0;
                string line;
                while ((line = sr1.ReadLine()) != null)
                {
                    AddAlternative(line);
                    counter++;
                }
                sr1.Close();
                CountOtnositCoef();
                InitSecondLabResultTable();
                Tuple<string, double, List<string>> temp = (Tuple<string, double, List<string>>)ExpertNameFirstLabMethodComboBox.SelectedItem;
                // Загрузка значений матрицы из файла
                string Filename2 = "data/Experts/" + temp.Item1 + "/Matrix_" + Enter_Analyst.ChosenProblemA;
                if (!File.Exists(Filename2))
                {
                    MessageBox.Show($"Не существует файла {Enter_Analyst.ChosenProblemA}");
                    this.Hide();
                    Enter_Analyst backForm = new Enter_Analyst();
                    backForm.Show();
                    return;
                }

                var sr2 = new StreamReader(Filename2); // Сканируем файл
                                                       // Удаляем из него все разделители
                var Text = sr2.ReadToEnd().Split(new char[] { ' ', '\t', '\r', '\n', });
                var j = 0;
                var i = 0;

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
                        switch (Text[k])// Добвление значений в матрицу
                        {
                            case "1": dataGridView1[i, j].Value = "1"; i++; break;
                            case "0.5": dataGridView1[i, j].Value = "0,5"; i++; break;
                            case "0,5": dataGridView1[i, j].Value = "0,5"; i++; break;
                            case "0": dataGridView1[i, j].Value = "0"; i++; break;
                            case "d": i++; break;
                            case "": break;
                            default:
                                throw new Exception("Матрица в файле имеет посторонние элементы");
                        }
                    }
                }
                sr2.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            results.Clear();
            pairs.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                pairs.Add(new Pair<float, string>(0, Alternatives[i]));
            }

            PairedComparison(); // Вызов метода парных сравнений

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                pairs[i].Second = (i + 1).ToString() + "." + pairs[i].Second;
            }
            //pairs.Add(new Pair<float, string>(0, (i + 1).ToString() + "." + Alternatives[i]));

            //listBox1.Items.Clear(); // Очищение списка альтернатив
            listBox2.Items.Clear(); // Очищение списка результатов
            for (int i = 0; i < pairs.Count; i++)
            {
                listBox2.Items.Add(pairs[i].Second);
            }

            Results(); // Промежуточные результаты
        }

        private void Reload() // Открытие формы
        {
            try
            {
                // initProblemsNameFirstLabMethodComboBox();
                alterCount = 0;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                Problem.Text = Enter_Analyst.ChosenProblemA;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView2.Columns.Add("inter_results", "Cj");
                //dataGridView2.Columns.GetColumnsWidth()

                // Загрузка альтернатив из файла
                string Filename1 = "data/Alternatives_" + Enter_Analyst.ChosenProblemA;
                var sr1 = new StreamReader(Filename1); // Сканируем файл
                var text = new List<string>();

                int counter = 0;
                string line;
                while ((line = sr1.ReadLine()) != null)
                {
                    AddAlternative(line);
                    counter++;
                }
                sr1.Close();
                Tuple<string, double, List<string>> temp = (Tuple<string, double, List<string>>)ExpertNameFirstLabMethodComboBox.SelectedItem;
                // Загрузка значений матрицы из файла
                string Filename2 = "data/Experts/" + temp.Item1 + "/Matrix_" + Enter_Analyst.ChosenProblemA;
                if (!File.Exists(Filename2))
                {
                    MessageBox.Show($"Не существует файла {Enter_Analyst.ChosenProblemA}");
                    this.Hide();
                    Enter_Analyst backForm = new Enter_Analyst();
                    backForm.Show();
                    return;
                }

                var sr2 = new StreamReader(Filename2); // Сканируем файл
                                                       // Удаляем из него все разделители
                var Text = sr2.ReadToEnd().Split(new char[] { ' ', '\t', '\r', '\n', });
                var j = 0;
                var i = 0;

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
                        switch (Text[k])// Добвление значений в матрицу
                        {
                            case "1": dataGridView1[i, j].Value = "1"; i++; break;
                            case "0.5": dataGridView1[i, j].Value = "0,5"; i++; break;
                            case "0,5": dataGridView1[i, j].Value = "0,5"; i++; break;
                            case "0": dataGridView1[i, j].Value = "0"; i++; break;
                            case "d": i++; break;
                            case "": break;
                            default:
                                throw new Exception("Матрица в файле имеет посторонние элементы");
                        }
                    }
                }
                sr2.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            results.Clear();
            pairs.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                pairs.Add(new Pair<float, string>(0, Alternatives[i]));
            }

            PairedComparison(); // Вызов метода парных сравнений

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                pairs[i].Second = (i + 1).ToString() + "." + pairs[i].Second;
            }
            //pairs.Add(new Pair<float, string>(0, (i + 1).ToString() + "." + Alternatives[i]));

            //listBox1.Items.Clear(); // Очищение списка альтернатив
            listBox2.Items.Clear(); // Очищение списка результатов
            for (int i = 0; i < pairs.Count; i++)
            {
                listBox2.Items.Add(pairs[i].Second);
            }

            Results(); // Промежуточные результаты
        }

        void PairedComparison() // Метод парных сравнений
        {
            if (!Checking_grid())
            {
                MessageBox.Show("Матрица предпочтений задана неверно");
                return;
            }
            r = 0; // Сумма всех оценок
            for (int i = 0; i < dataGridView1.Rows.Count; i++) // Идем по вертикали (по столбцу)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++) // Идем по горизонтали (по строке)
                {
                    if (j != i) // Если элемент не диагональный
                    {
                        // Convert.ToSingle - Преобразует заданное значение в число с плавающей запятой одиночной точности
                        pairs[i].First += Convert.ToSingle(dataGridView1[j, i].Value); // Прибавляем в цену (сумма по строке)
                        r += Convert.ToSingle(dataGridView1[j, i].Value); // Сумма всех оценок
                    }
                }
            }
            for (int i = 0; i < pairs.Count(); i++)
            {
                pairs[i].First = pairs[i].First / r; // Считаем веса альтернатив
            }

            for (int i = 0; i < pairs.Count; i++)
            {
                results.Add(pairs[i].First);  // Промежуточные результаты
            }

            pairs.Sort(CompareClass.Compare); // Сортировка весов альтернатив
        }

        private void button7_Click(object sender, EventArgs e) // Упорядочить список
        {
            results.Clear();
            pairs.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                pairs.Add(new Pair<float, string>(0, Alternatives[i]));
            }

            PairedComparison(); // Вызов метода парных сравнений

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                pairs[i].Second = (i + 1).ToString() + "." + pairs[i].Second;
            }
            //pairs.Add(new Pair<float, string>(0, (i + 1).ToString() + "." + Alternatives[i]));

            //listBox1.Items.Clear(); // Очищение списка альтернатив
            listBox2.Items.Clear(); // Очищение списка результатов
            for (int i = 0; i < pairs.Count; i++)
            {
                listBox2.Items.Add(pairs[i].Second);
            }

            Results(); // Промежуточные результаты
        }

        bool Checking_grid() // Проверка матрицы на корректность данных
        {
            bool isCheck = true;
            for (int i = 0; i < alterCount; i++)
            {
                for (int j = 0; j < alterCount; j++)
                {
                    if (i != j)
                    {
                        if (dataGridView1[i, j].Value.ToString() == "" || dataGridView1[j, i].Value.ToString() == "")
                        {
                            dataGridView1[i, j].Style.BackColor = Color.Yellow;
                            isCheck = false;
                        }
                        else // Матрица имеет посторонние элементы
                            if (i != j && !elements.Contains(dataGridView1[i, j].Value.ToString()))
                        {
                            dataGridView1[i, j].Style.BackColor = Color.Yellow;// Подсвечивание некорректных ячеек
                            isCheck = false;
                        }
                        else
                                // Сумма симмeтричных элементов не равна единицe
                                if (Convert.ToSingle(dataGridView1[i, j].Value) + Convert.ToSingle(dataGridView1[j, i].Value) != 1)
                        {
                            dataGridView1[i, j].Style.BackColor = Color.Yellow; // Подсвечивание некорректных ячеек
                            dataGridView1[j, i].Style.BackColor = Color.Yellow;
                            isCheck = false;
                        }
                    }
                }
            }
            return isCheck;
        }

        void InitSecondLabMatrixes()
        {
            for (int i = 0; i < ComboBoxExperts.Count; i++) //ищем для каждого эксперта
            {

            }
        }

        private void CountOtnositCoef()
        {
            SumForOtnositCoef = 0;
            List<Tuple<string, double, List<double>>> TempListTuple = new List<Tuple<string, double, List<double>>>();
            for (int i = 0; i < SecondLabExpertsPassed.Count; i++)
            {
                SumForOtnositCoef += SecondLabExpertsPassed[i].Item2;
            }
            Tuple<string, double, List<double>> tempTuple;
            for (int i = 0; i < SecondLabExpertsPassed.Count; i++)
            {
                tempTuple = new Tuple<string, double, List<double>>(SecondLabExpertsPassed[i].Item1, SecondLabExpertsPassed[i].Item2 / SumForOtnositCoef, SecondLabExpertsPassed[i].Item3);
                TempListTuple.Add(tempTuple);
            }
            SecondLabExpertsPassed = TempListTuple;

        }

        private void AddAlternative(string db) //Добавление альтернативы
        {
            alterCount++;
            Alternatives.Add(db);
            listBox1.Items.Add(alterCount.ToString() + "." + db);

            var column = new DataGridViewComboBoxColumn();
            column.HeaderText = "Z" + alterCount.ToString();
            column.Name = "Z" + alterCount.ToString();
            column.Items.AddRange(new object[] { "1", "0,5", "0" });
            column.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            column.DisplayStyleForCurrentCellOnly = true;
            dataGridView1.Columns.Add(column);
            dataGridView1.Rows.Add();
            dataGridView1.Rows[alterCount - 1].HeaderCell.Value = "Z" + alterCount.ToString();
            dataGridView1.Columns[alterCount - 1].Width = 30;

            for (int i = 0; i < alterCount; i++)
            {
                if (i != alterCount - 1)
                {
                    dataGridView1[i, alterCount - 1].Value = "0";
                    dataGridView1[alterCount - 1, i].Value = "1";
                }
                else // Диагональный элемент
                {
                    dataGridView1[i, alterCount - 1].ReadOnly = true;
                    dataGridView1[i, alterCount - 1].Style.BackColor = Color.Red;
                }
            }
        }

        void Results() // Результаты
        {
            dataGridView2.Columns.RemoveAt(0);
            dataGridView2.Columns.Add("inter_results", "Cj");
            dataGridView2.Columns[0].Width = 100;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //dataGridView2.Columns[1].Width = 53;

            for (int i = 0; i < alterCount; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = "Z" + (i + 1).ToString();
            }

            var sum = 0.0f;
            if (results.Count > 0)
            {
                for (int i = 0; i < alterCount; i++)
                {
                    sum += results[i];
                    dataGridView2[0, i].Value = results[i].ToString();
                }
            }
            dataGridView2.Rows[alterCount].HeaderCell.Value = "Sum";
            dataGridView2[0, alterCount].Value = sum.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1[e.RowIndex, e.ColumnIndex].Value =
                (1 - Convert.ToSingle(dataGridView1[e.ColumnIndex, e.RowIndex].Value)).ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            this.Hide();
            lgn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            results.Clear();
            pairs.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                pairs.Add(new Pair<float, string>(0, Alternatives[i]));
            }

            PairedComparison(); // Вызов метода парных сравнений

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                pairs[i].Second = (i + 1).ToString() + "." + pairs[i].Second;
            }
            //pairs.Add(new Pair<float, string>(0, (i + 1).ToString() + "." + Alternatives[i]));

            //listBox1.Items.Clear(); // Очищение списка альтернатив
            listBox2.Items.Clear(); // Очищение списка результатов
            for (int i = 0; i < pairs.Count; i++)
            {
                listBox2.Items.Add(pairs[i].Second);
            }

            Results(); // Промежуточные результаты
        }

        private void Problem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExpertNameFirstLabMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserClicked >= 2)
            {
                Reload();
            }
        }

        private void initProblemsNameFirstLabMethodComboBox()
        {
            ComboBoxExperts = new List<Tuple<string, double, List<string>>>();
            Sessions CurrentSession = new Sessions();
            string path = "data/Experts/";
            foreach (string s in Directory.GetDirectories(path))
            {
                if (File.Exists(s + "/Coefficient.txt") && File.Exists(s + "/Problems.txt") && File.Exists(s + "/Matrix_" + Enter_Analyst.ChosenProblemA))
                {
                    double tmpDouble = Convert.ToDouble(File.ReadAllText(s + "/Coefficient.txt"));
                    List<string> tmpProblemsString = new List<string>();
                    Data.ProblemsFileName = "data/Experts/" + s.Remove(0, path.Length) + "/Problems.txt";
                    CurrentSession.LoadSession(); //Здесь проблемы для данного эксперта
                                                  //{
                                                  //    File.ReadLines(s + "/Problems.txt")
                                                  //};

                    Data.AllExpertsCoefForCurrrentProblem.Add(Tuple.Create(s.Remove(0, path.Length), tmpDouble));
                    ComboBoxExperts.Add(Tuple.Create(s.Remove(0, path.Length), tmpDouble, CurrentSession.Problems));
                }

            }
            Data.ProblemsFileName = "ad.txt";

            ExpertNameFirstLabMethodComboBox.DataSource = ComboBoxExperts;
            ExpertNameFirstLabMethodComboBox.DisplayMember = "Item1";
        }

        private ushort UserClicked;

        private void ExpertNameFirstLabMethodComboBox_Click(object sender, EventArgs e)
        {
            UserClicked++;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
