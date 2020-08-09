using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConFindOutFileClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Exploring File Class***************");
            Console.WriteLine("1.Creating a file using file class");
            File.Create(@"E:\Zensar_tech_training\frontend\dotnetconsole\File3created.txt");
            Console.WriteLine("File created");
            Console.WriteLine("2.WriteAllText method");
            File.WriteAllText(@"E:\Zensar_tech_training\frontend\dotnetconsole\File4created.txt", "Text written using Write all text static method.");
            Console.WriteLine("Text written");
            Console.WriteLine("3. Using Append all text static method");
            File.AppendAllText(@"E:\Zensar_tech_training\frontend\dotnetconsole\File4created.txt", "Appended text is this");
            Console.WriteLine("Text Appended in File4created.txt");
            Console.WriteLine("4.Using Read All Text static method");
          string str=  File.ReadAllText(@"E:\Zensar_tech_training\frontend\dotnetconsole\File4created.txt");
            Console.WriteLine("Readen text using ReadAllText() static method :{0}",str);
            Console.WriteLine("5.Using Copy static method");
           File.Copy(@"E:\Zensar_tech_training\frontend\dotnetconsole\File4created.txt", @"E:\Zensar_tech_training\frontend\dotnetconsole\copiedFile.txt");
            Console.WriteLine("Contents of file copied...........");
            Console.WriteLine("6.Using delete static method....");
            File.Delete(@"E:\Zensar_tech_training\frontend\dotnetconsole\File3created.txt");
            Console.WriteLine("File Deleted.................");
            Console.Read();
        }
    }
}
