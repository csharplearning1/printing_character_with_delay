using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace pch
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                string word = "Hello";
                for (int i = 0; i < word.Length; i++)
                {

                    Console.Write(word[i]);
                    Thread.Sleep(1000);
                }
            }

            Console.ReadLine();

        }

    }
}
