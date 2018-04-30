using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            List<Task<List<string>>> tasks = new List<Task<List<string>>>();
            do
            {
                Console.Write("Input directory path or 'exit': ");
                string toRead = Console.ReadLine();
                if (toRead == "exit" || toRead == "e" || toRead == "Exit") done = true;
                else if (Directory.Exists(toRead)) tasks.Add(writeOut.getInfoAsync(toRead));
            } while (!done);
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine($"{Environment.NewLine}Files Found{Environment.NewLine}----- -----{Environment.NewLine}{Environment.NewLine}");
            foreach(Task<List<string>> t in tasks)
            {
                foreach(string s in t.Result)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
