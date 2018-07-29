using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input1;
            string input2;
            int averageAge=0, averageSalary=0, averageTax=0;
            int age;
            int salary;



            for (int i=0; i<args.Length; i++)
            {
                
                input1 = args[i];
                input2 = args[i + 1];
                i += 1;
                if ((!int.TryParse(input1, out age)) || age < 20 || age > 100)
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                    return;
                }

                if (input2.Contains("."))
                {
                    input2 = input2.Substring(0, input2.Length - 3);
                }

                if ((!int.TryParse(input2, out salary) || salary < 0))
                {

                    Console.WriteLine("Input not valid!");
                    Console.ReadLine();
                    return;
                }

                if (age < 65)
                {

                    if (salary <= 4999)
                    {
                        averageTax = averageTax + 0;
                    }
                    if (salary >= 5000 && salary <= 6499)
                    {
                        averageTax = averageTax + 13;
                    }
                    if (salary >= 6500 && salary <= 7799)
                    {
                        averageTax = averageTax + 250;
                    }
                    if (salary >= 7800 && salary <= 9999)
                    {
                        averageTax = averageTax + 620;
                    }

                    if (salary >= 10000 && salary <= 13499)
                    {
                        averageTax = averageTax + 1200;
                    }
                    if (salary >= 13500 && salary <= 17899)
                    {
                        averageTax = averageTax + 2100;
                    }
                    if (salary >= 17900 && salary <= 19999)
                    {
                        averageTax = averageTax + 2700;
                    }
                    if (salary >= 20000 && salary <= 39999)
                    {
                        averageTax = averageTax + 8000;
                    }
                    if (salary >= 40000 && salary <= 59999)
                    {
                        averageTax = averageTax + 16000;
                    }
                    if (salary > 60000)
                    {
                        averageTax = averageTax + 20000;
                    }

                }

                if (age >= 65 && age <= 75)
                {
                    if (salary <= 9999)
                    {
                        averageTax = averageTax + 0;
                    }

                    if (salary >= 10000 && salary <= 13499)
                    {
                        averageTax = averageTax + 600;
                    }
                    if (salary >= 13500 && salary <= 17899)
                    {
                        averageTax = averageTax + 1500;
                    }
                    if (salary >= 17900 && salary <= 19999)
                    {
                        averageTax = averageTax + 2000;
                    }
                    if (salary >= 20000 && salary <= 39999)
                    {
                        averageTax = averageTax + 7500;
                    }
                    if (salary >= 40000 && salary <= 59999)
                    {
                        averageTax = averageTax + 15600;
                    }
                    if (salary > 60000)
                    {
                        averageTax = averageTax + 17050;
                    }

                }
                if (age > 75)
                {
                    if (salary <= 9999)
                    {
                        averageTax = averageTax + 0;
                    }

                    if (salary >= 10000 && salary <= 13499)
                    {
                        averageTax = averageTax + 400;
                    }
                    if (salary >= 13500 && salary <= 17899)
                    {
                        averageTax = averageTax + 1200;
                    }
                    if (salary >= 17900 && salary <= 19999)
                    {
                        averageTax = averageTax + 1800;
                    }
                    if (salary >= 20000 && salary <= 39999)
                    {
                        averageTax = averageTax + 7300;
                    }
                    if (salary >= 40000 && salary <= 59999)
                    {
                        averageTax = averageTax + 15400;
                    }
                    if (salary > 60000)
                    {
                        averageTax = averageTax + 17000;
                    }

                }
                averageAge = averageAge + age;
                averageSalary = averageSalary + salary;


            }
            Console.WriteLine("The average age is: " + averageAge/(args.Length/2) + " years old.");
            Console.WriteLine("The average salary is: R" + averageSalary / (args.Length / 2));
            Console.WriteLine("The average tax is: R" + averageTax / (args.Length / 2));
            Console.WriteLine("Disclaimer: I could have easily included cents, but you are encouraged to round down to the nearest whole number when doing taxes.");
            Console.ReadLine();







        }
    }
}
