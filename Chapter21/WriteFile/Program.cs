using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] dataByte;
            char[] dataChar;
            try
            {
                FileStream aFile = new FileStream("../../test.txt", FileMode.Create);
                dataChar = "My pink half of the drainpipe.".ToCharArray();
                dataByte = new byte[dataChar.Length];
                Encoder e = Encoding.UTF8.GetEncoder();
                e.GetBytes(dataChar, 0, dataChar.Length, dataByte, 0, true);

                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(dataByte, 0, dataByte.Length);

                Console.WriteLine("write success.");
                Console.ReadKey();
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error occurred : " + ex.Message);
            }

            
        }
    }
}
