using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.IO;

namespace FileHandleApp
{
    class Program
    {
    class FileWrite
    {
        public void WriteData()
        {
            FileStream fs = new FileStream("N:\\swabhav\\c#\\sample.txt",FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text");
            String str = Console.ReadLine();
                sw.WriteLine(str);
                Console.WriteLine("Showing content in file: ");
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                str = sr.ReadLine();
                while(str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
            sw.Flush();
            sw.Close();
            sr.Close();
            fs.Close();
        }
    }
        static void Main(string[] args)
        {
            FileWrite wr = new FileWrite();
            wr.WriteData();
        }
    }
}
