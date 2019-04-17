using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Sisan1
{
    public partial class ExpertLogin : Form
    {
        public List<string> ExpertsList = new List<string>();
        public ExpertLogin()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void InitComboBox()
        {
            string tmpLine;
            StreamReader reader;
            reader = new StreamReader("data\\ExpertsList.txt");
            while ((tmpLine = reader.ReadLine()) != null)
            {
                ExpertsList.Add(tmpLine);
            }
            reader.Close();
            ExpertsListComboBox.DataSource = ExpertsList;

        }
    }
}
