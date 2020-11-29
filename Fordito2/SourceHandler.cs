using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fordito2
{
    class SourceHandler
    {
        private string path;
        

        public string Path
        {
            get { return path; }
            set { path = value; }
        }


        public SourceHandler(String path)
        {
            this.path = path;
        }
        public string[] OpenFileToRead()
        {
            string[] content;
            try
            {
                StreamReader SR = new StreamReader(File.OpenRead(this.path));
                string s = SR.ReadToEnd();
                content = s.Split(' ');

                //while (SR.Peek()>-1)
                //{
                //    content = SR.ReadLine();
                //}

                SR.Close();
                return content;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
