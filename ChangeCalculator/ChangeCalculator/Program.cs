using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int twoHun=0;
            int oneHun=0;
            int fifty=0;
            int twenty=0;
            int ten=0;
            int five=0;
            int two=0;
            int one=0;
            int cenFif = 0;
            int cenTwen = 0;
            int cenTen = 0;
            int cenFive = 0;
            int cenTwo = 0;
            int cenOne = 0;
           

            Console.WriteLine("How much money do you have?: ");
            string input1;
            string input2;
            input1 = Console.ReadLine();
            input2 = input1;
            input2 = input2.Substring(0, input2.Length - 3);


            int change;
            int cents = Convert.ToInt32(input1.Substring(input1.Length - 2));
            if (!int.TryParse(input2, out change) && !input1.Contains("."))
            {
                Console.WriteLine("That is not a valid entry!");
                return;
            }
            if (input1.Contains("."))
            {
                cenFif = cents / 50;
                cents = cents - (50 * cenFif);
                cenTwen = cents / 20;
                cents = cents - (20 * cenTwen);
                cenTen = cents / 10;
                cents = cents - (10 * cenTen);
                cenFive = cents / 5;
                cents = cents - (5 * cenFive);
                cenTwo = cents / 2;
                cents = cents - (2 * cenTwo);
                cenOne = cents / 1;
                cents = cents - (1 * cenOne);
            }

            twoHun = change / 200;
            change = change - (200 * twoHun);
            oneHun = change / 100;
            change = change - (100 * oneHun);
            fifty = change / 50;
            change = change - (50 * fifty);
            twenty = change / 20;
            change = change - (20 * twenty);
            ten = change / 10;
            change = change - (10 * ten);
            five = change / 5;
            change = change - (5 * five);
            two = change / 2;
            change = change - (2 * two);
            one = change / 1;
            change = change - (1 * one);

            Console.WriteLine("Return: x" + twoHun + " R200");
            Console.WriteLine("Return: x" + oneHun + " R100");
            Console.WriteLine("Return: x" + fifty + " R50");
            Console.WriteLine("Return: x" + twenty + " R20");
            Console.WriteLine("Return: x" + ten + " R10");
            Console.WriteLine("Return: x" + five + " R5");
            Console.WriteLine("Return: x" + two + " R2");
            Console.WriteLine("Return: x" + one + " R1");
            Console.WriteLine("Return: x" + cenFif + " fifty cent");
            Console.WriteLine("Return: x" + cenTwen + " twenty cent");
            Console.WriteLine("Return: x" + cenTen + " ten cent");
            Console.WriteLine("Return: x" + cenFive + " five cent");
            Console.WriteLine("Return: x" + cenTwo + " two cent");
            Console.WriteLine("Return: x" +cenOne + " one cent");
            Console.ReadLine();


        }
    }
}
