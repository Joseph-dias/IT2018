using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace newStrings
{
    public static class writeOut
    {
        public static async Task<List<string>> getInfoAsync(string dName)
        {
            List<string> files = new List<string>();
            DirectoryInfo d = new DirectoryInfo(dName);
            foreach(FileInfo newFile in d.GetFiles())
            {
                files.Add(newFile.Name);
            }
            return files;
        }
        
        /*private static async Task<string> getTXTAsync(string prompt)
        {
            Console.Write(prompt + ": ");
            string txt = await Task.Run(() => Console.ReadLine());
            return txt;
        }*/
    }
}
