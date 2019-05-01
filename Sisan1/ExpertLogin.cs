using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class ExpertLogin : Form
    {
        
        public ExpertLogin()
        {
            Sessions InitAllProblems = new Sessions();
            InitAllProblems.LoadSession();
            Data.AllProblems = InitAllProblems.Problems;


            InitializeComponent();
            InitComboBox();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            //Data.CurrentExpertTuple = ExpertsListComboBox.SelectedItem;
            Data.CurrentExpertTuple = (Tuple<string,List<double>,List<string>>)ExpertsListComboBox.SelectedItem;
            Data.CurrentExpertName = Data.CurrentExpertTuple.Item1;
            if (Data.CurrentExpertTuple.Item3.Count > 0)
            {
                Form2 ExpertLoggedIn = new Form2();
                ExpertLoggedIn.Show();

                this.Hide();
            }
            else
                MessageBox.Show("Вам не назначены проблемы");
        }

        private void InitComboBox()
        {
            //string tmpLine;
            //StreamReader reader;
            //MessageBox.Show(Convert.ToString(ExpertsList.Count));
            //reader = new StreamReader("data\\ExpertsList.txt");
            //while ((tmpLine = reader.ReadLine()) != null)
            //{
            //    ExpertsList.Add(tmpLine);
            //}
            //reader.Close();
            InitExpertsList();
            ExpertsListComboBox.DataSource = Data.ExpertsList;
            ExpertsListComboBox.DisplayMember = "Item1";

        }

        private void InitExpertsList()
        {
            if (!Data.ExpertsNamesInited)
            {
                Data.ExpertsNamesInited = true;
                string path = "data/Experts/";
                foreach (string s in Directory.GetDirectories(path))
                {
                    if (File.Exists(s + "/Coefficient.txt") && File.Exists(s + "/Problems.txt"))
                    {
                        Sessions CurrentSession = new Sessions();
                        //double tmpDouble = Convert.ToDouble(File.ReadAllText(s + "/Coefficient.txt"));
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
        private void ExpertsListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ExpertLogin_Load(object sender, EventArgs e)
        {

        }

        private void ExpertLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            this.Hide();
            lgn.Show();
        }
    }
}
