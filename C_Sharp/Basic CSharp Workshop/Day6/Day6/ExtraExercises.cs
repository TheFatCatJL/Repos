using System;
using System.Threading;
using System.Text;
using System.Collections.Generic;

// YIRAWAN@NUS.EDU.SG
namespace Day6
{
    class Day6ExtraExercises
    {
        static void Main()
        {
            //Main starting menu
            int menuchecknum = 0;
            MenuBlock:
            Console.WriteLine();
            menuchecknum = menuselector(menuchecknum);
            switch (menuchecknum)
            {
                case 1:
                    AscendingNumberPrinting();
                    break;
                case 2:
                    DescendingNumberPrinting();
                    break;
                case 3:
                    OddNumberMain();
                    break;
                case 4:
                    FibonacciNumbers();
                    break;
                case 5:
                    AlternateNumbersMain();
                    break;
                case 6:
                    PrintingTree();
                    break;
                case 7:
                    PrintingInverseTree();
                    break;
                case 8:
                    PrintingNumberTree();
                    break;
                case 9:
                    PrintingNumberTree2();
                    break;
                case 10:
                    RandomDiceResult1();
                    break;
                case 11:
                    RandomDiceResult2();
                    break;
                case 12:
                    RandomDiceResult3();
                    break;
                case 13:
                    RandomDiceResult4();
                    break;
                case 14:
                    RandomDiceResult5();
                    break;
                case 15:
                    ArrayPositionFinderMain();
                    break;
                case 16:
                    ArrayDescendsortMain();
                    break;
                case 17:
                    ArrayDescendSortMainBinary();
                    break;
                case 18:
                    Array2DAverage();
                    break;
                case 19:
                    Array2DMaxValue();
                    break;
                case 20:
                    Array3Dto2DAverage();
                    break;
                case 21:
                    TrianglePrinting();
                    break;
                case 22:
                    ArrayResizerMain();
                    break;
                case 23:
                    NumberAssignment();
                    break;
                case 24:
                    VerificationProcess();
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Make another main menu selection? Press Y and enter. Any other input to exit.");
            char userrepeat = Console.ReadKey(true).KeyChar;
            Console.WriteLine();
            if (userrepeat == 'Y' || userrepeat == 'y')
            {
                goto MenuBlock;
            }
            else
            {
                Console.WriteLine("Have a nice day!");
                Console.ReadKey(true);
            }

        }
                
        //menu selector
        static int menuselector(int menuchecknum)
        {
            string menucheckstr = "";
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("********************************************************");
                Console.WriteLine("*Welcome to Assignment 6 selection page                *");
                Console.WriteLine("*Please choose an option below (only integers)         *");
                Console.WriteLine("********************************************************");
                Console.WriteLine("* 1. Assignment Question 1 - Ascending number          *");
                Console.WriteLine("* 2. Assignment Question 2 - Descending number         *");
                Console.WriteLine("* 3. Assignment Question 3 - Odd number printing       *");
                Console.WriteLine("* 4. Assignment Question 4 - Fibonacci Numbers         *");
                Console.WriteLine("* 5. Assignment Question 5 - Alternating Number Print  *");
                Console.WriteLine("* 6. Assignment Question 6 - Pattern tree printing     *");
                Console.WriteLine("* 7. Assignment Question 7 - Inverse pattern tree      *");
                Console.WriteLine("* 8. Assignment Question 8 - Number tree printing 1    *");
                Console.WriteLine("* 9. Assignment Question 9 - Number tree printing 2    *");
                Console.WriteLine("* 10. Assignment Question 10 - Random Dice 1           *");
                Console.WriteLine("* 11. Assignment Question 11 - 2 Dice (Same number)    *");
                Console.WriteLine("* 12. Assignment Question 12 - 1 Dice (Double strike)  *");
                Console.WriteLine("* 13. Assignment Question 13 - 1 Dice (Turkey)         *");
                Console.WriteLine("* 14. Assignment Question 14 - 1 follow by 2 dice      *");
                Console.WriteLine("* 15. Assignment Question 15 - Array Position Search   *");
                Console.WriteLine("* 16. Assignment Question 16 - Array descending sort   *");
                Console.WriteLine("* 17. Assignment Question 17 - Array sort and search   *");
                Console.WriteLine("* 18. Assignment Question 18 - 2D Array Average        *");
                Console.WriteLine("* 19. Assignment Question 19 - 2D Array Max Value      *");
                Console.WriteLine("* 20. Assignment Question 20 - 3D to 2D Averge value   *");
                Console.WriteLine("* 21. Assignment Question 21 - Triangle Printing       *");
                Console.WriteLine("* 22. Assignment Question 22 - Array Resizing          *");
                Console.WriteLine("* 23. Assignment Question 23 - Number Assigment        *");
                Console.WriteLine("* 24. Assignment Question 24 - Verification Process    *");
                Console.WriteLine("********************************************************");
                Console.Write(">>>");
                menucheckstr = Console.ReadLine();

                try
                {
                    int.Parse(menucheckstr);
                }
                catch
                {
                    Console.WriteLine("Please enter integers only!");
                    Console.WriteLine();
                    i = 0;
                }
                if (int.TryParse(menucheckstr, out int j) != false)
                {
                    if (int.Parse(menucheckstr) < 0 || int.Parse(menucheckstr) > 24)
                    {
                        Console.WriteLine("Please enter positive integers within the range (1 to 24) only!");
                        Console.WriteLine();
                        i = 0;
                    }

                }
            }
            menuchecknum = int.Parse(menucheckstr);
            return menuchecknum;
        }

        //VerificationMain

        static void VerificationProcess()
        {
            string password = "";
            bool result;
            int counter = 0;
            do
            {
                Console.WriteLine("Notice : Your Password must be more/equal 8 characters.");
                Console.WriteLine("Passwords must include at least 1 of each of the following:");
                Console.WriteLine("Number(0-9), lower (a-z) and upper case alphabets (A-Z), and special character (!@#$% etc).");
                Console.Write("Please enter your password >>> ");
                password = Console.ReadLine();
                Console.WriteLine();
                result = PasswordVerfication(password);
                Console.WriteLine();
                if (result == true)
                {
                    counter = 3;
                }
                counter++;
            } while (counter < 3);
            if (result == true)
            {
                Console.WriteLine("Welcome to your account.");
                counter = 0;
            }
            else
            {
                Console.WriteLine("Number of tries exceeded.");
                return;
            }
        }


