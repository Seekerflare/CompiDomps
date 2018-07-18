using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("How often do you hear the drip, in seconds?");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You waste " + 3600 / input * 0.00025 + " liters per hour");
            Console.WriteLine("You waste " + 86400 / input * 0.00025 + " liters per day");
            Console.WriteLine("You waste " + 604800 / input * 0.00025 + " liters per week");
            Console.ReadLine();
        }
    }
}
