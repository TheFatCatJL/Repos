using System;

namespace FullAssignment1
{
    class FA1
    {
        static void Main()
        {
        //Introduction section
        introblock:
            Console.WriteLine("Welcome to SA-46 C# Day 1 Assignment.");
            Console.WriteLine("Please make an selection as per below:");
            Console.WriteLine("****************************************");
            Console.WriteLine("*Question 1 - Simple WriteLines        *");
            Console.WriteLine("*Question 2 - ReadLine                 *");
            Console.WriteLine("*Question 3 - Working with Integers    *");
            Console.WriteLine("*Question 4 - Manipulating Double      *");
            Console.WriteLine("*Question 5 - Formatting Decimals      *");
            Console.WriteLine("****************************************");
            Console.Write("Selection (Choose 1 to 5, or input any other keys to exit) >");
            string MainSectionSelect = Console.ReadLine();

            if (MainSectionSelect == "1")
            {
                goto block1;
            }
            else if (MainSectionSelect == "2")
            {
                goto block2;
            }
            else if (MainSectionSelect == "3")
            {
                goto block3;
            }
            else if (MainSectionSelect == "4")
            {
                goto block4;
            }
            else if (MainSectionSelect == "5")
            {
                goto block5;
            }
            else
            {
                goto earlyexit;
            }

        //Question 1 block

        block1:
            Console.WriteLine("");
            Console.WriteLine("Jason");
            Console.WriteLine("E0284043@n.nus.edu");
            Console.WriteLine("");
            goto repeatprompt;

        //Question 2 block

        block2:
            Console.WriteLine("");
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Good Morning {name}");
            Console.WriteLine("");
            goto repeatprompt;

        //Question 3 block

        block3:
            Console.WriteLine("");
            int retry = 0;
            tryloop:
            Console.WriteLine("Please enter only integers >>>");
            string q3answer = Console.ReadLine();
            try
            {
                int check1 = int.Parse(q3answer);
            }
            catch
            {
                Console.WriteLine("Please use only whole numbers. \tRetry now...");
                retry = retry + 1;
                if (retry <= 2)
                {
                    goto tryloop;
                }
                else
                {
                    Console.WriteLine("Exceeded number of tries.");
                    goto earlyexit;
                }
             }
            int number1 = int.Parse(q3answer);
            int numbersq = (int)Math.Pow(number1, 2);
            Console.WriteLine($"The square of {number1} is {numbersq}.\n");
            Console.WriteLine("");
            goto repeatprompt;

            // Question 4 block
            block4:
            Console.WriteLine("");
            int retry2 = 0;
            tryloop2:
            Console.Write("Please enter any number >>>");
            string q4answer = Console.ReadLine();
            try
            {
                double check2 = double.Parse(q4answer);
            }
            catch
            {
                Console.WriteLine("Please use only whole numbers. \tRetry now...");
                retry2 = retry2 + 1;
                if (retry2 <= 2)
                {
                    goto tryloop2;
                }
                else
                {
                    Console.WriteLine("Exceeded number of tries.");
                    goto earlyexit;
                }
            }
            double number2 = double.Parse(q4answer);
            double numbersq2 = (double)Math.Pow(number2, 2);
            Console.WriteLine("The square of {0} is {1}.",number2 ,numbersq2);
            Console.WriteLine("");
            goto repeatprompt;

        // Question 5 block

        block5:
            Console.WriteLine("");
            int retry3 = 0;
        tryloop3:
            Console.Write("Please enter any number >>>");
            string q5answer = Console.ReadLine();
            try
            {
                double testnumber3 = double.Parse(q5answer);
            }
            catch
            {
                Console.WriteLine("Please use only whole numbers. \tRetry now...");
                retry3 = retry3 + 1;
                if (retry3 <= 2)
                {
                    goto tryloop3;
                }
                else
                {
                    Console.WriteLine("Exceeded number of tries.");
                    goto earlyexit;
                }
            }
            double number3 = double.Parse(q5answer);
            Console.WriteLine("The 2 decimal place format of {0} is {0:###,###,###.00}.", number3);
            goto repeatprompt;


        // Repeat Prompt code
        repeatprompt:
            Console.WriteLine("");
            Console.WriteLine("Do you want to go back to main menu? (Y or any other keys to exit)");
            Console.Write(">>>");

            string RepeatSelect = Console.ReadLine();

            if (RepeatSelect == "Y")
            {
                Console.WriteLine("");
                goto introblock ;
                            }
            else if (RepeatSelect == "y")
            {
                Console.WriteLine("");
                goto introblock;
            }
            else
            {
                goto earlyexit;
            }

        // Escape handling
        earlyexit:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Have a nice day!");
            Console.ReadKey();
            
        }
    }
}
