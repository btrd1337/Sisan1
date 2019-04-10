﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Sisan1
{
    public class Sessions
    {
        public bool initalized = false;
        int ProblemsCountToWrite;
        int ProblemsCountRead;
        public List<string> Problems = new List<string>();

        public bool SaveSession(string name)
        {
            string tmp;
            StreamReader reader = new StreamReader("ad.txt");
            ProblemsCountToWrite = Convert.ToInt32(reader.ReadLine());
            if (ProblemsCountToWrite>0)
            tmp = Convert.ToString((ProblemsCountToWrite + 1) + "\n" + reader.ReadToEnd() + "\n" + name);
            else
                tmp = Convert.ToString((ProblemsCountToWrite + 1) + "\n" + name);

            reader.Close();
            File.WriteAllText("ad.txt", tmp);
            return true;
        }

        public bool LoadSession()
        {
            if (!initalized)
            {
                StreamReader reader = new StreamReader("ad.txt");
                ProblemsCountRead = Convert.ToInt32(reader.ReadLine());
                for (int i = 0; i < ProblemsCountRead; i++)
                {
                    Problems.Add(reader.ReadLine());
                }
                reader.Close();
                return true;
            }
            return false;
        }

        public bool RemoveProblem(string name)
        {
            int NumToDelete = -1;
            var file = new List<string>(File.ReadAllLines("ad.txt"));
            for (int i = 0; i < file.Count; i++)
            {
                if (file[i].Equals(name))
                {
                    NumToDelete = i;
                }
            }
            if (NumToDelete > 0)
            {
                file.RemoveAt(NumToDelete);
                file[0] = Convert.ToString((Convert.ToInt32(file[0]) - 1));
            }
            var writer = new StreamWriter("ad.txt");
            writer.NewLine = "\n";

            for (int i = 0; i < file.Count - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(file[i]))
                {
                    file.RemoveAt(i);
                    file[0] = Convert.ToString((Convert.ToInt32(file[0]) + 1));
                }
                else
                {
                    writer.WriteLine(file[i]);
                }
            }
            writer.Write(file[file.Count - 1]);
            writer.Close();
            //using (var writer = new StreamWriter("ad.txt"))
            //{
            //    writer.NewLine = "\n";
            //    foreach (var line in file.ToArray())
            //    {
            //        writer.WriteLine(line);
            //    }
            //}

            //File.WriteAllLines("ad.txt", file.ToArray());
            File.Delete("data/Alternatives_" + name);
            return true;

        }

        public bool CheckMatrix(string name)
        {
            if (!File.Exists("data/Matrix_" + name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
