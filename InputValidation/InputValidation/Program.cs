using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whole_Glasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;
            Console.WriteLine("How often do you hear the drip, in seconds?");
            input = Console.ReadLine();
            if (int.TryParse(input, out value))
            {
                
                Console.WriteLine(Convert.ToInt32((86400 / value * 0.00025) / 0.250));
                Console.ReadLine();

            }
            else{ Console.WriteLine("Invalid input. Please use numbers"); }
            Console.ReadLine();
        }
    }
}
