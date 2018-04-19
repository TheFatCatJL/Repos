using System;

namespace SimpleAssignment1
{
    class SA1
    {
        static void Main()
        {
            //Question 1 block

            Console.WriteLine("Jason");                        
            Console.WriteLine("E0284043@n.nus.edu");
            Console.WriteLine("");

            //Question 2 block

            Console.WriteLine("Please enter your name.");  
            string name = Console.ReadLine();
            Console.WriteLine($"Good Morning {name}");
            Console.WriteLine("");

            //Question 3 block

            Console.WriteLine("Please enter only integers >>>");
            string q3answer = Console.ReadLine();
            int number1 = int.Parse(q3answer);
            int numbersq = (int)Math.Pow(number1, 2);
            Console.WriteLine($"The square of {number1} is {numbersq}.\n");
            Console.WriteLine("");

            // Question 4 block

            Console.Write("Please enter any number >>>");
            string q4answer = Console.ReadLine();
            double number2 = double.Parse(q4answer);
            double numbersq2 = (double)Math.Pow(number2, 2);
            Console.WriteLine("The square of {0} is {1}.",number2 ,numbersq2);
            Console.WriteLine("");

            // Question 5 block

            Console.Write("Please enter any number >>>");
            string q5answer = Console.ReadLine();
            double number3 = double.Parse(q5answer);
            Console.WriteLine("The 2 decimal place format of {0} is {0:#,000.00}.", number3);
            Console.WriteLine("");

            //escape block
            Console.ReadKey();
            
        }
    }
}
