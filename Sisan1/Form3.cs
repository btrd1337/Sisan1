using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            InitPreviousProblem();
            for (int i = 0; i < Alternatives.Count; i++)
            {
                AlternativesListDataGridView.Rows.Add();
                AlternativesListDataGridView.Rows[i].Cells[0].Value = Alternatives[i];
            }

        }

        List<string> Alternatives = new List<string>();
        int alterCount = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            Problem.Text = Enter_Analyst.ChosenProblemA;
            if (File.Exists("data/ScaleSize_" + Enter_Analyst.ChosenProblemA))
            {
                FourthLabNumericUpDown.Value = Convert.ToDecimal(File.ReadAllText("data/ScaleSize_" + Enter_Analyst.ChosenProblemA));
            }
        }

        private void AddAlternative(string db) // Добавление альтернативы
        {
            alterCount++;
            Alternatives.Add(db);
            listBox1.Items.Add(db);
            listBox1.SelectedIndex++;
        }

        private void button1_Click(object sender, EventArgs e) // Добавить альтернативу
        {
            DialogBox db = new DialogBox();
            db.Owner = this;
            db.ShowDialog();

            if (db.DialogResult == DialogResult.OK)
            {
                AddAlternative(db.alternative);
            }
        }

        private void DeleteItem(int select) // Удаление альтернативы
        {
            Alternatives.RemoveAt(select); // Удалить альтернативу
            listBox1.Items.RemoveAt(select);
            alterCount--; // Уменьшить счетчик альтернатив
            listBox1.SelectedIndex = alterCount - 1;
        }

        private void button2_Click(object sender, EventArgs e) // Удалить альтернативу
        {
            if (alterCount != 0)
            {
                int i = listBox1.SelectedIndex;
                DeleteItem(i);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Очистить список альтернатив
        {
            while (alterCount != 0)
            {
                DeleteItem(0);
            }
        }

        private void InitPreviousProblem()
        {
            try
            {
                string Filename2 = "data\\Alternatives_" + Enter_Analyst.ChosenProblemA;
                if (System.IO.File.Exists(Filename2))
                {
                    if (new FileInfo(Filename2).Length > 0)
                    {
                        var sr = new StreamReader(Filename2); // Сканируем файл
                        var text = new List<string>();

                        int counter = 0;
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            AddAlternative(line);
                            counter++;
                        }
                        sr.Close();
                        listBox1.SelectedIndex = counter - 1;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e) // Ввести альтернативы из файла
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(openFileDialog1.FileName); // Сканируем файл
                    var text = new List<string>();

                    int counter = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        AddAlternative(line);
                        counter++;
                    }
                    sr.Close();
                    listBox1.SelectedIndex = counter - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Alternatives.Clear();
            //for (int i = 0; i < AlternativesListDataGridView.Rows.Count - 1; i++)
            //{
            //    Alternatives.Add(Convert.ToString(AlternativesListDataGridView.Rows[i].Cells[0].Value));
            //}
            //// Сохранение альтернатив в файл
            //string Filename = "data/Alternatives_" + Enter_Analyst.ChosenProblemA;

            //string output = string.Empty;
            //for (int n = 0; n < Alternatives.Count; n++)
            //{
            //    output += Alternatives[n] + "\n";
            //}
            //System.IO.File.WriteAllText(Filename, output);

            //Login lgn = new Login();
            //this.Hide();
            //lgn.Show();
            Enter_Analyst goBack = new Enter_Analyst();
            this.Hide();
            goBack.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AlternativesListDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //AlternativesListDataGridView.Rows.RemoveAt(AlternativesListDataGridView.CurrentCell.RowIndex);
            //DeleteItem(AlternativesListDataGridView.CurrentCell.RowIndex);
            //AlternativesListDataGridView.Rows.Clear();
            //for (int i = 0; i < Alternatives.Count; i++)
            //{
            //    AlternativesListDataGridView.Rows.Add();
            //    AlternativesListDataGridView.Rows[i].Cells[0].Value = Alternatives[i];
            //}
        }

        private void AlternativesListDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Delete)
            {
                AlternativesListDataGridView.Rows.RemoveAt(AlternativesListDataGridView.CurrentCell.RowIndex);
            }
        }

        private void AlternativesListDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && AlternativesListDataGridView.Rows.Count > 1)
            {
                AlternativesListDataGridView.Rows.RemoveAt(AlternativesListDataGridView.CurrentCell.RowIndex);
            }
        }

        private void SaveExitButton_Click(object sender, EventArgs e)
        {
            Alternatives.Clear();

            for (int i = 0; i < AlternativesListDataGridView.Rows.Count - 1; i++)
            {
                Alternatives.Add(Convert.ToString(AlternativesListDataGridView.Rows[i].Cells[0].Value));
            }
            // Сохранение альтернатив в файл
            string Filename = "data/Alternatives_" + Enter_Analyst.ChosenProblemA;

            string output = string.Empty;
            for (int n = 0; n < Alternatives.Count; n++)
            {
                output += Alternatives[n] + "\n";
            }
            System.IO.File.WriteAllText(Filename, output);
                System.IO.File.WriteAllText("data/ScaleSize_" + Enter_Analyst.ChosenProblemA, FourthLabNumericUpDown.Value.ToString());
            
            //Login lgn = new Login();
            //this.Hide();
            //lgn.Show();
            Enter_Analyst goBack = new Enter_Analyst();
            this.Hide();
            goBack.Show();

        }

        private void AlternativesListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AlternativesListDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if ((String.IsNullOrWhiteSpace(Convert.ToString(AlternativesListDataGridView.CurrentCell.Value))) && AlternativesListDataGridView.CurrentCell.RowIndex < AlternativesListDataGridView.Rows.Count - 1)
            //{
            //    AlternativesListDataGridView.Rows.RemoveAt(AlternativesListDataGridView.CurrentCell.RowIndex);

            //}

        }

        private void AlternativesListDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (AlternativesListDataGridView.CurrentCell != null)
            {
                if ((String.IsNullOrWhiteSpace(Convert.ToString(AlternativesListDataGridView.CurrentCell.Value))) && AlternativesListDataGridView.CurrentCell.RowIndex < AlternativesListDataGridView.Rows.Count - 1)
                {
                    AlternativesListDataGridView.Rows.RemoveAt(AlternativesListDataGridView.CurrentCell.RowIndex);

                }
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FourthLabNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
