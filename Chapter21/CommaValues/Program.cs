using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CommaValues
{
    class Program
    {
        //创建一个文件处理的静态方法，该方法的返回值是一个List<Dictionry<string,string>>，还需要一个输出参数，用于保存列名。
        private static List<Dictionary<string, string>> getData(out List<string> columns)
        {
            string line;
            columns = new List<string>();
            char[] sChar = { ',' };
            string[] strArray;
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            try
            {
                FileStream aFile = new FileStream("../../SomeData.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                //获取表格标题行，并且打印
                line = sr.ReadLine();
                strArray = line.Split(sChar);
                //foreach (string str in strArray)
                //{
                //    columns.Add(str);
                //}
                for (int x = 0; x <= strArray.GetUpperBound(0); x++)
                {
                    columns.Add(strArray[x]);
                }

                line = sr.ReadLine();
                while (line != null)
                {
                    strArray = line.Split(sChar);
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (int x = 0; x <= strArray.GetUpperBound(0); x++)
                    {
                        row.Add(columns[x], strArray[x]);
                    }
                    data.Add(row);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return data;

        }


        static void Main(string[] args)
        {
            List<string> columns;
            List<Dictionary<string, string>> myData = getData(out columns);
            foreach (string str in columns)
            {
                Console.Write("{0,-20}", str);
            }
            Console.WriteLine();

            foreach (Dictionary<string, string> row in myData)
            {
                foreach (string str in columns)
                {
                    Console.Write("{0,-20}", row[str]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
