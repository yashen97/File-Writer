using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Filing
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\Writer.txt";
            {
                using (FileStream bb = File.Create(fileName))
                {
                    for (int z = 1; z <= 100; z++)
                    {
                        var y = DateTime.Now.ToString("hh:mm:ss:fff");
                        Byte[] title = new UTF8Encoding(true).GetBytes("\t" + z + " =====> " + y + "\n");
                        bb.Write(title, 0, title.Length);
                    }
                }
                {
                    using (StreamReader tt = File.OpenText(fileName))

                    {
                        string b = "";
                        Console.WriteLine("     \n \t\t\tReading from the file  . . . \n     ");
                        while ((b = tt.ReadLine()) != null)
                        {
                            Console.WriteLine(b + " Time of reading :" + DateTime.Now.ToString("hh:mm:ss:fff"));
                        }
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
