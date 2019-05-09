using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Sisan1 //В этой формочке еще и удалять и редактировать экспертов будет можно (со временем)
{
    public partial class MakeExpert : Form
    {
        private bool SelectedIndexChangedCount;
        public List<Tuple<string, double>> ExpertsList = new List<Tuple<string, double>>();
        private List<string> CurrentExpertProblemsSelected = new List<string>();
        private List<double> CurrentExpertProblemsSelectedCoefficient = new List<double>();

        public MakeExpert()
        {
            InitializeComponent();
            SelectedIndexChangedCount = false;
        }


        private void MakeExpert_Load(object sender, EventArgs e)
        {
            InitExpertsList();
            ProblemsListComboBox.DataSource = Data.AllProblems;
            //ProblemsListComboBox.DisplayMember = "Item1";
            ProblemsListComboBox.SelectedItem = null;
            ProblemsListComboBox.SelectedIndex = -1;
        }

        private void InitExpertsPassedProblem()
        {
            //Tuple<string, List<double>, List<string>> tmpTuple = (Tuple<string, List<double>, List<string>>)ProblemsListComboBox.SelectedItem;
            //string s = "data/Experts/" + tmpTuple.Item1.ToString();
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (File.Exists(s + "/Matrix_" + dataGridView1.Rows[i].Cells[0].Value.ToString()) || File.Exists(s + "/SecondLab_" + dataGridView1.Rows[i].Cells[0].Value.ToString()))
            //    {
            //        dataGridView1.Rows[i].Cells[1].ReadOnly = true;
            //        DeleteExpert.Enabled = false;
            //        //dataGridView1.Rows[i].Cells[2].ReadOnly = true;

            //    }

            //}


            Data.ProblemsFileName = "ad.txt";

        }

        private void AddExpertButton_Click(object sender, EventArgs e)
        {
            if (Data.ExpertsList.Any(m => m.Item1 == ExpertNameTextBox.Text))
            {
                MessageBox.Show("Эксперт с таким именем уже существует");
            }
            else
            {
                if (!String.IsNullOrEmpty(ExpertNameTextBox.Text))
                {
                    Directory.CreateDirectory("data/Experts/" + ExpertNameTextBox.Text);
                    //File.WriteAllText("data/Experts/" + ExpertNameTextBox.Text + "/Coefficient.txt", ExpertCoefficientNumericUpDown.Value.ToString());
                    File.CreateText("data/Experts/" + ExpertNameTextBox.Text + "/Problems.txt").Close();
                    File.WriteAllText("data/Experts/" + ExpertNameTextBox.Text + "/Problems.txt", "0");
                    File.CreateText("data/Experts/" + ExpertNameTextBox.Text + "/Coefficient.txt").Close();
                    File.WriteAllText("data/Experts/" + ExpertNameTextBox.Text + "/Coefficient.txt", "0");
                    Data.ExpertsList.Add(new Tuple<string, List<double>, List<string>>(ExpertNameTextBox.Text, new List<double>(), new List<string>()));
                    Convert.ToString(Enter_Analyst.ChosenProblemA.Length);
                    MessageBox.Show("Эксперт успешно добавлен");
                    MakeExpert Refresh = new MakeExpert();
                    this.Hide();
                    Refresh.Show();
                    //ExpertNameTextBox.Clear();
                    //ExpertCoefficientNumericUpDown.Value = 0;
                }
            }
        }

        private void InitExpertsList()
        {
            //string path = "data/Experts/";
            //foreach (string s in Directory.GetDirectories(path))
            //{
            //    if (File.Exists(s + "/Coefficient.txt"))
            //    {
            //        double tmpDouble = Convert.ToDouble(File.ReadAllText(s + "/Coefficient.txt"));
            //        Data.ExpertsList.Add(Tuple.Create(s.Remove(0, path.Length), tmpDouble));
            //    }
            //    else
            //    {
            //        ExpertsList.Add(Tuple.Create(s.Remove(0, path.Length), 0.322));

            //    }
            //}
            if (!Data.ExpertsNamesInited)
            {
                Data.ExpertsNamesInited = true;
                string path = "data/Experts/";
                foreach (string s in Directory.GetDirectories(path))
                {
                    if (File.Exists(s + "/Coefficient.txt") && File.Exists(s + "/Problems.txt"))
                    {
                        Sessions CurrentSession = new Sessions();
                        List<string> tmpProblemsString = new List<string>();
                        Data.ProblemsFileName = "data/Experts/" + s.Remove(0, path.Length) + "/Problems.txt";
                        CurrentSession.LoadSession();
                        CurrentSession.LoadCoefficients(s + "/Coefficient.txt");
                        Data.ExpertsList.Add(Tuple.Create(s.Remove(0, path.Length), CurrentSession.CofficientsList, CurrentSession.Problems));

                    }

                }
                Data.ProblemsFileName = "ad.txt";

            }

        }

        //private void LoadPreviousCoefficient()
        //{
        //    if (File.Exists("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt"))
        //    {
        //        Data.CurrentCoefficient = Convert.ToDouble(File.ReadAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt"));
        //        EditExpertCoefficientNumericUpDown.Value = (decimal)Data.CurrentCoefficient;
        //    }
        //}

        private void LoadPreviousProblems()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = false;
            }
            for (int i = 0; i < Data.ExpertsList.Count; i++)
            {
                Sessions LoadProblem = new Sessions();
                Data.CurrentExpertTuple = Data.ExpertsList[i];
                Data.ProblemsFileName = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Problems.txt";
                LoadProblem.LoadSession();
                for (int j = 0; j < LoadProblem.Problems.Count; j++)
                {
                    if (LoadProblem.Problems[j] == ProblemsListComboBox.SelectedItem.ToString())
                    {
                        LoadProblem.LoadCoefficients("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt");
                        dataGridView1.Rows[i].Cells[1].Value = true;
                        dataGridView1.Rows[i].Cells[2].ReadOnly = false;
                        dataGridView1.Rows[i].Cells[2].Value = LoadProblem.CofficientsList[j];

                    }
                }

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (File.Exists("data/Experts/" + Data.ExpertsList[i].Item1 + "/Matrix_" + ProblemsListComboBox.SelectedItem.ToString()) || File.Exists("data/Experts/" + Data.ExpertsList[i].Item1 + "/SecondLab_" + ProblemsListComboBox.SelectedItem.ToString()) || File.Exists("data/Experts/" + Data.ExpertsList[i].Item1 + "/ThirdLabFirstMethod_" + ProblemsListComboBox.SelectedItem.ToString()) || File.Exists("data/Experts/" + Data.ExpertsList[i].Item1 + "/RankMethod_" + ProblemsListComboBox.SelectedItem.ToString()))
                {
                    dataGridView1.Rows[i].Cells[1].ReadOnly = true;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            Data.ProblemsFileName = "ad.txt";



        }

        private void ExpertNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitDataGrid()
        {
            // dataGridView1.Rows.Add();
            dataGridView1.Columns[1].ReadOnly = false;
            //Tuple<string, double, List<string>> tempSelectedItem = (Tuple<string, double, List<string>>)ExpertListComboBox.SelectedItem;
            for (int i = 0; i < Data.ExpertsList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Data.ExpertsList[i].Item1;
                dataGridView1.Rows[i].Cells[2].ReadOnly = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Enter_Analyst form = new Enter_Analyst();
            this.Hide();
            form.Show();
        }

        private void ExpertCoefficientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpertListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DeleteExpert.Enabled = true;
                if (ProblemsListComboBox.SelectedIndex > -1 && SelectedIndexChangedCount)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    EditExpertGroupBox.Visible = true;
                    //EditExpertCoefficientNumericUpDown.Value = 0;
                    InitDataGrid();
                    LoadPreviousProblems();
                    //LoadPreviousCoefficient();
                    InitExpertsPassedProblem();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExpertListComboBox_Click(object sender, EventArgs e)
        {
            SelectedIndexChangedCount = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly == false)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dataGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = null;
            }
        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[1].Value == true)
                {
                    if (Data.ExpertsList[i].Item3.Contains(ProblemsListComboBox.SelectedItem.ToString()))
                    {

                        int tmp = Data.ExpertsList[i].Item3.IndexOf(ProblemsListComboBox.SelectedItem.ToString());
                        Data.ExpertsList[i].Item2[tmp] = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                        File.CreateText("data/Experts/" + Data.ExpertsList[i].Item1 + "/Coefficient.txt").Close(); //чистим
                        List<string> tmpList = new List<string>();
                        tmpList = (List<string>)Data.ExpertsList[i].Item2.ConvertAll<string>(x => x.ToString());
                        tmpList.Insert(0, Data.ExpertsList[i].Item2.Count.ToString());
                        File.WriteAllLines("data/Experts/" + Data.ExpertsList[i].Item1 + "/Coefficient.txt", tmpList);

                    }
                    else
                    {
                        Data.ExpertsList[i].Item3.Add(ProblemsListComboBox.SelectedItem.ToString());
                        if (dataGridView1.Rows[i].Cells[2] == null)
                        {
                            Data.ExpertsList[i].Item2.Add(0);
                        }
                        else
                        {
                            Data.ExpertsList[i].Item2.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value));
                        }
                        int tmp = Data.ExpertsList[i].Item3.IndexOf(ProblemsListComboBox.SelectedItem.ToString());
                        //Data.ExpertsList[i].Item2[tmp] = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                        File.CreateText("data/Experts/" + Data.ExpertsList[i].Item1 + "/Problems.txt").Close(); //чистим строчку
                        File.CreateText("data/Experts/" + Data.ExpertsList[i].Item1 + "/Coefficient.txt").Close(); //чистим
                        List<string> tmpList = new List<string>();
                        tmpList = (List<string>)Data.ExpertsList[i].Item2.ConvertAll<string>(x => x.ToString());
                        tmpList.Insert(0, Data.ExpertsList[i].Item2.Count.ToString());
                        File.WriteAllLines("data/Experts/" + Data.ExpertsList[i].Item1 + "/Coefficient.txt", tmpList);
                        tmpList.Clear();
                        tmpList.AddRange(Data.ExpertsList[i].Item3);
                        //tmpList = Data.ExpertsList[i].Item3.CopyTo(tmpList);
                        tmpList.Insert(0, Data.ExpertsList[i].Item3.Count.ToString());
                        File.WriteAllLines("data/Experts/" + Data.ExpertsList[i].Item1 + "/Problems.txt", tmpList);

                    }

                }
            }

            //CurrentExpertProblemsSelected.Clear();
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if ((bool)dataGridView1.Rows[i].Cells[1].Value == true)
            //    {

            //        CurrentExpertProblemsSelected.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //        CurrentExpertProblemsSelectedCoefficient.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value));
            //    }
            //    else
            //    {
            //        if (File.Exists("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/SecondLab_" + dataGridView1.Rows[i].Cells[0].Value.ToString()))
            //        {
            //            File.Delete("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/SecondLab_" + dataGridView1.Rows[i].Cells[0].Value.ToString());
            //        }
            //    }
            //}
            //File.CreateText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Problems.txt").Close(); //чистим строчку
            //File.CreateText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt").Close(); //чистим строчку
            //for (int i = 0; i < Data.ExpertsList.Count; i++)
            //{
            //    if (Data.ExpertsList[i].Item1 == Data.CurrentExpertTuple.Item1)
            //    {
            //        Data.ExpertsList[i].Item3.Clear();
            //        Data.ExpertsList[i].Item2.Clear();
            //        for (int j = 0; j < CurrentExpertProblemsSelected.Count; j++)
            //        {
            //            Data.ExpertsList[i].Item3.Add(CurrentExpertProblemsSelected[j]);
            //            Data.ExpertsList[i].Item2.Add(CurrentExpertProblemsSelectedCoefficient[j]);
            //        }
            //    }
            //}
            //CurrentExpertProblemsSelected.Insert(0, CurrentExpertProblemsSelected.Count.ToString());
            //CurrentExpertProblemsSelectedCoefficient.Insert(0, CurrentExpertProblemsSelectedCoefficient.Count);
            //File.WriteAllLines("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Problems.txt", CurrentExpertProblemsSelected);
            ////File.WriteAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt", Convert.ToString(EditExpertCoefficientNumericUpDown.Value));
            //File.WriteAllLines("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt", (List<string>)CurrentExpertProblemsSelectedCoefficient.ConvertAll<string>(x => x.ToString()));

            Data.ProblemsFileName = "ad.txt";
            MessageBox.Show("Успешно сохранено");
        }

        private void DeleteExpert_Click(object sender, EventArgs e)
        {
            Sessions CurrentSession = new Sessions();
            Tuple<string, List<double>, List<string>> tmpTuple = (Tuple<string, List<double>, List<string>>)ProblemsListComboBox.SelectedItem;
            CurrentSession.RemoveExpert(tmpTuple.Item1);
            MessageBox.Show("Эксперт успешно удален");
            MakeExpert Refresh = new MakeExpert();
            Refresh.Show();
            this.Hide();
        }

        private void MakeExpert_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
