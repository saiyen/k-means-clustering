using item_user.FileReader;
using System;

namespace k_means_clustering
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] PreferedWinesOfClients = ReadFromFile.getPreferedWinesOfClients();

            for (int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 32; j++)
                {
                    Console.WriteLine(PreferedWinesOfClients[i, j]);
                }
            }
        }
    }
}
