using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sisan1 //В этой формочке еще и удалять и редактировать экспертов будет можно (со временем)
{
    public partial class MakeExpert : Form
    {
        private bool SelectedIndexChangedCount;
        public List<Tuple<string, double>> ExpertsList = new List<Tuple<string, double>>();
        private List<string> CurrentExpertProblemsSelected = new List<string>();

        public MakeExpert()
        {
            InitializeComponent();
            SelectedIndexChangedCount = false;
        }


        private void MakeExpert_Load(object sender, EventArgs e)
        {
            InitExpertsList();
            ExpertListComboBox.DataSource = Data.ExpertsList;
            ExpertListComboBox.DisplayMember = "Item1";
            ExpertListComboBox.SelectedItem = null;
            ExpertListComboBox.SelectedIndex = -1;
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
                    File.WriteAllText("data/Experts/" + ExpertNameTextBox.Text + "/Coefficient.txt", ExpertCoefficientNumericUpDown.Value.ToString());
                    File.CreateText("data/Experts/" + ExpertNameTextBox.Text + "/Problems.txt").Close();
                    Data.ExpertsList.Add(new Tuple<string, double, List<string>>(ExpertNameTextBox.Text, Convert.ToDouble(ExpertCoefficientNumericUpDown.Value), new List<string>()));
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
                Sessions CurrentSession = new Sessions();
                Data.ExpertsNamesInited = true;
                string path = "data/Experts/";
                foreach (string s in Directory.GetDirectories(path))
                {
                    if (File.Exists(s + "/Coefficient.txt") && File.Exists(s + "/Problems.txt"))
                    {
                        double tmpDouble = Convert.ToDouble(File.ReadAllText(s + "/Coefficient.txt"));
                        List<string> tmpProblemsString = new List<string>();
                        Data.ProblemsFileName = "data/Experts/" + s.Remove(0, path.Length) + "/Problems.txt";
                        CurrentSession.LoadSession();
                        Data.ExpertsList.Add(Tuple.Create(s.Remove(0, path.Length), tmpDouble, CurrentSession.Problems));
                    }
                }
                Data.ProblemsFileName = "ad.txt";

            }

        }

        private void LoadPreviousCoefficient()
        {
            if (File.Exists("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt"))
            {
                Data.CurrentCoefficient = Convert.ToDouble(File.ReadAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt"));
                EditExpertCoefficientNumericUpDown.Value = (decimal)Data.CurrentCoefficient;
            }
        }

        private void LoadPreviousProblems()
        {
            Sessions LoadProblem = new Sessions();
            Data.CurrentExpertTuple = (Tuple<string, double, List<string>>)ExpertListComboBox.SelectedItem;
            Data.ProblemsFileName = "data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Problems.txt";
            LoadProblem.LoadSession();
            CurrentExpertProblemsSelected = LoadProblem.Problems;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = false;
            }

            for (int i = 0; i < CurrentExpertProblemsSelected.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (dataGridView1.Rows[j].Cells[0].Value.ToString() == CurrentExpertProblemsSelected[i])
                    {
                        dataGridView1.Rows[j].Cells[1].Value = true;
                    }
                }
            }



        }

        private void ExpertNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitDataGrid()
        {
            // dataGridView1.Rows.Add();
            dataGridView1.Columns[1].ReadOnly = false;
            //Tuple<string, double, List<string>> tempSelectedItem = (Tuple<string, double, List<string>>)ExpertListComboBox.SelectedItem;
            for (int i = 0; i < Data.AllProblems.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Data.AllProblems[i];
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
                if (ExpertListComboBox.SelectedIndex > -1 && SelectedIndexChangedCount)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    EditExpertGroupBox.Visible = true;
                    EditExpertCoefficientNumericUpDown.Value = 0;
                    InitDataGrid();
                    LoadPreviousProblems();
                    LoadPreviousCoefficient();
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
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {

            CurrentExpertProblemsSelected.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[1].Value == true)
                {

                    CurrentExpertProblemsSelected.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
            }
            File.CreateText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Problems.txt").Close(); //чистим строчку
            for (int i = 0; i < Data.ExpertsList.Count; i++)
            {
                if (Data.ExpertsList[i].Item1 == Data.CurrentExpertTuple.Item1)
                {
                    Data.ExpertsList[i].Item3.Clear();
                    for (int j = 0; j < CurrentExpertProblemsSelected.Count; j++)
                    {
                        Data.ExpertsList[i].Item3.Add(CurrentExpertProblemsSelected[j]);
                    }
                }
            }
            CurrentExpertProblemsSelected.Insert(0, CurrentExpertProblemsSelected.Count.ToString());
            File.WriteAllLines("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Problems.txt", CurrentExpertProblemsSelected);
            File.WriteAllText("data/Experts/" + Data.CurrentExpertTuple.Item1 + "/Coefficient.txt", Convert.ToString(EditExpertCoefficientNumericUpDown.Value));
            Data.ProblemsFileName = "ad.txt";
            MessageBox.Show("Успешно сохранено");
        }

        private void DeleteExpert_Click(object sender, EventArgs e)
        {
            Sessions CurrentSession = new Sessions();
            Tuple<string, double, List<string>> tmpTuple = (Tuple<string, double, List<string>>)ExpertListComboBox.SelectedItem;
            CurrentSession.RemoveExpert(tmpTuple.Item1);
            MessageBox.Show("Эксперт успешно удален");
            MakeExpert Refresh = new MakeExpert();
            Refresh.Show();
            this.Hide();
        }
    }
}