        //Password Verfication
        static bool PasswordVerfication(string password)
        {
            int passwordlength = password.Length;
            int i = 0;
            bool lowercaseflag = false;
            bool uppercaseflag = false;
            bool numberflag = false;
            bool specialcharflag = false;
            char[] charArray = password.ToCharArray();

            int hardcodepwlength = 8;
            if (password.Length < hardcodepwlength)
            {
                Console.WriteLine("Your password must consist of 8 or more characters.");
                return false;
            }
            for (i = 0; i<passwordlength;i++)
            {
                if (charArray[i] == ' ')
                {
                    Console.WriteLine("Please do not include any spaces.");
                    return false;
                }
                else if (charArray[i] >= '0' && charArray[i] <='9')
                {
                    numberflag = true;
                }
                else if (charArray[i] >= 'a' && charArray[i] <= 'z')
                {
                    lowercaseflag = true;
                }
                else if (charArray[i] >= 'A' && charArray[i] <= 'Z')
                {
                    uppercaseflag = true;
                }
                else
                {
                    specialcharflag = true;
                }
            }
            Console.WriteLine();
            if(numberflag == false)
            {
                Console.WriteLine("Your password must contain at least 1 number.");
            }
            if (lowercaseflag == false)
            {
                Console.WriteLine("Your password must contain at least 1 lowercase letter.");
            }
            if (uppercaseflag == false)
            {
                Console.WriteLine("Your password must contain at least 1 uppercase letter.");
            }
            if (specialcharflag == false)
            {
                Console.WriteLine("Your password must contain at least 1 special character.");
            }

            if (lowercaseflag == true && uppercaseflag == true && specialcharflag == true & numberflag==true)
            {
                return true;
            }
            return false;
        }

        // Number Assignment Main()
        static void NumberAssignment()
        {
            string userinput1, userinput2;
            int a, b, bignum, Smallnum;
            Console.WriteLine("This is a program to assign two numbers.");

            do
            {
                Console.Write("Please enter the 1st integer >>> ");
                userinput1 = Console.ReadLine();
                Console.WriteLine();
            } while (int.TryParse(userinput1, out int y) == false);
            do
            {
                Console.Write("Please enter the 2nd integer >>> ");
                userinput2 = Console.ReadLine();
                Console.WriteLine();
            } while (int.TryParse(userinput2, out int z) == false);
            a = int.Parse(userinput1);
            b = int.Parse(userinput2);
            bignum = biggernum(a, b);
            Smallnum = smallernum(a, b);
            Console.WriteLine("Bigger number  (a): {0}",bignum);
            Console.WriteLine("Smaller number (b): {0}",Smallnum);
        }
        static int biggernum (int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static int smallernum(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            return a;
        }
        //Array Resize Main
        static void ArrayResizerMain()
        {
            int[,,] array3d = Array3DGenerator();
            int[,] array2d = Array2DGenerator();
            int[] array1d = new int[1];
            char keypress1 = '3';
            char keypress2 = '2';
            bool keypressflag1 = false;
            bool keypressflag2 = false;

            Console.WriteLine("This is a program to resize an array.");

            do
            {
                Console.WriteLine();
                Console.Write("Please enter the size of the array to be resized (Press the numeric 2 or 3 key).");
                keypress1 = Console.ReadKey(true).KeyChar;
                if (keypress1 == '3')
                {
                    keypressflag1 = true;
                }
                else if (keypress1 == '2')
                {
                    keypressflag1 = true;
                }
            } while (keypressflag1 == false);

            if (keypress1 == '3')
            {
                do
                {
                    Console.WriteLine();
                    Console.Write("Please enter the size of the new array size (Press the numeric 2 or 1 key).");
                    keypress2 = Console.ReadKey(true).KeyChar;
                    if (keypress2 == '2')
                    {
                        keypressflag2 = true;
                    }
                    else if (keypress2 == '1')
                    {
                        keypressflag2 = true;
                    }
                } while (keypressflag2 == false);
            }
            else
            {
                Console.WriteLine("Size of new array will be 1 by default.");
                keypress2 = '1';
            }

            if (keypress1 == '3')
            {
                if (keypress2 == '2')
                {
                    Console.WriteLine("Original 3D matrix:");
                    array3DPrinter(array3d);
                    array2d = arrayresizer3Dto2D(array3d);
                    Console.WriteLine("Resized to 2D matrix:");
                    array2DPrinter(array2d);
                }
                else
                {
                    Console.WriteLine("Original 3D matrix:");
                    array3DPrinter(array3d);
                    array2d = arrayresizer3Dto2D(array3d);
                    Console.WriteLine("Resized to 2D matrix:");
                    array2DPrinter(array2d);
                    array1d = arrayresizer2Dto1D(array2d);
                    Console.WriteLine("Resized finally to 1D matrix:");
                    array1DPrinter(array1d);
                }
            }
            else
            {
                Console.WriteLine("Original 2D matrix:");
                array2DPrinter(array2d);
                array1d = arrayresizer2Dto1D(array2d);
                Console.WriteLine("Resized to 1D matrix:");
                array1DPrinter(array1d);
            }
        }

        //Array printer 3D
        static void array3DPrinter(int[,,] array3d)
        {
            Console.WriteLine("{ ");
            for (int i = 0; i < array3d.GetLength(0); i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < array3d.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < array3d.GetLength(2); k++)
                    {
                        Console.Write(array3d[i, j, k]);
                        if (k != array3d.GetLength(2) - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.Write(" }");
                    if (j != array3d.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                    
                }
                Console.WriteLine(" }");
                Console.WriteLine();
            }
            Console.WriteLine("}\n");

        }

        //Array printer 2D
        static void array2DPrinter(int[,] array2d)
        {
            Console.Write("{ ");
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write(array2d[i, j]);
                    if (j != array2d.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write(" }");
                if (i != array2d.GetLength(0) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" }");
            Console.WriteLine("\n");
        }
        //Array printer 1D
        static void array1DPrinter(int[] array1d)
        {
            Console.Write("{ ");
            for (int i = 0; i < array1d.GetLength(0); i++)
            {
                Console.Write(array1d[i]);
                if (i != array1d.GetLength(0)-1)
                {
                    Console.Write(", ");
                }
                
            }
            Console.Write(" }");
            Console.WriteLine();
        }

        //Array Resizer (int[,,] to int[,])

        static int[,] arrayresizer3Dto2D(int[,,] array3d)
        {
            int[,] array2d = new int[array3d.GetLength(0), array3d.GetLength(1)];
            int temptotal = 0;
            for (int i = 0; i < array3d.GetLength(0); i++)
            {
                for (int j = 0; j < array3d.GetLength(1); j++)
                {
                    for (int k = 0; k < array3d.GetLength(2); k++)
                    {
                        temptotal = temptotal + array3d[i, j, k];                       
                    }
                    array2d[i, j] = temptotal / array3d.GetLength(2);
                }
            }
            return array2d;
        }

        //Array Resizer (int[,] to int[])
        static int[] arrayresizer2Dto1D(int[,] array2d)
        {
            int[] array1d = new int[array2d.GetLength(0)];
            int temptotal = 0;
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    temptotal = temptotal + array2d[i, j];
                }
                array1d[i] = temptotal / array2d.GetLength(1);

            }
            return array1d;
        }

        // Triangle Printing
        static void TrianglePrinting()
        {
            Console.WriteLine("This program is to print a pattern tree.");
            char userinput = '1';
            string userinput2 = "";
            do
            {
                Console.WriteLine("Please choose an option below:");
                Console.WriteLine("1. Left tree pattern");
                Console.WriteLine("2. Right tree pattern");
                Console.WriteLine("3. Centre tree pattern");
                Console.WriteLine("4. All Normal trees");
                Console.WriteLine("5. Inverse Left tree pattern");
                Console.WriteLine("6. Inverse Right tree pattern");
                Console.WriteLine("7. Inverse Centre tree pattern");
                Console.WriteLine("8. All Inverse Trees");
                Console.WriteLine("9. All of them at once");
                Console.Write("Please press only keys 1 to 9 >>>");
                userinput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userinput < '0' && userinput > '9');

            do
            {
                do
                {
                    Console.Write("Please enter the height of the tree (only positive integers more than 3 and less than 12) >>> ");
                    userinput2 = Console.ReadLine();
                    Console.WriteLine();
                } while (int.TryParse(userinput2, out int a) == false);
            } while (int.Parse(userinput2) < 2 || int.Parse(userinput2) > 12);


            int treesize = int.Parse(userinput2);
            string[] normaltreearray = treegenerator(treesize, 1);
            string[] inversetreearray = treegenerator(treesize, 2);
            string[] normaltreearraycenter = treegenerator(treesize, 3);
            string[] inversetreearraycenter = treegenerator(treesize, 4);
            int i = 0, num =0;
            //Trees selection
            switch (userinput)
            {
                case '1':
                    //left pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        Console.WriteLine(normaltreearray[i]);
                    }
                    break;
                case '2':
                    //right pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        Console.WriteLine(String.Format("{0,115}", normaltreearray[i]));
                    }
                    break;
                case '3':
                    //centre pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        while (num < 57 - i)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.WriteLine(normaltreearraycenter[i]);
                    }
                    break;
                case '4':
                    // all at once
                    for (i = 0; i < treesize; i++)
                    {
                        Console.Write(normaltreearray[i]);
                        while (num < 50 - i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(normaltreearraycenter[i]);

                        while (num < 50 - i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(normaltreearray[i]);
                        
                        Console.WriteLine();
                    }
                    break;
                case '5':
                    //left pattern tree inverse
                    for (i = 0; i < treesize; i++)
                    {
                        Console.WriteLine(inversetreearray[i]);
                    }
                    break;
                case '6':
                    //right pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        Console.WriteLine(String.Format("{0,115}", inversetreearray[i]));
                    }
                    break;
                case '7':
                    //centre pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        while (num < 47 + i)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.WriteLine(inversetreearraycenter[i]);
                    }
                    break;
                case '8':
                    // all at once

