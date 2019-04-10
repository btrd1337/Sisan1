using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Sisan1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<string> alterntaivs = new List<string>();
        int alterCount = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            Problem.Text = Enter_Analyst.ChosenProblemA;
        }

        private void AddAlternative(string db) // Добавление альтернативы
        {
            alterCount++;
            alterntaivs.Add(db);
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
            alterntaivs.RemoveAt(select); // Удалить альтернативу
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
                DeleteItem(0);
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
                    listBox1.SelectedIndex = counter-1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Сохранение альтернатив в файл
            string Filename = "data/Alternatives_" + Enter_Analyst.ChosenProblemA;

            string output = string.Empty;
            for (int n = 0; n < alterCount; n++)
            {
                output += alterntaivs[n] + "\n";
            }
            System.IO.File.WriteAllText(Filename, output);

            Login lgn = new Login();
            this.Hide();
            lgn.Show();
        }
    }
}
