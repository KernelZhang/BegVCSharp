using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                FileStream aFile = new FileStream("../../streamwrite.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                Console.WriteLine("================use StreamReader.ReadLine()================");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("================use StreamReader.Read()================");
                FileStream aFile2 = new FileStream("../../streamwrite.txt", FileMode.Open);
                StreamReader sr2 = new StreamReader(aFile2);
                int iChar = sr2.Read();
                while (iChar != -1)
                {
                    Console.Write(Convert.ToChar(iChar));
                    iChar = sr2.Read();
                }
                Console.Write("\n");
                sr2.Close();
                Console.WriteLine("================use StreamReader.ReadToEnd()================");
                FileStream aFile3 = new FileStream("../../streamwrite.txt", FileMode.Open);
                StreamReader sr3 = new StreamReader(aFile3);
                string str = sr3.ReadToEnd();
                Console.Write(str);
                sr3.Close();
                Console.Write("\n");
                Console.WriteLine("================use File.ReadLine()================");
                foreach (string s in File.ReadLines("../../streamwrite.txt"))
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