                    for (i = 0; i < treesize; i++)
                    {
                        Console.Write(inversetreearray[i]);

                        while (num < 40 + i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(inversetreearraycenter[i]);
                        while (num < 40 + i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(inversetreearray[i]);

                        Console.WriteLine();
                    }
                    break;
                case '9':
                    // all at once -final
                    for (i = 0; i < treesize; i++)
                    {
                        Console.Write(normaltreearray[i]);
                        while (num < 56 - i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(normaltreearraycenter[i]);

                        while (num < 56 - i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(normaltreearray[i]);

                        Console.WriteLine();
                    }
                    for (i = 0; i < treesize; i++)
                    {
                        Console.Write(inversetreearray[i]);

                        while (num < 46 + i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(inversetreearraycenter[i]);
                        while (num < 46 + i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(inversetreearray[i]);

                        Console.WriteLine();
                    }
                    break;

                default:
                    break;
            }


        }

        //Tree generator
        static string[] treegenerator(int treesize, int treetype)
        {
            string[] newarray = new string[treesize];
            string stringtemp = "";
            if (treetype == 1)
            {
                // upright tree normal
                for (int i =0; i < treesize; i++)
                {
                    for (int j = 0; j < i+1; j++)
                    {
                        stringtemp = stringtemp + "*";                        
                    }
                    newarray[i] = stringtemp;
                    stringtemp = "";
                }
                return newarray;
            }
            else if (treetype == 2)
            {
                // inverse tree
                for (int i = 0; i < treesize; i++)
                {
                    for (int j = i; j < treesize; j++)
                    {
                        stringtemp = stringtemp + "*";
                    }
                    newarray[i] = stringtemp;
                    stringtemp = "";
                }
                return newarray;
            }
            else if (treetype == 3)
            {
                // upright tree normal +2
                for (int i = 0; i < treesize; i++)
                {
                    if (i != 0)
                    {
                        for (int j = 0; j < i+i+1; j++)
                        {
                            stringtemp = stringtemp + "*";
                        }
                    }
                    else
                    {
                        for (int j = 0; j < i+1; j++)
                        {
                            stringtemp = stringtemp + "*";
                        }
                    }
                    
                    newarray[i] = stringtemp;
                    stringtemp = "";
                }
                return newarray;
            }
            else if (treetype == 4)
            {
                // inverse tree + 2
                for (int i = 0; i < treesize; i++)
                {
                    if (i < treesize)
                    {
                        for (int j = 0; j < (treesize-i)*2-1; j++)
                        {
                            stringtemp = stringtemp + "*";
                        }
                    }
                    else
                    {
                        for (int j = i; j < treesize; j++)
                        {
                            stringtemp = stringtemp + "*";
                        }
                    }
                    newarray[i] = stringtemp;
                    stringtemp = "";
                }
                return newarray;
            }
            return newarray;
        }

        //3D to 2D Average
        static void Array3Dto2DAverage()
        {
            int[,,] Array1 = new int[1, 1,1];
            Array1 = Array3DGenerator();

            int n1 = Array1.GetLength(0);
            int n2 = Array1.GetLength(1);
            int[,] arr2 = new int[n1, n2];
            int temptotal = 0;

            for (int i = 0; i < Array1.GetLength(0); i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < Array1.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k<Array1.GetLength(2);k++)
                    {
                        Console.Write(Array1[i, j,k]);
                        arr2[i, j] = arr2[i, j] + Array1[i, j, k];
                        if (k != Array1.GetLength(2) - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.Write(" }");
                }
                Console.Write(" }");
                Console.WriteLine();
            }

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    Console.Write(arr2[i, j]);
                    temptotal = temptotal + arr2[i, j];
                    Console.Write(" }");
                    if (j != arr2.GetLength(1) - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write(" }\t");
                temptotal = temptotal / 4;
                Console.Write($"Average of the row = {temptotal}");
                temptotal = 0;
                Console.WriteLine();
            }


        }
        //3D Array Generator
        static int[,,] Array3DGenerator()
        {
            Random randomnumbergen = new Random();
            int Rand1 = randomnumbergen.Next(3, 6);
            int Rand2 = randomnumbergen.Next(3, 6);
            int Rand3 = randomnumbergen.Next(3, 6);
            int i = 0, j = 0, k= 0;

            int[,,] Array3D = new int[Rand1, Rand2,Rand3];

            for (i = 0; i < Array3D.GetLength(0); i++)
            {
                for (j = 0; j < Array3D.GetLength(1); j++)
                {
                    for (k = 0; k < Array3D.GetLength(2); k++)
                    {
                        Array3D[i, j, k] = randomnumbergen.Next(1, 10);
                    }
                }
            }
            return Array3D;
        }
        
        //2D Array Max Value
        static void Array2DMaxValue()
        {
            int[,] Array1 = new int[1, 1];
            int temptotal = 0;
            Array1 = Array2DGenerator();

            for (int i = 0; i < Array1.GetLength(0); i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < Array1.GetLength(1); j++)
                {

                    Console.Write(Array1[i, j]);
                    if (Array1[i, j] > temptotal)
                    {
                        temptotal = Array1[i, j];
                    }
                    if (j != Array1.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                        Console.Write("\t");
                    }
                }
                Console.Write(" }\t");
                Console.Write($"Max Value = {temptotal}");
                temptotal = 0;
                Console.WriteLine();
            }
        }
        //2D Array average
        static void Array2DAverage()
        {
            int[,] Array1 = new int[1, 1];
            int temptotal = 0; 
            Array1 = Array2DGenerator();

            for (int i = 0; i < Array1.GetLength(0); i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < Array1.GetLength(1); j++)
                {

                    Console.Write(Array1[i, j]);
                    temptotal = temptotal + Array1[i, j];
                    if (j != Array1.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                        Console.Write("\t");
                    }
                }
                Console.Write(" }\t");
                Console.Write($"Average = {temptotal/Array1.GetLength(1)}");
                temptotal = 0;
                Console.WriteLine();
            }
        }
        //2D Array Generator
        static int[,] Array2DGenerator()
        {
            Random randomnumbergen = new Random();
            int Rand1 = randomnumbergen.Next(2, 8);
            int Rand2 = randomnumbergen.Next(2, 8);
            int j = 0;

            int[,] Array2D = new int[Rand1,Rand2];
        
                for (int i = 0; i<Array2D.GetLength(0); i++)
                {
                    for (j =0; j <Array2D.GetLength(1);j++)
                    {
                        Array2D[i, j] = randomnumbergen.Next(1, 25);
                    }
                }
            return Array2D;
        }

        //Array Descend and sort using Binary
        static void ArrayDescendSortMainBinary()
        {
            Console.WriteLine("This is a program to search for an integer in a randomly generated integer array sorted descendingly.");

            //Random numbers question
            int[] arr = new int[1];
            int[] arr2 = new int[1];
            string userinput = "";
            int searchnum = 0;
            int counter1 = 0;
            char userretry = 'y';
            bool searchflag = false;
            bool[] positions = new bool[150];

            do
            {
                arr = singleIntArrayValues(true);
                arr2 = singleIntArrayGenerator(arr[0], arr[1], arr[2]);
                arr2 = singleIntArraySorter(arr2, 1);

                do
                {
                    do
                    {
                        Console.Write("Please enter the integer for array position search. (Between -50 to 100)");
                        userinput = Console.ReadLine();
                        Console.WriteLine();
                    }
                    while (int.TryParse(userinput, out int a) == false);
                    searchnum = int.Parse(userinput);
                } while (searchnum < -50 || searchnum > 100);

                for (int y = 0; y < arr2.Length; y++)
                {
                    if (searchnum == arr2[y])
                    {
                        searchflag = true;
                        positions[y] = true;
                    }
                }
                if (searchflag == true)
                {
                    for (int y = 0; y < positions.Length; y++)
                    {
                        if (positions[y] == true)
                        {
                            Console.WriteLine($"At Position {y}, {searchnum} is found.");
                            counter1++;
                        }
                    }
                    Console.WriteLine($"{searchnum} is found a total of {counter1} times.");
                }
                else
                {
                    Console.WriteLine($"{searchnum} is not found in the array.");

                }

                //note binary search cannot be perform on a non sorted array and must be ascending.
                //int indexpole = Array.BinarySearch(arr2, searchnum);
                //Console.WriteLine(indexpole);
                
                counter1 = 0;
                searchnum = 0;
                positions = new bool[150];
                searchflag = false;

                Console.WriteLine();
                Console.WriteLine("Array as follows:");
                Console.Write("( ");
                Console.Write(String.Join(" , ", arr2));
                Console.Write(" )");
                Console.WriteLine("\n");
                Console.Write("Retry? Press Y for yes. Any other input to exit >>> ");
                userretry = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            } while (userretry == 'y' || userretry == 'Y');
        }
        
        //Array Descending sort
        static void ArrayDescendsortMain()
        {
            Console.WriteLine("This is a program to sort a random integer array.");

            int[] arr = new int[1];
            int[] arr2 = new int[1];
            char userretry = 'y';
            
            do
            {
                arr = singleIntArrayValues(true);
                arr2 = singleIntArrayGenerator(arr[0], arr[1], arr[2]);
                arr2 = singleIntArraySorter(arr2, 2);

                Console.WriteLine();
                Console.WriteLine("Array as follows:");
                Console.Write("( ");
                Console.Write(String.Join(" , ", arr2));
                Console.Write(" )");
                Console.WriteLine("\n");
                Console.Write("Retry? Press Y for yes. Any other input to exit >>> ");
                userretry = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            } while (userretry == 'y' || userretry == 'Y');
        }
        
        //Array Position FInder
        static void ArrayPositionFinderMain()
        {
            Console.WriteLine("This is a program to search for an integer in a randomly generated integer array.");

            //Random numbers question
            int[] arr = new int[1];
            int[] arr2 = new int[1];
            string userinput = "";
            int searchnum = 0;
            int counter1 = 0;
            char userretry = 'y';
            bool searchflag = false;
            bool[] positions = new bool[150];

            do
            {
                arr = singleIntArrayValues(true);
                arr2 = singleIntArrayGenerator(arr[0], arr[1], arr[2]);
                arr2 = singleIntArraySorter(arr2, 0);

                do
                {
                    do
                    {
                        Console.Write("Please enter the integer for array position search. (Between -50 to 100)");
                        userinput = Console.ReadLine();
                        Console.WriteLine();
                    }
                    while (int.TryParse(userinput, out int a) == false);
                    searchnum = int.Parse(userinput);
                } while (searchnum < -50 || searchnum > 100);

                for (int y = 0; y < arr2.Length; y++)
                {
                    if (searchnum == arr2[y])
                    {
                        searchflag = true;
                        positions[y] = true;
                    }
                }
                if (searchflag == true)
                {
                    for (int y = 0; y < positions.Length; y++)
                    {
                        if (positions[y] == true)
                        {
                            Console.WriteLine($"At Position {y}, {searchnum} is found.");
                            counter1++;
                        }
                    }
                    Console.WriteLine($"{searchnum} is found a total of {counter1} times.");
                }
                else
                {
                    Console.WriteLine($"{searchnum} is not found in the array.");

                }
                counter1 = 0;
                Console.WriteLine();
                Console.WriteLine("Array as follows:");
                Console.Write("( ");
                Console.Write(String.Join(" , ", arr2));
                Console.Write(" )");
                Console.WriteLine("\n");
                Console.Write("Retry? Press Y for yes. Any other input to exit >>> ");
                userretry = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            } while (userretry == 'y' || userretry == 'Y');
        }
        
        // Dice throw - 1 follow by 2
        static void RandomDiceResult5()
        {
            int throwresult = 0;
            int throwresultHistory = 0;
            int counter = 0;
            char userrepeat = 'y';
            Console.WriteLine("This is a program to find out how many throws of a die will result in a 1 followed by 2.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

            do
            {
                Console.WriteLine($"Generating throws...");
                Thread.Sleep(2000);

                Random randomnumgen = new Random();
                do
                {
                    do
                    {
                        counter++;
                        throwresult = randomnumgen.Next(1, 7);
                        Console.WriteLine($"Throw result {counter}: {throwresult}");
                        throwresultHistory = throwresult;
                    }
                    while (throwresult != 1);
                    counter++;
                    throwresult = randomnumgen.Next(1, 7);
                    Console.WriteLine($"Throw result {counter}: {throwresult}");
                    
                } while (throwresult != throwresultHistory+1);
                Console.WriteLine();
                if (counter == 1)
                {
                    Console.WriteLine($"Throwing a 1 and then followed by 2 is acheived after {counter} throw");
                }
                else
                {
                    Console.WriteLine($"Throwing a 1 and then followed by 2 is acheived after {counter} throws");
                }
                Console.WriteLine("Repeat the test? Press y if yes. Any other key to exit.");
                userrepeat = Console.ReadKey(true).KeyChar;
                if (userrepeat != 'y' && userrepeat != 'Y')
                {
                    return;
                }
                counter = 0;
                throwresultHistory = 0;
                throwresult = 0;
                Console.WriteLine();
            } while (userrepeat == 'y' || userrepeat == 'Y');
        }
        // Dice throw - Turkey
        static void RandomDiceResult4()
        {
            int throwresult = 0;
            int throwresultHistory = 0;
            int throwresultHistory2 = 0;
            int counter = 0;
            bool turkeyflag = false;
            
            char userrepeat = 'y';
            Console.WriteLine("This is a program to find out how many throws of a die is required to achieve a turkey.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

            do
            {
                Console.WriteLine($"Generating throws...");
                Thread.Sleep(2000);
                Random randomnumgen = new Random();
                do
                {
                    do
                    {
                        counter++;
                        throwresult = randomnumgen.Next(1, 7);
                        Console.WriteLine($"Throw result {counter}: {throwresult}");
                        throwresultHistory2 = throwresult;
                        counter++;
                        throwresult = randomnumgen.Next(1, 7);
                        Console.WriteLine($"Throw result {counter}: {throwresult}");
                        throwresultHistory = throwresult;
                    }
                    while (throwresult != throwresultHistory);
                    counter++;
                    throwresult = randomnumgen.Next(1, 7);
                    Console.WriteLine($"Throw result {counter}: {throwresult}");
                    if (throwresult == throwresultHistory && throwresult == throwresultHistory2)
                    {
                        turkeyflag = true;
                    }
                }
                while (turkeyflag == false);
                Console.WriteLine();
                Console.WriteLine($"Turkey - 2 dices having same result thrice in a row is acheived after {counter} throws");
                Console.WriteLine("Repeat the test? Press y if yes. Any other key to exit.");
                userrepeat = Console.ReadKey(true).KeyChar;
                if (userrepeat != 'y' && userrepeat != 'Y')
                {
                    return;
                }
                counter = 0;
                throwresultHistory = 0;
                throwresultHistory2 = 0;
                throwresult = 0;
                turkeyflag = false;
                Console.WriteLine();
            } while (userrepeat == 'y' || userrepeat == 'Y');
        }
        
        // Dice throw - Double strike
        static void RandomDiceResult3()
        {
            int throwresult = 0;
            int throwresultHistory = 0;
            int counter = 0;
            char userrepeat = 'y';
            Console.WriteLine("This is a program to find out how many throws of a die is required to get two identical outcome in a row.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

            do
            {
                Console.WriteLine($"Generating throws...");
                Thread.Sleep(2000);

                Random randomnumgen = new Random();
                do
                {
                    counter++;
                    throwresult = randomnumgen.Next(1, 7);
                    Console.WriteLine($"Throw result {counter}: {throwresult}");
                    throwresultHistory = throwresult;
                    counter++;
                    throwresult = randomnumgen.Next(1, 7);
                    Console.WriteLine($"Throw result {counter}: {throwresult}");
                }
                while (throwresult != throwresultHistory);
                Console.WriteLine();
                if (counter == 1)
                {
                    Console.WriteLine($"Double strike - 2 dices having same result twice in a row is acheived after {counter} try");
                }
                else
                {
                    Console.WriteLine($"Double strike - 2 dices having same result twice in a row is acheived after {counter} tries");
                }
                Console.WriteLine("Repeat the test? Press y if yes. Any other key to exit.");
                userrepeat = Console.ReadKey(true).KeyChar;
                if (userrepeat != 'y' && userrepeat != 'Y')
                {
                    return;
                }
                counter = 0;
                throwresultHistory = 0;
                throwresult = 0;
                Console.WriteLine();
            } while (userrepeat == 'y' || userrepeat == 'Y');
        }

        //Random dice throw - 2 dice - Same number
        static void RandomDiceResult2()
        {
            int throwresult1 = 0;
            int throwresult2 = 0;
            int counter = 0;
            char userrepeat = 'y';
            Console.WriteLine("This is a program to find out how many throws of 2 dice is required to make 2 dice having equal result like two 6s.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

            do
            {
                Console.WriteLine($"Generating throws...");
                Thread.Sleep(2000);

                Random randomnumgen = new Random();
                do
                {
                    counter++;
                    throwresult1 = randomnumgen.Next(1, 7);
                    throwresult2 = randomnumgen.Next(1, 7);
                    Console.WriteLine($"Throw result {counter}: {throwresult1} {throwresult2}");
                }
                while (throwresult1 != throwresult2);
                Console.WriteLine();
                if (counter == 1)
                {
                    Console.WriteLine($"The two dice have equal outcomes after {counter} try");
                }
                else
                {
                    Console.WriteLine($"The two dice have equal outcomes after {counter} tries");
                }
                Console.WriteLine("Repeat the test? Press y if yes. Any other key to exit.");
                userrepeat = Console.ReadKey(true).KeyChar;
                if (userrepeat != 'y' && userrepeat != 'Y')
                {
                    return;
                }                
                counter = 0;
                Console.WriteLine();
            } while (userrepeat == 'y' || userrepeat == 'Y');
        }

        //Random dice throw - 1 die
        static void RandomDiceResult1()
        {
            int presetdicenum = 6;
            int throwresult = 0;
            int counter = 0;
            char userrepeat = 'y';
            string usernum = "";
            Console.WriteLine("This is a program to find out how many throws of a die is required to reach a predetermined result.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

            do
            {
                Console.WriteLine($"Generating throws...the desired die number is {presetdicenum}");
                Thread.Sleep(2000);

                Random randomnumgen = new Random();
                do
                {
                    counter++;
                    throwresult = randomnumgen.Next(1, 7);
                    Console.WriteLine($"Throw result {counter}: {throwresult}");
                }
                while (throwresult != presetdicenum);
                Console.WriteLine();
                if (counter == 1)
                {
                    Console.WriteLine($"{presetdicenum} is acheived after {counter} try");
                }
                else
                {
                    Console.WriteLine($"{presetdicenum} is acheived after {counter} tries");
                }
                Console.WriteLine("Repeat the test with a new pre-determined number?Press y if yes. Any other key to exit.");
                userrepeat = Console.ReadKey(true).KeyChar;
                if (userrepeat != 'y' && userrepeat != 'Y')
                {
                    return;
                }
                do
                {
                    do
                    {
                        Console.Write("Please enter any number from 1 to 6 >>> ");
                        usernum = Console.ReadLine();
                    } while (int.TryParse(usernum, out int a) == false);
                } while (int.Parse(usernum) < 0 || int.Parse(usernum) > 6);
                presetdicenum = int.Parse(usernum);
                counter = 0;
                Console.WriteLine();
            } while (userrepeat == 'y' || userrepeat == 'Y');
        }

        //Printing number tree 2        
        static void PrintingNumberTree2()
        {
            int limit = 6, counter = 0;
            char keypress = 'y';
            string userinput = "";
            do
            {
                Console.WriteLine("This program is to print a number tree.");
                for (int i = 0; i < limit; i++)
                {
                    for (int j = 1; j < i + 1; j++)
                    {
                        counter++;
                        Console.Write(counter);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Extend the tree? Press Y if yes. Any other key to exit.");
                keypress = Console.ReadKey(true).KeyChar;
                do
                {
                    do
                    {
                        Console.WriteLine("Enter the number of lines you want the number tree to extend (0 up to 30) >>> ");
                        userinput = Console.ReadLine();
                    }
                    while (int.TryParse(userinput, out int a) == false);
                } while (int.Parse(userinput) < 0 && int.Parse(userinput) > 30);
                limit = int.Parse(userinput);
                counter = 0;
            } while (keypress == 'y' || keypress == 'Y');
        }

        //Printing number tree
        static void PrintingNumberTree()
        {
            int limit = 6;
            char keypress = 'y';
            string userinput = "";
            do
            {
                Console.WriteLine("This program is to print a number tree.");
                for (int i = 0; i < limit; i++)
                {
                    for (int j = 1; j < i + 1; j++)
                    {
                        Console.Write(j);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Extend the tree? Press Y if yes. Any other key to exit.");
                keypress = Console.ReadKey(true).KeyChar;
                do
                {
                    do
                    {
                        Console.WriteLine("Enter the number of lines you want the number tree to extend (0 up to 40) >>> ");
                        userinput = Console.ReadLine();
                    }
                    while (int.TryParse(userinput, out int a) == false);
                } while (int.Parse(userinput) < 0 && int.Parse(userinput) > 40);
                limit = int.Parse(userinput);
            } while (keypress == 'y' || keypress == 'Y');
        }

        //Printing Inverse tree
        static void PrintingInverseTree()
        {
            Console.WriteLine("This program is to print a inversed pattern tree.");
            string userinput = "";
            do
            {
                do
                {
                    Console.WriteLine("Please choose an option below:");
                    Console.WriteLine("1. Left tree pattern");
                    Console.WriteLine("2. Right tree pattern");
                    Console.WriteLine("3. Centre tree pattern");
                    Console.WriteLine("4. All at once");
                    Console.Write("Please choose key only 1, 2, 3 or 4 >>>");
                    userinput = Console.ReadLine();
                } while (int.TryParse(userinput, out int a) == false);
            } while (int.Parse(userinput) < 0 && int.Parse(userinput) > 4);

            string[] treearray = new string[] { "******", "*****", "****", "***", "**", "*" };
            string[] treearray2 = new string[] { "***********", "*********", "*******", "*****", "***", "*" };
            int treesize = treearray.Length;
            int i;
            int num = 0;
            int userchoice = int.Parse(userinput);
            switch (userchoice)
            {
                case 1:
                    //left pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        Console.WriteLine(treearray[i]);
                    }
                    break;
                case 2:
                    //right pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        Console.WriteLine(String.Format("{0,115}", treearray[i]));
                    }
                    break;
                case 3:
                    //centre pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        while (num < 47 + i)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.WriteLine(treearray2[i]);
                    }
                    break;
                case 4:
                    // all at once
                    for (i = 0; i < treesize; i++)
                    {
                        Console.Write(treearray[i]);

                        while (num < 45 + i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(treearray2[i]);
                        while (num < 45 + i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(treearray[i]);

                        Console.WriteLine();
                    }
                    break;
            }


        }
        
        //Printing tree
        static void PrintingTree()
        {
            Console.WriteLine("This program is to print a pattern tree.");
            string userinput = "";
            do
            {
                do
                {
                    Console.WriteLine("Please choose an option below:");
                    Console.WriteLine("1. Left tree pattern");
                    Console.WriteLine("2. Right tree pattern");
                    Console.WriteLine("3. Centre tree pattern");
                    Console.WriteLine("4. All at once");
                    Console.Write("Please choose key only 1, 2, 3 or 4 >>>");
                    userinput = Console.ReadLine();
                } while (int.TryParse(userinput, out int a) == false);
            } while (int.Parse(userinput) < 0 && int.Parse(userinput) > 4);

            string[] treearray = new string[] { "*", "**", "***", "****", "*****", "******" };
            string[] treearray2 = new string[] { "*", "***", "*****", "*******", "*********", "***********" };
            int treesize = treearray.Length;
            int i;
            int num = 0;
            int userchoice = int.Parse(userinput);
            switch (userchoice)
            {
                case 1:
                    //left pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        Console.WriteLine(treearray[i]);
                    }
                    break;
                case 2:
                    //right pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        Console.WriteLine(String.Format("{0,115}", treearray[i]));
                    }
                    break;
                case 3:
                    //centre pattern tree
                    for (i = 0; i < treesize; i++)
                    {
                        while (num < 57 - i)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.WriteLine(treearray2[i]);
                    }
                    break;
                case 4:
                    // all at once
                    for (i = 0; i < treesize; i++)
                    {
                        Console.Write(treearray[i]);

                        while (num < 56 - i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(treearray2[i]);
                        while (num < 56 - i * 2)
                        {
                            Console.Write(" ");
                            num++;
                        }
                        num = 0;
                        Console.Write(treearray[i]);

                        Console.WriteLine();
                    }
                    break;
            }
            
                   
        } 
            
        // Alternate numbers print
        static void AlternateNumbersMain()
        {
            int initial = 1;
            int limit = 20;
            int initialcount = initial;
            int limitcount = limit;
            int[] alternatenumarray = new int[limit];
            for (int i= 0; i < limit; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    alternatenumarray[i] = initialcount;
                    initialcount++;
                }
                else
                {
                    alternatenumarray[i] = limitcount;
                    limitcount--;
                }
            }
            Console.WriteLine("This is a program to print alternate numbers from 1 to 20.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Thread.Sleep(2000);

            Console.WriteLine($"Alternate numbers between {initial} to {limit}.");
            Console.Write("( ");
            for (int i = 0; i < limit; i++)
            {
                Console.Write(alternatenumarray[i]);
                if (i != limit-1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" )");
            Console.WriteLine("\n");
            
            Console.Write("Repeat with another range of numbers? Press Y if yes. Other input to exit >>> ");
            string userinput = Console.ReadLine();
            string userinput2, userinput3;
            Console.WriteLine();
            if (userinput == "Y" || userinput == "y")
            {
                do
                {
                    Console.Write("Please enter the lower limit numer >>> ");
                    userinput2 = Console.ReadLine();
                    Console.WriteLine();
                }
                while (int.TryParse(userinput2, out int a) == false);

                do
                {
                    do
                    {
                        Console.Write("Please enter the upper limit number (at least 1 greater than lower limit) >>> ");
                        userinput3 = Console.ReadLine();
                        Console.WriteLine();
                    }
                    while (int.TryParse(userinput3, out int a) == false);
                }
                while (int.Parse(userinput2) > int.Parse(userinput3));
            }
            else
            {
                return;
            }
            int num = int.Parse(userinput2);
            int num2 = int.Parse(userinput3);
            int limit2 = num2-num +1;
            int initial2 = num;
            int initial2count = num;
            int limit2count = num2;
            int[] alternatenumarray2 = new int[limit2];
            for (int i = 0; i < limit2; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    alternatenumarray2[i] = initial2count;
                    initial2count++;
                }
                else
                {
                    alternatenumarray2[i] = limit2count;
                    limit2count--;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine($"Alternate numbers between {num} to {num2}.");
            Console.Write("( ");
            for (int i = 0; i < limit2; i++)
            {
                Console.Write(alternatenumarray2[i]);
                if (i != limit2 - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" )");
            Console.WriteLine("\n");
        }
        
        //FibonacciNumbers Main()
        static void FibonacciNumbers()
        {
            int[] fiboArray = new int[25];
            fiboArray[0] = 0;
            fiboArray[1] = 1;
            fiboArray[2] = 1;
            for (int i = 3; i<25; i++)
            {
                fiboArray[i] = fiboArray[i - 1] + fiboArray[i - 2];
            }
            Console.WriteLine("This is a program to print the 12 first Fibonacci numbers.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Thread.Sleep(2000);

            Console.WriteLine("The 12 first Fibonacci numbers.");
            Console.Write("( ");
            for (int i = 0; i < 12; i++)
            {
                Console.Write(fiboArray[i]);
                if (i != 11)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" )");
            Console.WriteLine("\n");

            Console.Write("Repeat with another range of numbers? Press Y if yes. Other input to exit >>> ");
            string userinput = Console.ReadLine();
            string userinput2;
            Console.WriteLine();
            if (userinput == "Y" || userinput == "y")
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Please enter the number of Fibonacci numbers to return (Positive integer not less than 3 and not more than 25) >>> ");
                        userinput2 = Console.ReadLine();
                    }
                    while (int.TryParse(userinput2, out int a) == false);
                }
                while (int.Parse(userinput2) > 25 && int.Parse(userinput2) < 4);
            }
            else
            {
                return;
            }
            int num = int.Parse(userinput2);
            Console.WriteLine($"The first {num} Fibonacci numbers.");
            Console.Write("( ");
            for (int i = 0; i < num; i++)
            {
                Console.Write(fiboArray[i]);
                if (i != num-1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" )");
            Console.WriteLine("\n");
            
        }
        // Odd Number Printing Main()
        static void OddNumberMain()
        {
            Console.WriteLine("This is a program to print the odd numbers from 1 to 20");
            Console.WriteLine("Please press any key to continue...");

            Console.WriteLine();
            Console.WriteLine("Odd numbers from 1 to 20 using loop method.");
            Console.WriteLine("Numbers from 1 to 20 are divided by 2 using integer division.");
            Console.WriteLine("Since integer division will truncate the 0.5 value,");
            Console.WriteLine("a multiplication of the divided value will yield a different value from the original.");

            int initial = 1;
            int limit = 20;

            Console.Write("3a. ( ");
            for (int i= initial; i<=limit; i++)
            {
                if (i / 2 * 2 != i)
                {
                    Console.Write(i);
                    if (i != limit - 1 && i!=limit)
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.Write(" )");
            Console.WriteLine();

            //using % operand
            Console.Write("3b. ( ");
            for (int i = initial; i <= limit; i++)
            {
                if (i % 2!= 0)
                {
                    Console.Write(i);
                    if (i != limit - 1 && i != limit)
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.Write(" )");
            Console.WriteLine();

            Console.Write("Repeat with another range of numbers? Press Y if yes. Other input to exit >>> ");
            string userinput = Console.ReadLine();
            string userinput2, userinput3;
            Console.WriteLine();
            if (userinput == "Y" || userinput == "y")
            {
                do
                {
                    Console.Write("Please enter the 1st integer >>> ");
                    userinput2 = Console.ReadLine();
                }
                while (int.TryParse(userinput2, out int a) == false);
                do
                {
                    Console.Write("Please enter the 2nd integer >>> ");
                    userinput3 = Console.ReadLine();
                }
                while (int.TryParse(userinput3, out int a) == false);
            }
            else
            {
                return;
            }

            int x = int.Parse(userinput2);
            int y = int.Parse(userinput3);

            if (x > y)
            {
                initial = y;
                limit = x;
                Console.WriteLine($"Odd numbers between {y} & {x}.");
            }
            else
            {
                initial = x;
                limit = y;
                Console.WriteLine($"Odd numbers between {x} & {y}.");
            }
            
            for (int i = initial ; i <= limit; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i);
                    if (i != limit - 1 && i != limit)
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.WriteLine();
        }

        //Descending number printing()
        static void DescendingNumberPrinting()
        {
            Console.WriteLine("This is a program to print descending numbers from 20 to 1.");
            Console.Write("( ");
            for (int i = 20; i >= 1; i--)
            {
                Console.Write(i);
                if (i != 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" )");
            Console.WriteLine("\n");

            //Random numbers question
            Console.WriteLine("Repeat with random numbers? Press Y and enter. Any other input to exit.");
            string userinput = Console.ReadLine();
            int[] arr = new int[2];
            int[] arr2 = new int[1];
            if (userinput == "Y" || userinput == "y")
            {
                arr = singleIntArrayValues(false);
            }
            else
            {
                return;
            }
            arr2 = singleIntArrayGenerator(arr[0], arr[1], arr[2]);
            arr2 = singleIntArraySorter(arr2, 2);

            Console.Write("( ");
            Console.Write(String.Join(" , ", arr2));
            Console.Write(" )");
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        //Ascending Number Printing
        static void AscendingNumberPrinting()
        {
            Console.WriteLine("This is a program to print ascending numbers from 1 to 20.");
            Console.Write("( ");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i);
                if (i != 20)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" )");
            Console.WriteLine("\n");

            //Random numbers question
            Console.WriteLine("Repeat with random numbers? Press Y and enter. Any other input to exit.");
            string userinput = Console.ReadLine();
            int[] arr = new int[2];
            int[] arr2 = new int[1];
            if (userinput == "Y" || userinput == "y")
            {
                arr = singleIntArrayValues(false);
            }
            else
            {
                return;
            }
            arr2 = singleIntArrayGenerator(arr[0], arr[1], arr[2]);
            arr2 = singleIntArraySorter(arr2, 1);

            Console.Write("( ");
            Console.Write(String.Join(" , ", arr2));
            Console.Write(" )");
            Console.WriteLine("\n");
            Console.ReadKey();
        }
         
        //Asking for random generator int[] values
        static int[] singleIntArrayValues(bool truerandflag)
        {
            string userinput2, userinput3, userinput4;
            int[] arr = new int[3];

            Random randomnumgen = new Random();
            if (truerandflag == true)
            {
                arr[0] = randomnumgen.Next(5, 150);
                arr[1] = -50;
                arr[2] = 100;
                return arr;
            }

            do
            {
                do
                {
                    Console.Write("Enter the number of elements (positive integer more than 1) >>> ");
                    userinput2 = Console.ReadLine();
                    Console.WriteLine();
                }
                while (int.TryParse(userinput2, out int a) == false);
                arr[0] = int.Parse(userinput2);
            }
            while (arr[0] < 2);
            do
            {
                do
                {
                    Console.Write("Enter the lower limit number value (0 or positive integer) >>> ");
                    userinput3 = Console.ReadLine();
                    Console.WriteLine();
                }
                while (int.TryParse(userinput3, out int b) == false);
                arr[1] = int.Parse(userinput3);
            }
            while (arr[1] < 0);
            do
            {
                do
                {
                    Console.Write("Enter the upper limit number value (greater than the minimal value) >>> ");
                    userinput4 = Console.ReadLine();
                    Console.WriteLine();
                }
                while (int.TryParse(userinput4, out int c) == false);
                arr[2] = int.Parse(userinput4);
            }
            while (arr[2] < arr[1]);
            return arr;

        }
        //Single int[] random generator
        static int[] singleIntArrayGenerator(int elementnum, int minnum, int maxnum)
            {
                Random randomnumbergen = new Random();
                int[] singleintarr = new int[elementnum];
                for (int i = 1; i < singleintarr.Length; i++)
                {
                    singleintarr[i] = randomnumbergen.Next(minnum, maxnum);
                }
                return singleintarr;
            }

        //Single int[] array sorter --- sortmethod 1 ascending 2 descending
        static int[] singleIntArraySorter(int[] arr, int sortmethod)
        {
            int tempvalue;
            if(sortmethod == 0)
            { return arr; }
            if (sortmethod ==1)
            {
                //ascended sorting
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i+1; j < arr.Length;j++)
                    {
                        if(arr[i] > arr[j])
                        {
                            tempvalue = arr[j];
                            arr[j] = arr[i];
                            arr[i] = tempvalue;
                        }
                    }
                }
                return arr;
            }
            else
            {
                //descended sorting
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            tempvalue = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tempvalue;
                        }
                    }
                }
                return arr;

            }
        }

    }
}
        