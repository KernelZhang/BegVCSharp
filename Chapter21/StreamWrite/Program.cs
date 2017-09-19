using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream aFile = new FileStream("../../streamwrite.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(aFile);
                bool trueTh = true;
                sw.WriteLine("Hello to you");
                sw.WriteLine("It is now {0} and things look good.", DateTime.Now.ToLongDateString());
                sw.Write("More than that ");
                sw.Write("It's {0} that C# is fun.", trueTh);
                sw.Close();
                Console.WriteLine("文件写入成功.");
                Console.ReadKey();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
