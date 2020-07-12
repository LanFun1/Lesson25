using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            while(number < 100)
            {
                Console.Write(number + " ");
                number += 7;
            }
        }
    }
}
