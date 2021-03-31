using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using ConsoleApp23.BackUpOperation;
using ConsoleApp23.dbTables;

namespace ConsoleApp23
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:63467");


            /*Console.WriteLine("posilam");
            string result = await client.GetStringAsync("/api/users");*/
            BackupFiles files = new BackupFiles();
            files.Path = @"C:\backup\From";
            IBackup backup = new Full(files);
            while (true)
            {
                Console.Clear();
                string temp = Console.ReadLine();

                if (temp == "backup")
                {
                    backup.Backup();
                }
            }

        }
    }
}
