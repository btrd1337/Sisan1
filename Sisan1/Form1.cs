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
            ScaleSize = Convert.ToInt32(File.ReadAllText("data/ScaleSize_" + Enter_Analyst.ChosenProblemA));
            InitPassedExperts("SecondLab");
            InitPassedExperts("ThirdLabFirstMethod");
            InitPassedExperts("RankMethod");
            initExpertsPassedLab4();

        }
        List<Tuple<string, List<double>, List<string>>> ComboBoxExperts;

        List<Pair<float, string>> pairs = new List<Pair<float, string>>();
        List<Tuple<string, double>> SecondLabResultVector = new List<Tuple<string, double>>();//название альтернативы и итоговая оценка
        List<Tuple<string, double, List<double>>> SecondLabExpertsPassed = new List<Tuple<string, double, List<double>>>();
        List<Tuple<string, double>> ThirdLabFirstMethodResultVector = new List<Tuple<string, double>>();//название альтернативы и итоговая оценка
        List<Tuple<string, List<int>>> ThirdLabFirstMethodExpertsPassed = new List<Tuple<string, List<int>>>();
        List<Tuple<string, List<int>>> ModifiedThirdLabFirstMethodMatrix;
        List<Tuple<string, double>> RankMethodResultVector = new List<Tuple<string, double>>();//название альтернативы и итоговая оценка
        List<Tuple<string, List<double>>> RankMethodExpertsPassed = new List<Tuple<string, List<double>>>();
        List<Tuple<string, string[,]>> Lab4MethodExpertsPassed = new List<Tuple<string, string[,]>>();
        List<Tuple<string, double>> Lab4ResultVector = new List<Tuple<string, double>>();
        List<int> ThirdLabFirstMethodSum = new List<int>();

        string[,] MatrixLab4;



        List<float> results = new List<float>();
        List<string> elements = new List<string>() { "1", "0,5", "0" };
        List<string> Alternatives = new List<string>();

        int ScaleSize;
        int alterCount = 0;
        float r = 0;
        double SumForOtnositCoef;
        int AllProblemsCountForCurrentProblem = 0;

        void InitExpertCountForCurrentProblem()
        {
            string path = "data/Experts/";
            foreach (string s in Directory.GetDirectories(path))
            {
                Data.ProblemsFileName = "data/Experts/" + s.Remove(0, path.Length) + "/Problems.txt";
                Sessions CurrentSession = new Sessions();
                CurrentSession.LoadSession();
                for (int i = 0; i < CurrentSession.Problems.Count; i++)
                {
                    if (CurrentSession.Problems[i] == Enter_Analyst.ChosenProblemA)
                    {
                        AllProblemsCountForCurrentProblem++;
                    }
                }

            }
            Data.ProblemsFileName = "ad.txt";

        }

        void InitLab4ResultTable()
        {
            List<double> SumOfSums = new List<double>();
            List<List<int>> SumOfRow = new List<List<int>>();
            List<double> tmp = new List<double>();
            List<List<double>> NormSumOfRows = new List<List<double>>();
            for (UInt16 ex = 0; ex < Lab4MethodExpertsPassed.Count; ex++)
            {
                NormSumOfRows.Add(new List<double>());
                SumOfRow.Add(new List<int>());
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    tmp.Add(0.0);
                    SumOfRow[ex].Add(0);
                    NormSumOfRows[ex].Add(0.0);

                }
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    for (int j = 0; j < Alternatives.Count; j++)
                    {
                        if (Lab4MethodExpertsPassed[ex].Item2[i, j] != "d")
                        {
                            SumOfRow[ex][i] += Convert.ToInt32(Lab4MethodExpertsPassed[ex].Item2[i, j]);
                        }
                    }
                }
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    NormSumOfRows[ex][i] = Convert.ToDouble(SumOfRow[ex][i]) / Convert.ToDouble(Alternatives.Count * (Alternatives.Count - 1) * ScaleSize);
                }

                //for (int i = 0; i < Alternatives.Count; i++)
                //{
                //    tmp.Add(0);
                //}
                //for (int i = 0; i < RankMethodExpertsPassed.Count; i++) //для нормирования
                //{
                //    for (int j = 0; j < Alternatives.Count; j++)
                //    {
                //        SumOfRow[i] += RankMethodExpertsPassed[i].Item2[j];

                //    }
                //}
                //for (int i = 0; i < RankMethodExpertsPassed.Count; i++) //отнормировали
                //{
                //    for (int j = 0; j < Alternatives.Count; j++)
                //    {
                //        RankMethodExpertsPassed[i].Item2[j] /= SumOfRow[i];
                //        tmp[j] += RankMethodExpertsPassed[i].Item2[j];
                //    }
                //}

                //for (int i = 0; i < Alternatives.Count; i++)
                //{
                //    RankMethodResultVector.Add(Tuple.Create(Alternatives[i], tmp[i] / RankMethodExpertsPassed.Count));
                //    dataGridViewRankMethod.Rows.Add();
                //    dataGridViewRankMethod.Rows[i].Cells[1].Value = Convert.ToString(i + 1) + ". " + RankMethodResultVector[i].Item1;
                //    dataGridViewRankMethod.Rows[i].Cells[2].Value = RankMethodResultVector[i].Item2;
                //}
                //dataGridViewRankMethod.Sort(dataGridViewRankMethod.Columns[2], System.ComponentModel.ListSortDirection.Descending);
                //for (int i = 0; i < Alternatives.Count; i++)
                //{
                //    dataGridViewRankMethod.Rows[i].Cells[0].Value = i + 1;
                //}


            }

            for (UInt16 i = 0; i < Alternatives.Count; i++)
            {
                for (int j = 0; j < Lab4MethodExpertsPassed.Count; j++)
                {
                    tmp[i] += NormSumOfRows[j][i];
                }
                Lab4ResultVector.Add(Tuple.Create(Alternatives[i], tmp[i]));
                dataGridViewLab4.Rows.Add();
                dataGridViewLab4.Rows[i].Cells[1].Value = Convert.ToString(i + 1) + ". " + Lab4ResultVector[i].Item1;
                dataGridViewLab4.Rows[i].Cells[2].Value = Lab4ResultVector[i].Item2;
            }
            dataGridViewLab4.Sort(dataGridViewLab4.Columns[2], System.ComponentModel.ListSortDirection.Descending);
            for (int i = 0; i < Alternatives.Count; i++)
            {
                dataGridViewLab4.Rows[i].Cells[0].Value = i + 1;
            }




        }

        void BuildModifiedMatrxThirdLabFirstMethod()
        {
            if (ThirdLabFirstMethodExpertsPassed.Count > 0)
            {
                List<int> tmp = new List<int>(Alternatives.Count);
                int TotalSum = 0;
                ModifiedThirdLabFirstMethodMatrix = ThirdLabFirstMethodExpertsPassed.ToList();
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    tmp.Add(0);
                }
                for (int i = 0; i < ThirdLabFirstMethodExpertsPassed.Count; i++)
                {
                    for (int j = 0; j < Alternatives.Count; j++)
                    {
                        ModifiedThirdLabFirstMethodMatrix[i].Item2[j] = Alternatives.Count - ThirdLabFirstMethodExpertsPassed[i].Item2[j];
                    }

                }

                for (int i = 0; i < ThirdLabFirstMethodExpertsPassed.Count; i++)
                {
                    for (int j = 0; j < Alternatives.Count; j++)
                    {
                        tmp[j] += ModifiedThirdLabFirstMethodMatrix[i].Item2[j];
                        TotalSum += ModifiedThirdLabFirstMethodMatrix[i].Item2[j];
                    }

                }
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    double tmpDouble = (double)(tmp[i]) / (double)(TotalSum);
                    ThirdLabFirstMethodResultVector.Add(Tuple.Create(Alternatives[i], tmpDouble));
                    dataGridViewLab3FirstMethod.Rows.Add();
                    dataGridViewLab3FirstMethod.Rows[i].Cells[1].Value = Convert.ToString(i + 1) + ". " + ThirdLabFirstMethodResultVector[i].Item1;
                    dataGridViewLab3FirstMethod.Rows[i].Cells[2].Value = ThirdLabFirstMethodResultVector[i].Item2;
                }
                dataGridViewLab3FirstMethod.Sort(dataGridViewLab3FirstMethod.Columns[2], System.ComponentModel.ListSortDirection.Descending);
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    dataGridViewLab3FirstMethod.Rows[i].Cells[0].Value = i + 1;
                }

            }
        }

        private void InitRankMethodResultTable()
        {
            if (RankMethodExpertsPassed.Count > 0)
            {
                List<double> tmp = new List<double>(Alternatives.Count);
                List<double> SumOfRow = new List<double>();
                for (int i = 0; i < RankMethodExpertsPassed.Count; i++)
                {
                    SumOfRow.Add(0);
                }

                for (int i = 0; i < Alternatives.Count; i++)
                {
                    tmp.Add(0);
                }
                for (int i = 0; i < RankMethodExpertsPassed.Count; i++) //для нормирования
                {
                    for (int j = 0; j < Alternatives.Count; j++)
                    {
                        SumOfRow[i] += RankMethodExpertsPassed[i].Item2[j];

                    }
                }
                for (int i = 0; i < RankMethodExpertsPassed.Count; i++) //отнормировали
                {
                    for (int j = 0; j < Alternatives.Count; j++)
                    {
                        RankMethodExpertsPassed[i].Item2[j] /= SumOfRow[i];
                        tmp[j] += RankMethodExpertsPassed[i].Item2[j];
                    }
                }

                for (int i = 0; i < Alternatives.Count; i++)
                {
                    RankMethodResultVector.Add(Tuple.Create(Alternatives[i], tmp[i] / RankMethodExpertsPassed.Count));
                    dataGridViewRankMethod.Rows.Add();
                    dataGridViewRankMethod.Rows[i].Cells[1].Value = Convert.ToString(i + 1) + ". " + RankMethodResultVector[i].Item1;
                    dataGridViewRankMethod.Rows[i].Cells[2].Value = RankMethodResultVector[i].Item2;
                }
                dataGridViewRankMethod.Sort(dataGridViewRankMethod.Columns[2], System.ComponentModel.ListSortDirection.Descending);
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    dataGridViewRankMethod.Rows[i].Cells[0].Value = i + 1;
                }

            }
        }

        void InitPassedExperts(string LabName)
        {
            string path = "data/Experts/";
            foreach (string s in Directory.GetDirectories(path))
            {
                if (File.Exists(s + "/" + LabName + "_" + Enter_Analyst.ChosenProblemA))
                {
                    Data.ProblemsFileName = "data/Experts/" + s.Remove(0, path.Length) + "/Problems.txt";
                    List<double> tmpDouble = new List<double>();
                    List<int> tmpInt = new List<int>();
                    Sessions CurrentSession = new Sessions();
                    if (LabName == "SecondLab")
                    {
                        CurrentSession.LoadCoefficients(s + "/Coefficient.txt");
                    }
                    CurrentSession.LoadSession();
                    string Filename1 = s + "/" + LabName + "_" + Enter_Analyst.ChosenProblemA;
                    var sr1 = new StreamReader(Filename1); // Сканируем файл
                    string line;
                    switch (LabName)
                    {
                        case "SecondLab":
                            {
                                while ((line = sr1.ReadLine()) != null)
                                {
                                    tmpDouble.Add(Convert.ToDouble(line));
                                }
                                SecondLabExpertsPassed.Add(new Tuple<string, double, List<double>>(s.Remove(0, path.Length), CurrentSession.CofficientsList[CurrentSession.Problems.IndexOf(Enter_Analyst.ChosenProblemA)], tmpDouble));
                                break;
                            }
                        case "ThirdLabFirstMethod":
                            {
                                while ((line = sr1.ReadLine()) != null)
                                {
                                    tmpInt.Add(Convert.ToInt32(line));
                                }
                                ThirdLabFirstMethodExpertsPassed.Add(new Tuple<string, List<int>>(s.Remove(0, path.Length), tmpInt));
                                break;
                            }
                        case "RankMethod":
                            {
                                while ((line = sr1.ReadLine()) != null)
                                {
                                    tmpDouble.Add(Convert.ToDouble(line));
                                }
                                RankMethodExpertsPassed.Add(new Tuple<string, List<double>>(s.Remove(0, path.Length), tmpDouble));

                                break;
                            }

                    }
                    sr1.Close();


                }

            }
            Data.ProblemsFileName = "ad.txt";

        }

        private void InitSecondLabResultTable()
        {
            if (SecondLabExpertsPassed.Count != 0)
            {
                List<double> tempList = new List<double>(SecondLabExpertsPassed[0].Item3.Count);
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    tempList.Add(0);
                }
                for (int i = 0; i < SecondLabExpertsPassed.Count; i++)
                {
                    for (int j = 0; j < SecondLabExpertsPassed[i].Item3.Count; j++)
                    {
                        tempList[j] += SecondLabExpertsPassed[i].Item3[j] * SecondLabExpertsPassed[i].Item2;
                    }
                }
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    SecondLabResultVector.Add(Tuple.Create(Alternatives[i], tempList[i]));
                    dataGridViewLab2.Rows.Add();
                    dataGridViewLab2.Rows[i].Cells[1].Value = Convert.ToString(i + 1) + ". " + Alternatives[i];
                    dataGridViewLab2.Rows[i].Cells[2].Value = tempList[i];
                }
                dataGridViewLab2.Sort(dataGridViewLab2.Columns[2], System.ComponentModel.ListSortDirection.Descending);
                for (int i = 0; i < Alternatives.Count; i++)
                {
                    dataGridViewLab2.Rows[i].Cells[0].Value = i + 1;
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e) // Открытие формы
        {
            try
            {

                UserClicked++;
                Problem.Text = Enter_Analyst.ChosenProblemA;

                InitExpertCountForCurrentProblem();
                CountOtnositCoef();
                InitSecondLabResultTable();
                //суда третья лаба третью три

                BuildModifiedMatrxThirdLabFirstMethod();

                InitRankMethodResultTable();
                InitLab4ResultTable();
                if (initProblemsNameFirstLabMethodComboBox())
                {
                    dataGridView1.AllowUserToAddRows = false;
                    //dataGridView2.Columns.Add("inter_results", "Cj");
                    //dataGridView2.Columns.GetColumnsWidth()

                    // Загрузка альтернатив из файла
                    Tuple<string, List<double>, List<string>> temp = (Tuple<string, List<double>, List<string>>)ExpertNameFirstLabMethodComboBox.SelectedItem;
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
                    results.Clear();
                    pairs.Clear();
                    for (int p = 0; p < AlternativesDataGridView.Rows.Count; p++)
                    {
                        pairs.Add(new Pair<float, string>(0, Alternatives[p]));
                    }

                    PairedComparison(); // Вызов метода парных сравнений

                    for (int p = 0; p < AlternativesDataGridView.Rows.Count; p++)
                    {
                        pairs[p].Second = (p + 1).ToString() + "." + pairs[p].Second;
                    }

                    ResultsFirstLab();
                }
                FirstLabExpertsPassedCountLabel.Text = "Пройдено " + ExpertNameFirstLabMethodComboBox.Items.Count.ToString() + " из " + AllProblemsCountForCurrentProblem.ToString() + " экспертами";
                SecondLabExpertsPassedCountLabel.Text = "Пройдено " + SecondLabExpertsPassed.Count.ToString() + " из " + AllProblemsCountForCurrentProblem.ToString() + " экспертами";
                ThirdLabFirstMethodExpertsPassedCountLabel.Text = "Пройдено " + ThirdLabFirstMethodExpertsPassed.Count.ToString() + " из " + AllProblemsCountForCurrentProblem.ToString() + " экспертами";
                RankMethodExpertsPassedLabel.Text = "Пройдено " + RankMethodExpertsPassed.Count.ToString() + " из " + AllProblemsCountForCurrentProblem.ToString() + " экспертами";
                FourthLabExpertsPassedCountLabel.Text = "Пройдено " + Lab4MethodExpertsPassed.Count.ToString() + " из " + AllProblemsCountForCurrentProblem.ToString() + " экспертами";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void Reload() // Открытие формы
        {
            try
            {
                // initProblemsNameFirstLabMethodComboBox();
                alterCount = 0;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                AlternativesDataGridView.Rows.Clear();
                //listBox2.Items.Clear();
                //dataGridView2.Rows.Clear();
                //dataGridView2.Columns.Clear();

                dataGridView1.AllowUserToAddRows = false;
                //dataGridView2.Columns.Add("inter_results", "Cj");
                //dataGridView2.Columns.GetColumnsWidth()

                // Загрузка альтернатив из файла
                string Filename1 = "data/Alternatives_" + Enter_Analyst.ChosenProblemA;
                var sr1 = new StreamReader(Filename1); // Сканируем файл
                var text = new List<string>();

                int counter = 0;
                string line;
                Alternatives.Clear();
                while ((line = sr1.ReadLine()) != null)
                {
                    AddAlternative(line);
                    counter++;
                }
                sr1.Close();
                Tuple<string, List<double>, List<string>> temp = (Tuple<string, List<double>, List<string>>)ExpertNameFirstLabMethodComboBox.SelectedItem;
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

            for (int i = 0; i < AlternativesDataGridView.Rows.Count; i++)
            {
                pairs.Add(new Pair<float, string>(0, Alternatives[i]));
            }



            PairedComparison(); // Вызов метода парных сравнений

            for (int i = 0; i < AlternativesDataGridView.Rows.Count; i++)
            {
                pairs[i].Second = (i + 1).ToString() + "." + pairs[i].Second;
            }

            ResultsFirstLab();
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
            AlternativesDataGridView.Rows.Add(alterCount.ToString(), db);

            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
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

        void ResultsFirstLab()
        {
            dataGridViewLab1.Rows.Clear();
            for (int i = 0; i < results.Count; i++)
            {
                dataGridViewLab1.Rows.Add();
                dataGridViewLab1.Rows[i].Cells[1].Value = Convert.ToString(i + 1) + ". " + Alternatives[i];
                dataGridViewLab1.Rows[i].Cells[2].Value = results[i];
            }
            dataGridViewLab1.Sort(dataGridViewLab1.Columns[2], System.ComponentModel.ListSortDirection.Descending);
            for (int i = 0; i < Alternatives.Count; i++)
            {
                dataGridViewLab1.Rows[i].Cells[0].Value = i + 1;
            }

        }



        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1[e.RowIndex, e.ColumnIndex].Value =
                (1 - Convert.ToSingle(dataGridView1[e.ColumnIndex, e.RowIndex].Value)).ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Enter_Analyst lgn = new Enter_Analyst();
            this.Hide();
            lgn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

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

        private bool initProblemsNameFirstLabMethodComboBox()
        {
            int temp = 0;
            ComboBoxExperts = new List<Tuple<string, List<double>, List<string>>>();
            string path = "data/Experts/";
            foreach (string s in Directory.GetDirectories(path))
            {
                if (File.Exists(s + "/Coefficient.txt") && File.Exists(s + "/Problems.txt") && File.Exists(s + "/Matrix_" + Enter_Analyst.ChosenProblemA))
                {
                    Sessions CurrentSession = new Sessions();
                    //double tmpDouble = Convert.ToDouble(File.ReadAllText(s + "/Coefficient.txt"));
                    List<string> tmpProblemsString = new List<string>();
                    Data.ProblemsFileName = "data/Experts/" + s.Remove(0, path.Length) + "/Problems.txt";
                    CurrentSession.LoadSession(); //Здесь проблемы для данного эксперта
                                                  //{
                                                  //    File.ReadLines(s + "/Problems.txt")
                                                  //};
                    CurrentSession.LoadCoefficients(s + "/Coefficient.txt");
                    Data.AllExpertsCoefForCurrrentProblem.Add(Tuple.Create(s.Remove(0, path.Length), CurrentSession.CofficientsList[CurrentSession.Problems.IndexOf(Enter_Analyst.ChosenProblemA)]));
                    ComboBoxExperts.Add(Tuple.Create(s.Remove(0, path.Length), new List<double>(), CurrentSession.Problems));
                    temp++;
                }

            }
            Data.ProblemsFileName = "ad.txt";

            ExpertNameFirstLabMethodComboBox.DataSource = ComboBoxExperts;
            ExpertNameFirstLabMethodComboBox.DisplayMember = "Item1";
            return temp > 0 ? true : false;
        }


        private bool initExpertsPassedLab4()
        {
            int temp = 0;

            MatrixLab4 = null;
            string path = "data/Experts/";
            foreach (string s in Directory.GetDirectories(path))
            {
                if (File.Exists(s + "/Coefficient.txt") && File.Exists(s + "/Problems.txt") && File.Exists(s + "/FourthLab_" + Enter_Analyst.ChosenProblemA))
                {
                    MatrixLab4 = new string[Alternatives.Count, Alternatives.Count];
                    for (int n = 0; n < Alternatives.Count; n++)
                    {
                        MatrixLab4[n, n] = "d";
                    }
                    int tempInt = 0;
                    string Filename2 = s + "/FourthLab_" + Enter_Analyst.ChosenProblemA;

                    var sr2 = new StreamReader(Filename2); // Сканируем файл
                                                           // Удаляем из него все разделители
                    var Text = sr2.ReadToEnd().Split(new char[] { ' ', '\t', '\r', '\n', });
                    for (int v = 0; v < Text.Length; v++)
                    {
                        if (tempInt == alterCount)
                        {
                            Text[v] = "r";
                            tempInt = -1;
                        }
                        tempInt++;
                    }

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
                            {
                                switch (Text[k])// Добвление значений в матрицу
                                {
                                    case "d": i++; break;
                                    case "": i++; break;
                                    case "r": break;
                                    default:
                                        {
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

                    Lab4MethodExpertsPassed.Add(Tuple.Create(s.Remove(0, path.Length), MatrixLab4));
                    temp++;
                }

            }
            Data.ProblemsFileName = "ad.txt";

            return temp > 0 ? true : false;
        }
        private ushort UserClicked;

        private void ExpertNameFirstLabMethodComboBox_Click(object sender, EventArgs e)
        {
            UserClicked++;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewLab3FirstMethod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
