using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sample_matrix
{
    public class mat_ch
    {
        private static Random rnd = new Random();
        private const string abc = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

        public char ch = 'a';
        public int height = 0;

        public void move()
        {
            if (Console.WindowHeight - 1 > height)
            {
                height++;
            }
            else height = 0;

            ch = abc[rnd.Next(abc.Length)];
        }
        public mat_ch() 
        {
            ch = abc[rnd.Next(abc.Length)];
            height = rnd.Next(0, Console.WindowHeight);
        }
    }
}
