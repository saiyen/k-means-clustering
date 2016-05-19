using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace item_user.FileReader
{
    class ReadFromFile
    {
        static private string line;
        static string project_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        static StreamReader file;

        static int[,] PreferedWinesOfClients = new int[100, 32];

        public static int[,] getPreferedWinesOfClients()
        {
            // Read the file and display it line by line.
            file = new StreamReader(project_path + "/DataSet/WineData.csv");
            int count = 0;

            while ((line = file.ReadLine()) != null)
            {
                var temp = line.Split(',');

                for (int i = 0; i < temp.Length; i++)
                {
                    //Console.WriteLine(temp[i]);
                    //toevoegen in de array boven
                    PreferedWinesOfClients[i, count] = int.Parse(temp[i]);
                }

                count++;
            }
            file.Close();

            return PreferedWinesOfClients;
        }
    }
}