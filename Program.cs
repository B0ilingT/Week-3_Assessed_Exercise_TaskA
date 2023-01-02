using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree<string> textWords = new BSTree<string>();
            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];
            AllLines = File.ReadAllLines("textFile.txt"); //reads from bin/DEBUG subdirectory of project directory
            foreach (string line in AllLines)
            {
                //split words using space , . ?
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');
                foreach (string word in words)
                    if (word != "")
                    {
                        Console.WriteLine(word.ToLower());
                        textWords.InsertItem(word.ToLower());
                    }
               
            }
            Console.WriteLine("Height of Tree = " + textWords.Height());
            Console.WriteLine("Number of Unique Words = " + textWords.Count());
            Console.ReadKey();

        }
    }
}
