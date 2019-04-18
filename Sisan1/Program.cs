﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sisan1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data.ExpertsList = new List<Tuple<string, double, List<string>>>();
            Data.ProblemsFileName = "ad.txt";
            Data.ExpertsNamesInited = false;
            Sessions InitAllProblems = new Sessions();
            InitAllProblems.LoadSession();
            Data.AllProblems = InitAllProblems.Problems;
            
            Application.Run(new Login());
        }

    }
    static class Data
    {
        public static string ProblemsFileName { set; get; }
        public static List<Tuple<string, double, List<string>>> ExpertsList { set; get; }
        public static Tuple<string, double, List<string>> CurrentExpertTuple { set; get; }
        public static string CurrentExpertName { set; get; }
        public static bool ExpertsNamesInited { set; get; }
        public static double CurrentCoefficient { set; get; }
        public static List<string> AllProblems { set; get; }
    }
}
