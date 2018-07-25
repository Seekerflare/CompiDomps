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
            Console.WriteLine("How old are you?: ");
            input1=(Console.ReadLine());
            int age;
            if (!int.TryParse(input1, out age)) 
            {
                Console.WriteLine("Input not a number!");
                return;
            }
            Console.WriteLine("How much do you earn?: ");
            string input2 = Console.ReadLine();
            int salary;
            if (!int.TryParse(input2, out salary)){
                Console.WriteLine("Input not a number!");
                return;
            }
            
            if(age < 65) {

                if (salary <= 4999)
                {
                    Console.WriteLine("The state is screwing you out of R0");
                    Console.ReadLine();
                }
                if (salary>=5000 && salary <=6499)
                {
                    Console.WriteLine("The state is screwing you out of R13");
                    Console.ReadLine();
                }
                if (salary >= 6500 && salary <= 7799)
                {
                    Console.WriteLine("The state is screwing you out of R250");
                    Console.ReadLine();
                }
                if (salary >= 7800 && salary <= 9999)
                {
                    Console.WriteLine("The state is screwing you out of R620");
                    Console.ReadLine();
                }

                if (salary >= 10000 && salary <= 13499)
                {
                    Console.WriteLine("The state is screwing you out of R1200");
                    Console.ReadLine();
                }
                if (salary >= 13500 && salary <= 17899)
                {
                    Console.WriteLine("The state is screwing you out of R2100");
                    Console.ReadLine();
                }
                if (salary >= 17900 && salary <= 19999)
                {
                    Console.WriteLine("The state is screwing you out of R2700");
                    Console.ReadLine();
                }
                if (salary >= 20000 && salary <=39999)
                {
                    Console.WriteLine("The state is screwing you out of R8000");
                    Console.ReadLine();
                }
                if (salary >= 40000 && salary <= 59999)
                {
                    Console.WriteLine("The state is screwing you out of R16000");
                    Console.ReadLine();
                }
                if (salary > 60000)
                {
                    Console.WriteLine("The state is screwing you out of R20000");
                    Console.ReadLine();
                }

            }    
                
            if (age>=65 && age<= 75)
            {
                if (salary <= 9999)
                {
                    Console.WriteLine("The state is screwing you out of R0");
                    Console.ReadLine();
                }
                
                if (salary >= 10000 && salary <= 13499)
                {
                    Console.WriteLine("The state is screwing you out of R600");
                    Console.ReadLine();
                }
                if (salary >= 13500 && salary <= 17899)
                {
                    Console.WriteLine("The state is screwing you out of R1500");
                    Console.ReadLine();
                }
                if (salary >= 17900 && salary <= 19999)
                {
                    Console.WriteLine("The state is screwing you out of R2000");
                    Console.ReadLine();
                }
                if (salary >= 20000 && salary <= 39999)
                {
                    Console.WriteLine("The state is screwing you out of R7500");
                    Console.ReadLine();
                }
                if (salary >= 40000 && salary <= 59999)
                {
                    Console.WriteLine("The state is screwing you out of R15600");
                    Console.ReadLine();
                }
                if (salary > 60000)
                {
                    Console.WriteLine("The state is screwing you out of R17050");
                    Console.ReadLine();
                }

            }
        if(age>75)
            {
                if (salary <= 9999)
                {
                    Console.WriteLine("The state is screwing you out of R0");
                    Console.ReadLine();
                }

                if (salary >= 10000 && salary <= 13499)
                {
                    Console.WriteLine("The state is screwing you out of R400");
                    Console.ReadLine();
                }
                if (salary >= 13500 && salary <= 17899)
                {
                    Console.WriteLine("The state is screwing you out of R1200");
                    Console.ReadLine();
                }
                if (salary >= 17900 && salary <= 19999)
                {
                    Console.WriteLine("The state is screwing you out of R1800");
                    Console.ReadLine();
                }
                if (salary >= 20000 && salary <= 39999)
                {
                    Console.WriteLine("The state is screwing you out of R7300");
                    Console.ReadLine();
                }
                if (salary >= 40000 && salary <= 59999)
                {
                    Console.WriteLine("The state is screwing you out of R15400");
                    Console.ReadLine();
                }
                if (salary > 60000)
                {
                    Console.WriteLine("The state is screwing you out of R17000");
                    Console.ReadLine();
                }

            }









        }
    }
}
