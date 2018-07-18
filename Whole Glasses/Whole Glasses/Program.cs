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
            int input;
            Console.WriteLine("How often do you hear the drip, in seconds?");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToInt32((86400 / input * 0.00025)/0.250));
            Console.ReadLine();
        }
    }
}
