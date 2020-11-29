using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordito2
{
    class Program
    {
        static void Main(string[] args)
        {
            Automat A = new Automat();
            string currentDirectory = Directory.GetCurrentDirectory();
            SourceHandler SH = new SourceHandler(@currentDirectory + "/filename.txt");


            string[] collect = SH.OpenFileToRead();
            foreach (string s in collect)
            {
                A.main("A", s);
            }
            //A.main("A","+a122");
            Console.ReadLine();
        }
    }
}
