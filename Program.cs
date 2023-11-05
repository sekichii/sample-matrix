using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sample_matrix
{
    internal class Program
    {
        Random random = new Random();

        void delAbove(int h, int left)
        {
            if (h < 0) Console.SetCursorPosition(left, Console.BufferHeight + h);
            else Console.SetCursorPosition(left, h);

            Console.Write(" ");
        }

        Program() {
            const int trail_height = 10;

            int window_width = Console.WindowWidth;
            int window_height = Console.WindowHeight;

            List<mat_ch> chars = new List<mat_ch>();

            //fills the list up
            for (int i = 0; i < window_width; i++)
            {
                var ch = new mat_ch();
                chars.Add(ch);
            }

            //the actual thing

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int i = 0; i < chars.Count; i++)
                {
                    chars[i].move();
                    int row = chars[i].height;
                    int col = i;

                    Console.SetCursorPosition(col, row);
                    Console.Write(chars[i].ch);
                    delAbove(row - trail_height, col);
                }

                Thread.Sleep(40);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please don't resize this window.");
            Console.WriteLine("Also the pattern of the matrix always repeats so that's cool.");
            Console.WriteLine("Anyways, have fun seeing my sample work.");
            Console.WriteLine("Press enter to start.");
            Console.ReadLine();
            new Program();
        }
    }
}
