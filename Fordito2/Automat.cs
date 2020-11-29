using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordito2
{
    class Automat
    {
        Dictionary<String, String> D = new Dictionary<string, string>();
        public void prepare()
        {
            D.Clear();
            D.Add("A+", "B");
            D.Add("A-", "B");
            D.Add("Ad", "C");
            D.Add("Bd", "C");
            D.Add("Cd", "C");
        }
        public char convert(char c)
        {
            if (Char.IsDigit(c))
            {
                return 'd';
            }
            return c;
        }
        public string delta(string state,char actual)
        {
            string ex = state + convert(actual);
            if (D.ContainsKey(state + convert(actual)))
            {
                return D[state + convert(actual)];
            }
            return "Error";
        }

         public void main(string state,string input)
        {
            prepare();
            int i = 0;
            while (i< input.Length&&state != "Error")
            {
                state = delta(state, input[i]);
                i++;
            }
            if (state!="Error")
            {
                Console.WriteLine("{0} helyes bemenő adat",input);
            }
            else
            {
                Console.WriteLine("{0} nem helyes bemenő adat. hibás karakter található a {1}.  helyen",input,i);
            }
        }
    }
}
