using System;


namespace Day5
{
    class Quiz
    {

        //array counter
        static int countintegerinarray(int[,] theArray, int input)
        {
            int i = 0, j = 0, count=0;
            for (i = 0; i < theArray.GetLength(0); i++)
            {
                for (j = 0; j < theArray.GetLength(1); j++)
                {
                    if (theArray[i, j] == input)
                    {
                        count = count + 1;
                    }
                }
            }
            i = 0;
            j = 0;
            Console.WriteLine();
            return count;
        }

        //userinput validation
        static int userinputvalidate()
        {
            int tries = 0;

            while (tries < 3)
            {
                Console.Write("Please enter a number (0-9): ");
                string inputstr = Console.ReadLine();
                if (int.TryParse(inputstr, out int a) == false)
                {
                    Console.WriteLine("Please enter a valid integer from 1 to 9 only.");
                    tries++;
                }
                else if (inputstr == "")
                {
                    Console.WriteLine("Please enter a valid integer from 1 to 9 only.");
                    tries++;
                }
                else
                {
                    int input = int.Parse(inputstr);
                    return input;
                }
            }
            if (tries > 2)
            {
                Console.WriteLine("Maximum tries exceeded.");
                return -1;
            }
            return -1;
        }

        //count result evaluator
        static void countresult(int count, int input)
        {
            if (count == 0)
            {
                Console.WriteLine($"There is no {input} in the array.");
                return;
            }
            else if (count > 0)
            {
                Console.WriteLine($"There are {count} of the number {input} in the array.");
                return;
            }
        }
        
      // randomgenerator
      static int[,] randomgenerator ()
        {
            Random randomnum = new Random();
            int[,] theArray = new int[9,2];
            int[,] failed = new int[1, 1];
            int i = 0, j = 0;
            Console.Write("Retry with random array? Press Y and enter. Any other key to exit. >>> ");
            string inputstr1 = Console.ReadLine();
            Console.WriteLine();
            if (inputstr1 == "Y" || inputstr1 == "y")
            {
                for (i = 0; i < theArray.GetLength(0); i++)
                {
                    for (j = 0; j < theArray.GetLength(1); j++)
                    {
                        theArray[i, j] = randomnum.Next(0, 10);
                    }
                    
                }
                i = 0;
                j = 0;
                
                return theArray;
            }
            else
            {
                Console.WriteLine("Have a nice day.");
                Console.ReadKey();
                return failed;
            }
       }

        //title generator
        static void dashgenerator(int repeater)
        {
            Console.WriteLine("Pop Quiz for Day 5");
            while (repeater < 50)
            {
                Console.Write("-");
                repeater++;
            }
            Console.WriteLine();
        }
        // main block
        static void Main()
        {
            int input =0;
            int[,] theArray = new[,]
            {
                {5,3 },{2,9 },{2,9 },
                {5,1 },{7,1},{8,3},
                {0,3 },{2,2 },{9,7 }
            };

            RepeatBlock:
            //call the interface
            dashgenerator(50);
           
            //call the question module
            input = userinputvalidate();
            if (input <0)
            {
                Console.ReadKey();
                Environment.Exit(0);
            }      
            // call the count and then the countresult module
            int count = 0;
            count = countintegerinarray(theArray, input);
            countresult(count , input);

            //Random generator
            theArray = randomgenerator();
            if (theArray.GetLength(0) < 2)
            {
                Environment.Exit(0);
            }
            else
            {
                goto RepeatBlock;
            }
        }
    }
}
