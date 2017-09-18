using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] dataByte=new byte[200];
            char[] dataChar=new char[200];
            try
            {
                FileStream aFile = new FileStream("../../Program.cs", FileMode.Open);
                aFile.Seek(113, SeekOrigin.Begin);
                aFile.Read(dataByte, 0, 200);
            }
            catch (IOException e)
            {
                Console.WriteLine("error has current:" + e.Message);
            }

            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(dataByte, 0, dataByte.Length, dataChar, 0);
            Console.WriteLine(dataChar);
            Console.ReadKey();
        }
    }
}
