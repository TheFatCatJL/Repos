using System;
using System.Threading;
using System.Text;
using System.IO;

namespace Day5
{
    class Day5Assignment
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
                    ReadIntegerMain();
                    break;
                case 2:
                    PrintArrayMain();
                    break;
                case 3:
                    InStringMain();
                    break;
                case 4:
                    FindWordMain();
                    break;
                case 5:
                    HexconverterMain();
                    break;
                case 6:
                    SubstituteMain();
                    break;
                case 7:
                    SetArrayMain();
                    break;
                case 8:
                    ResizeArrayMain();
                    break;
                case 9:
                    IsPrimeMain();
                    break;
                case 10:
                    MatrixMultiplyMain();
                    break;
                case 11:
                    DelegateOperationMain();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Make another main menu selection? Press Y and enter. Any other input to exit.");
            string userrepeat = Console.ReadLine();
            Console.WriteLine();
            if (userrepeat == "Y" || userrepeat == "y")
            {
                goto MenuBlock;
            }
            else
            {
                Console.WriteLine("Have a nice day!");
                Console.ReadKey();
            }

        }

        //menu selector
        static int menuselector(int menuchecknum)
        {
            string menucheckstr = "";
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("********************************************************");
                Console.WriteLine("*Welcome to Assignment 5 selection page                *");
                Console.WriteLine("*Please choose an option below (only integers)         *");
                Console.WriteLine("********************************************************");
                Console.WriteLine("* 1. Assignment Question 1 - Parsing integer           *");
                Console.WriteLine("* 2. Assignment Question 2 - Print Array Elements      *");
                Console.WriteLine("* 3. Assignment Question 3 - String finder             *");
                Console.WriteLine("* 4. Assignment Question 4 - String Position finder    *");
                Console.WriteLine("* 5. Assignment Question 5 - Hexadecimal Printing      *");
                Console.WriteLine("* 6. Assignment Question 6 - Substitute of string      *");
                Console.WriteLine("* 7. Assignment Question 7 - Set Array                 *");
                Console.WriteLine("* 8. Assignment Question 8 - Array Resizing            *");
                Console.WriteLine("* 9. Assignment Question 9 - IsPrime Printing          *");
                Console.WriteLine("* 10. Assignment Question 10 - Matrix Multiplication   *");
                Console.WriteLine("* 11. Assignment Question 11 - Delegate Problem        *");
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
                    if (int.Parse(menucheckstr) < 0 || int.Parse(menucheckstr) > 11)
                    {
                        Console.WriteLine("Please enter positive integers within the range (1 to 11) only!");
                        Console.WriteLine();
                        i = 0;
                    }

                }
            }
            menuchecknum = int.Parse(menucheckstr);
            return menuchecknum;
        }

        //Delegate Double ops
        /*
        delegate int IntOps(int n);
        void ApplyOperation(int[] arr, IntOps ops)
        void ApplyOperation(int[] arr, IntOps ops)
        { 
        for (int i=0; i<arr.Length; i++) 
        { 
        arr[i] = ops(arr[i]); 
        } 
        }
        static void Main()
        { 
        int[] A = new int[] {1, 2, 3} 
        IntOps myOp = Add10; 
        ApplyOperation(A, myOp); //A should contain {11, 12, 13} now. 
        } 
        int Add10(int x) 
        { 
        return x + 10; 
        }
        */
        //declaring delegate
        delegate double DoubleOps(double x);
        static void DelegateOperationMain()
        {
            
            //Random array generator
            Random randomnumgen = new Random();
            int randomarraysize = randomnumgen.Next(5, 20);
            double[] arr = new double[randomarraysize];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomnumgen.NextDouble() * randomnumgen.Next(1,50);
            }

            Console.WriteLine("Printing Original Arrays:");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]:###.0000}  ");
            }
            Console.WriteLine();

            DoubleOps ops = squareops;
            double[] arr2 = new double[randomarraysize];
            arr2 = (double[]) arr.Clone();
            ProcessArray(arr2, ops);
            Console.WriteLine("Printing Square Arrays:");
            for (int k = 0; k < arr2.Length; k++)
            {
                Console.Write($"{arr2[k]:###.0000}  ");
            }
            Console.WriteLine();
            ops = squarerootops;
            double[] arr3 = new double[randomarraysize];
            arr.CopyTo(arr3, 0);
            ProcessArray(arr3, ops);
            Console.WriteLine("Printing squareroot Arrays:");
            for (int l = 0; l < arr3.Length; l++)
            {
                Console.Write($"{arr3[l]:###.0000}  ");
            }
        }
        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            for (int i =0; i < arr.GetLength(0); i++)
            {
                arr[i] = ops(arr[i]);
            }
            return arr;
        }

        static double squareops(double x)
        {
            x = Math.Pow(x, 2);
            return x;
        }
        static double squarerootops(double x)
        {
            x = Math.Pow(x, 0.5);
            return x;
        }

        //MatrixMultiplyMain()
        static void MatrixMultiplyMain()
        {
            Random randomnumgen = new Random();
            int rand1, rand2, rand3,rand4;
            int i = 0, j = 0;
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];
            Console.WriteLine("Thsi is a program to return the multiplication results of two 2 dimensional matrices.");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            // Initialising matrix1
            Thread.Sleep(2000);
            Console.WriteLine("Initiating matrix 1");

            rand1 = randomnumgen.Next(1, 10);
            rand2 = randomnumgen.Next(1, 10);
            arr2 = Matrix2DRNDGen(rand1, rand2);

            // Print Matrix 1
            Console.WriteLine("Printing matrix 1 : ");

            for (i = 0; i < rand1; i++)
            {
                Console.Write("{");
                for (j = 0; j < rand2; j++)
                {
                    Console.Write(arr2[i, j]);
                    if (j != rand2 - 1)
                    {
                        Console.Write(",");
                    }                    
                }
                Console.Write("}");
                if (i != rand1 - 1)
                {
                    Console.Write(" , ");
                }
            }
            i = 0;
            j = 0;
            Console.WriteLine("\n");

            // Initialising Matrix 2
            Console.WriteLine("Initiating matrix 2");

            do
            {
                rand3 = randomnumgen.Next(1, 10);
                rand4 = randomnumgen.Next(1, 10);
            }
            while (rand3 != rand2 && rand4 != rand1);
            arr3 = Matrix2DRNDGen(rand3, rand4);

            // [4,3],[4,3]
            // [4,3] [3,4]
            //[6,3] [4,3]
            //[6,2] [2,5]

            // Print Matrix 2
            Thread.Sleep(2000);
            Console.WriteLine("Printing matrix 2 : ");

            for (i = 0; i < rand3; i++)
            {
                Console.Write("{");
                for (j = 0; j < rand4; j++)
                {
                    Console.Write(arr3[i, j]);
                    if (j != rand4 - 1)
                    {
                        Console.Write(",");
                    }

                }
                Console.Write("}");
                if (i != rand3 - 1)
                {
                    Console.Write(" , ");
                }
            }
            i = 0;
            j = 0;
            Console.WriteLine("\n");

            // Multiplying Matrix
            int[,] arr = MatrixMultiply(arr2, arr3);

            // Print Multiply Matrix
            Console.WriteLine("Printing Matrix 1 * Matrix 2 : ");

            for (i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("{");
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    if (j != arr.GetLength(1) - 1)
                    {
                        Console.Write(",");
                    }

                }
                Console.Write("}");
                if (i != arr.GetLength(0) - 1)
                {
                    Console.Write(" , ");
                }
            }
            i = 0;
            j = 0;
            Console.WriteLine("\n");


        }

        static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int upperlimitA0, upperlimitA1, upperlimitB0, upperlimitB1;
            upperlimitA0 = A.GetLength(0);
            upperlimitA1 = A.GetLength(1);
            upperlimitB0 = B.GetLength(0);
            upperlimitB1 = B.GetLength(1);

            //value multiplication for (x,y)(y,z)
            //[3,2] [2,4]
            /*[3,4]

            C[0,0] = A[0,0] * B[0,0] + A[0,1] * B[1,0]
            C[0,1] = A[0,0] * B[1,0] + A[0,1] * B[1,1]
            c[0,2] = A[0,0] * B[2,0] + A[0,1] * B[1,2]
            c[0,3] = A[0,0] * B[3,0] + A[0,1] * B[1,3]
            
            C[1,0] = A[1,0] * B[0,0] + A[1,1] * B[1,0]
            C[1,1] = A[1,0] * B[1,0] + A[1,1] * B[1,1]
            c[1,2] = A[1,0] * B[2,0] + A[1,1] * B[1,2]
            c[1,3] = A[1,0] * B[3,0] + A[1,1] * B[1,3]
            
            C[2,0] = A[2,0] * B[0,0] + A[2,1] * B[1,0]
            C[2,1] = A[2,0] * B[1,0] + A[2,1] * B[1,1]
            c[2,2] = A[2,0] * B[2,0] + A[2,1] * B[1,2]
            c[2,3] = A[2,0] * B[3,0] + A[2,1] * B[1,3]

            0 0            1 1 1 1    x x x x
            0 0            1 1 1 1    y y y y
            0 0                       z z z z

            */

            if (upperlimitA1 == upperlimitB0)
            {
                int[,] combine = new int[upperlimitA0, upperlimitB1];
                for (int i = 0; i < upperlimitA0; i++)
                {
                    for (int j = 0; j < upperlimitB1; j++)
                    {
                        for (int k = 0; k < upperlimitA1; k++)
                        {
                            combine[i, j] = combine[i, j] + A[i, k] * B[k, j];
                        }
                    }
                }
                return combine;
            }

            //value multiplication for (x,y)(y,z)
            //A[2,3] B[4,2]
            //B[4,2] A[2,3]
            /*[4,3]

            C[0,0] = B[0,0] * A[0,0] + B[1,0] * A[1,1]  
            C[0,1] = B[0,0] * A[1,0] + B[1,0] * A[1,1]
            c[0,2] = B[0,0] * A[2,0] + B[1,0] * A[1,2]
            
            C[1,0] = B[1,0] * A[0,0] + B[1,1] * A[1,0]
            C[1,1] = B[1,0] * A[1,0] + B[1,1] * A[1,1]
            c[1,2] = B[1,0] * A[2,0] + B[1,1] * A[1,2]
            
            C[2,0] = B[2,0] * A[0,0] + B[1,2] * A[1,0]
            C[2,1] = B[2,0] * A[1,0] + B[1,2] * A[1,1]
            c[2,2] = B[2,0] * A[2,0] + B[1,2] * A[1,2]
            
            C[3,0] = B[3,0] * A[0,0] + B[1,3] * A[1,0]
            C[3,1] = B[3,0] * A[1,0] + B[1,3] * A[1,1]
            c[3,2] = B[3,0] * A[2,0] + B[1,3] * A[1,2]
            

            0 0      1 1 1    x x x 
            0 0      1 1 1    y y y 
            0 0               z z z
            0 0               a a a

            */

            else
            {
                int[,] combine = new int[upperlimitB0, upperlimitA1];
                for (int i = 0; i < upperlimitB0; i++)
                {
                    for (int j = 0; j < upperlimitA1; j++)
                    {
                        for (int k = 0; k < upperlimitB1; k++)
                        {
                            combine[i, j] = combine[i, j] + B[i, k] * A[k, j];
                        }
                    }
                }
                return combine;
            }
            

        }


        // 2D Matrix int randomgenerator
        static int[,] Matrix2DRNDGen(int rand1,int rand2)
        {
            Random randomnumgen = new Random();
            
            int[,] arr = new int[rand1, rand2];
            
            for (int i = 0; i < rand1; i++)
            {
                for (int j=0; j< rand2;j++)
                {
                    arr[i, j] = randomnumgen.Next(1, 10);
                }
            }
            return arr;
        }

        //IsPrime Main
        static void IsPrimeMain()
        {
            string userinput1, userinput2;
            int range1, range2;
            Console.WriteLine("This is a program to find out the Prime numbers between two integer values.");
            do
            {
                do
                {
                    Console.Write("Please enter the 1st integer value >>> ");
                    userinput1 = Console.ReadLine();
                    Console.WriteLine();
                }
                while (int.TryParse(userinput1, out int a) == false);
            }
            while (int.Parse(userinput1) < 0);
            do
            {
                do
                {
                    Console.Write("Please enter the 2nd integer value >>> ");
                    userinput2 = Console.ReadLine();
                    Console.WriteLine();
                }
                while (int.TryParse(userinput2, out int a) == false);
            }
            while (int.Parse(userinput2) < 0);
            range1 = int.Parse(userinput1);
            range2 = int.Parse(userinput2);

            if (range1 < range2)
            {
                Console.WriteLine($"Prime numbers found between {range1} & {range2} : ");

                for (int i = range1; i <= range2; i++)
                {
                    if (IsPrime(i) == true)
                    {
                        Console.Write(i);
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Prime numbers found between {range2} & {range1} : ");

                for (int j = range2; j <= range1; j++)
                {
                    if (IsPrime(j) == true)
                    {
                        Console.Write(j);
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        
        //IsPrime()
        static bool IsPrime(int n)
        {
            int i = 0;
            int primecounter = 0;
            bool primetest = false;

            for (i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    primecounter++;
                }
            }
            if (primecounter == 1)
            {
                primetest = true;
                return primetest;
            }
            else
            {
                primetest = false;
                return primetest;
            }

        }
        //Resize Array Main()
        static void ResizeArrayMain()
        {
            string userinput = "";
            int value = 0, arraysize1=0;
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            Random randnumbergen = new Random();
            Console.WriteLine("This is a program to resize an array and to copy the old contents of the old array to the new one.");
            Console.WriteLine("Generating an array to be the <old array>...");
            Thread.Sleep(2000);
            Console.WriteLine("Creating values in <old array> ...");

            // random generation of old array values
            arraysize1 = randnumbergen.Next(1, 50);
            arr = new int[arraysize1];
            
            for (int i =0; i < arr.GetLength(0); i++)
            {
                arr[i] = randnumbergen.Next(1, 100);
            }
            Console.WriteLine();
            Console.WriteLine($"The old array size is {arr.GetLength(0)}.");

            // new array size checker
            do
            {
                do
                {
                    Console.Write("Please enter the new array size (must be a positive integer) >>> ");
                    userinput = Console.ReadLine();
                }
                while (int.TryParse(userinput, out int a) == false);
            }
            while (int.Parse(userinput) < 0);

            value = int.Parse(userinput);

            // ResizeArray() calling
            arr2 = ResizeArray(arr, value);
            
            Console.WriteLine($"The original array of elements size {arr.GetLength(0)} generated is as follows : ");
            Console.Write("{");
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if (j != arr.GetLength(0) - 1)
                {
                    Console.Write($" {arr[j]} , ");
                }
                else
                {
                    Console.Write($" {arr[j]} ");
                }
            }
            Console.Write("}");
            Console.WriteLine();

            Console.WriteLine($"The resized array of elements size {arr2.GetLength(0)} generated is as follows : ");
            Console.Write("{");
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                if (k != arr2.GetLength(0) - 1)
                {
                    Console.Write($" {arr2[k]} , ");
                }
                else
                {
                    Console.Write($" {arr2[k]} ");
                }
            }
            Console.Write("}");
            Console.WriteLine();

        }

        //ResizeArray()
        static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] arr3 = new int[newSize];
            int i = 0, j = 0;
            int arrtempL = arr.GetLength(0);

            if (arrtempL < newSize)
            {
                for (i = 0; i < arrtempL; i++)
                {
                    arr3[i] = arr[i];
                }
                for (j = arrtempL - 1; j < newSize; j++)
                {
                    arr3[j] = arr[j];
                }
            }
            else
            {
                for (i = 0; i < newSize; i++)
                {
                    arr3[i] = arr[i];
                }
            }
            arr = arr3;
            return arr;
        }

        //SetArrayMain()
        static void SetArrayMain()
        {
            string userinput = "";
            int value = 0;
            int[] arr = new int[10];
            Random randnumbergen = new Random();
            Console.WriteLine("This is a program to set integer value into an array.");
            do
            {
                Console.Write("Please enter the value you wish to set (only integer) >>> ");
                userinput = Console.ReadLine();
            }
            while (int.TryParse(userinput, out int a) == false);

            value = int.Parse(userinput);

            /*random array generator
            for(int i =0; i < arr.GetLength(0); i++)
            {
                arr[i] = randnumbergen.Next(1, 100);
            }*/

            // running SetArray()
            arr = SetArray(arr, value);

            Console.WriteLine("The array generated is as follows : ");
            Console.Write("{");
            for (int j = 0; j < arr.Length; j++)
            {
                if (j != arr.Length - 1)
                {
                    Console.Write($" {arr[j]} , ");
                }
                else
                {
                    Console.Write($" {arr[j]} ");
                }
            }
            Console.Write("}");
            Console.WriteLine();


        }
        //SetArray()
        static int[] SetArray(int[] arr, int value)
        {
            int[] arr3 = new int[arr.GetLength(0)]; 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr3[i] = value;
            }
            arr = arr3;
            return arr;
        }
        // SubstituteMain()
        static void SubstituteMain()
        {
            string sentence = "", newsentence="";
            string temp1, temp2;
            char character1, character2;

            Console.WriteLine("This is a program to substitute characters in a sentence.");
            do
            {
                Console.WriteLine("Please enter your sentence (Please at least have a word more than 3 characters).");
                Console.Write(">>> ");
                sentence = Console.ReadLine();
                Console.WriteLine();
            }
            while( sentence.Length <= 3);

            Console.Write("Please enter the character to be substitute (removed from sentence)  >>> ");
            temp1 = (Console.ReadLine()).Substring(0,1);
            character1 = Convert.ToChar(temp1);

            Console.Write("Please enter the character to substitute (insert into sentence)      >>> ");
            temp2 = (Console.ReadLine()).Substring(0,1);
            character2 = Convert.ToChar(temp2);
            Console.WriteLine("\n");
            newsentence = Substitute(sentence, character1, character2);

            if (newsentence != "")
            {
                Console.WriteLine("Original sentence:");
                Console.WriteLine(sentence);
                Console.WriteLine($"Modified sentence (substituted {character1} with {character2}):");
                Console.WriteLine(newsentence);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{character1} is not found in \"{sentence}\".");
                Console.WriteLine();
            }
        }
        //Substitute ()
        static string Substitute(string s, char c1, char c2)
        {
            int i = 0;
            int maxcharacter = s.Length;
            bool editflag = false;
            string substistr = c1.ToString();
            
            for (i = 0; i < maxcharacter; i++)
            {
                if (s.Substring(i,1) == substistr)
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, c2.ToString());
                    editflag = true;
                }
            }
            if (editflag == false)
            {
                s = "";
            }
            return s;
        }

        // HexconverterMain()
        static void HexconverterMain()
        {
            string userinputvalue = "0", signage ="",finalresult="",directconver="";
            int numbervalue = 0;
            Console.WriteLine("This is a program to find the Hexadeicimal value of a number");
            do
            {
                Console.Write("Please enter the integer you wish to convert >>> ");
                userinputvalue = Console.ReadLine();
                Console.WriteLine();
                if (int.TryParse(userinputvalue, out int a) == false)
                {
                    Console.WriteLine("Please enter a valid integer!");
                    Console.WriteLine();
                }
            }
            while (int.TryParse(userinputvalue, out int b) == false);

            if (int.Parse(userinputvalue) < 0)
            {
                signage = "-";
            }
            numbervalue = Math.Abs(int.Parse(userinputvalue));
            finalresult = signage + Hexconverter(numbervalue);
            directconver = numbervalue.ToString("X");

            Console.WriteLine();
            Console.WriteLine($"Input   : {userinputvalue}");
            Console.WriteLine($"Output  : {finalresult}");
            Console.WriteLine($"Cross checking with helper function is {directconver}.");
            Console.WriteLine();
        }
        
        // Hexconverter()
        static string Hexconverter(int num1)
        {
            int tempNumberHolder = 0, hexN1=0;
            string FinalResult = "";
            bool exitflag = false;
            tempNumberHolder = num1;

            do
            {
                if (tempNumberHolder < 16)
                {
                    FinalResult = HexFinder(tempNumberHolder) + FinalResult;
                    exitflag = true;
                }
                else
                {
                    hexN1 = tempNumberHolder % 16;
                    FinalResult = HexFinder(hexN1)+FinalResult;
                    tempNumberHolder = tempNumberHolder / 16;
                }
            }
            while (exitflag == false);

            return FinalResult;
        }
        // HexFinder()
        static string HexFinder(int numberHex)
        {
            string stringHex = "";
            switch (numberHex)
            {
                case 0:
                    stringHex = "0";
                    return stringHex;
                case 1:
                    stringHex = "1";
                    return stringHex;
                case 2:
                    stringHex = "2";
                    return stringHex;
                case 3:
                    stringHex = "3";
                    return stringHex;
                case 4:
                    stringHex = "4";
                    return stringHex;
                case 5:
                    stringHex = "5";
                    return stringHex;
                case 6:
                    stringHex = "6";
                    return stringHex;
                case 7:
                    stringHex = "7";
                    return stringHex;
                case 8:
                    stringHex = "8";
                    return stringHex;
                case 9:
                    stringHex = "9";
                    return stringHex;
                case 10:
                    stringHex = "A";
                    return stringHex;
                case 11:
                    stringHex = "B";
                    return stringHex;
                case 12:
                    stringHex = "C";
                    return stringHex;
                case 13:
                    stringHex = "D";
                    return stringHex;
                case 14:
                    stringHex = "E";
                    return stringHex;
                case 15:
                    stringHex = "F";
                    return stringHex;
                default:
                    return stringHex;
            }
        }
        // FindWord Main() 
        static void FindWordMain()
        {
            string[] userinputs = new string[4];
            string s1 = "", s2 = "", s3 = "", s4 = "";
            int repeater = 0;
            int searchresult = 0;
            Console.WriteLine("This is a program to check the position of a string if present in a sentence.");
            Console.WriteLine("");
            userinputs = InStringUserInputString();
            s1 = userinputs[0];
            s2 = userinputs[1];
            s3 = userinputs[2];
            s4 = userinputs[3];

            searchresult = FindWord(s1, s2);

            Console.WriteLine();
            Console.WriteLine("Position Search result");
            while (repeater < 95)
            {
                Console.Write("-");
                repeater++;
            }
            Console.WriteLine();

            if (searchresult >= 0)
            {
                Console.WriteLine("User Input Sentence(S1):");
                Console.WriteLine($"{s3}");
                Console.WriteLine("User Input Search String (S2):");
                Console.WriteLine($"{s4}");
                Console.WriteLine("Search Result:");
                Console.WriteLine($"TRUE. {s4} can be found in {s3} at position {searchresult}.");
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine("User Input Sentence(S1):");
                Console.WriteLine($"{s3}");
                Console.WriteLine("User Input Search String (S2):");
                Console.WriteLine($"{s4}");
                Console.WriteLine("Search Result:");
                Console.WriteLine($"FALSE. {s4} cannot be found in {s3}.");
                Console.WriteLine();

            }

        }
        //FindWord() method
        static int FindWord(string s1, string s2)
        {
            int i = 0;
            int positionI = -1;
            int s1Length = s1.Length;
            int s2Length = s2.Length;
            for (i = 0; i <= s1Length - (s2Length); i++)
            {
                if (s1.Substring(i, s2Length) == s2)
                {
                    positionI = i + 1;
                    return positionI;
                }
            }
            return positionI;
        }
    
        /// <summary>
        /// InScreen
        /// </summary>
        //InString Main()
        static void InStringMain()
        {
            string[] userinputs = new string[4];
            string s1 = "", s2 = "", s3="",s4="";
            int repeater = 0;
            bool searchresult = false;
            Console.WriteLine("This is a program to check if a string is present in a sentence.");
            Console.WriteLine("");
            userinputs = InStringUserInputString();
            s1 = userinputs[0];
            s2 = userinputs[1];
            s3 = userinputs[2];
            s4 = userinputs[3];
            searchresult = InString(s1, s2);

            Console.WriteLine();
            Console.WriteLine("Search result");
            while (repeater <95)
            {
                Console.Write("-");
                repeater++;
            }
            Console.WriteLine();

            if (searchresult == true)
            {
                Console.WriteLine("User Input Sentence(S1):");
                Console.WriteLine($"{s3}");
                Console.WriteLine("User Input Search String (S2):");
                Console.WriteLine($"{s4}");
                Console.WriteLine("Search Result:");
                Console.WriteLine($"TRUE. {s4} can be found in {s3}.");
                Console.WriteLine();
            }
            else
            {
                
                Console.WriteLine("User Input Sentence(S1):");
                Console.WriteLine($"{s3}");
                Console.WriteLine("User Input Search String (S2):");
                Console.WriteLine($"{s4}");
                Console.WriteLine("Search Result:");
                Console.WriteLine($"FALSE. {s4} cannot be found in {s3}.");
                Console.WriteLine();
                
            }
        }

        //InString Boolean Method

        static bool InString(string s1, string s2)
        {
            int i = 0;
            bool testFlag = false;
            int s1Length = s1.Length;
            int s2Length = s2.Length;
            for (i=0; i <= s1Length - (s2Length);i++)
            {
                if (s1.Substring(i,s2Length) == s2)
                {
                    testFlag = true;
                    return testFlag;
                }
            }
            return testFlag;
        }

        //InString User Input String Method()

        static string[] InStringUserInputString()
        {
            string[] userinputs = new string[4];
            bool LengthFlag = false;
            string userinputsentence = "", userinputsearch = "";
            do
            {
                Console.WriteLine("Please enter user sentence");
                Console.Write(">>> ");
                userinputsentence = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter user string for searching");
                Console.Write(">>> ");
                userinputsearch = Console.ReadLine();
                Console.WriteLine();
                userinputs[2] = userinputsentence;
                userinputs[3] = userinputsearch;
                userinputsentence = (userinputsentence.ToUpper()).Trim();
                userinputsearch = (userinputsearch.ToUpper()).Trim();
                if (userinputsentence.Length >= userinputsearch.Length)
                {
                    LengthFlag = true;
                }
            }
            while (LengthFlag == false);
            userinputs[0] = userinputsentence;
            userinputs[1] = userinputsearch;

            return userinputs;
            
        }

        /// <summary>
        /// Print Array
        /// </summary>
        // PrintArray() Main Method
        static void PrintArrayMain()
        {
            int[] arr = new int[50];
            
            arr = ArrayRandomGenerator();
            PrintArray(arr);
        }

        // PrintArray() Printing Method
        static void PrintArray(int[] arr)
        {
            int i = 0;
            Console.WriteLine("Generating report");
            for (i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i]);
                if (i != arr.GetLength(0) -1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\n");
            return;
        }

        //Random Array generation
        static int[] ArrayRandomGenerator()
        {
            Random NumberGenerator = new Random();
            int[] arr = new int[50];
            int[] arr2 = new int[50];
            int i = 0, choice = 0;
            bool AFlag = true;
            String KeyChoice = "1";

            for (i = 0; i < arr2.GetLength(0); i++)
            {
                arr2[i] = NumberGenerator.Next(1, 200);
            }

            do
            {
                Console.WriteLine("Please choose a sorting method for the array values as below (Press 1 to 3 and enter):");
                Console.WriteLine("1. Unsorted");
                Console.WriteLine("2. Ascending order");
                Console.WriteLine("3. Descending order");
                KeyChoice = Console.ReadLine();
                if (KeyChoice == "1")
                {
                    choice = 1;
                    AFlag = false;
                }
                else if (KeyChoice == "2")
                {
                    choice = 2;
                    AFlag = false;
                }
                else if (KeyChoice == "3")
                {
                    choice = 3;
                    AFlag = false;
                }
            }
            while (AFlag == true);
            if (choice == 1)
            {
                arr = arr2;
                return arr;
            }
            else
            {
                arr = ArraySorter(arr2,choice);
                return arr;
            }
        }

        //Sorting Array Method
        static int[] ArraySorter(int[] arr2, int choice)
        {
            int i = 0, j=0, tempINT =0;
            if (choice == 2)
            {
                //Ascending sort
                for (i = 0; i < arr2.GetLength(0); i++)
                {
                    for (j = i+1; j < arr2.GetLength(0);j++)
                    {
                        if (arr2[i] > arr2[j])
                        {
                            tempINT = arr2[i];
                            arr2[i] = arr2[j];
                            arr2[j] = tempINT;
                        }
                    }
                }
            }
            else if (choice == 3)
            {
                //Descending sort
                for (i = 0; i < arr2.GetLength(0)-1; i++)
                {
                    for (j = i + 1; j < arr2.GetLength(0); j++)
                    {
                        if (arr2[i] < arr2[j])
                        {
                            tempINT = arr2[j];
                            arr2[j] = arr2[i];
                            arr2[i] = tempINT;
                        }
                    }
                }
            }
            return arr2;
        }
        
        /// <summary>
        /// ReadInteger
        /// </summary>

        // ReadInteger Main method        
        static void ReadIntegerMain()
        {
            int SentenceNumberValue = 0;
            String RetryAnswer = "";

            do
            {
                do
                {
                    Console.WriteLine("This is a program to parse any sentence with integers to return with only integers.");
                    Console.Write("Please enter your input >>> ");
                    string message = Console.ReadLine();
                    Console.WriteLine();
                    SentenceNumberValue = ReadInteger(message);
                }
                while (SentenceNumberValue <= 0);
                Console.Write("Do you want to continue? Press Y and enter if yes. Any other input to exit >>> ");
                RetryAnswer = Console.ReadLine();
                Console.WriteLine();
            }
            while (RetryAnswer == "Y" ^ RetryAnswer == "y");
        }

        // ReadInteger Parse method
        static int ReadInteger(string message)
        {
            int i = 0, ReturnInteger = 0;
            string TempString = "";
            if (message == "")
            {
                Console.WriteLine($"Please enter something.");
                Console.WriteLine();
                ReturnInteger = 0;
                return ReturnInteger;
            }
            for (i=0 ; i < message.Length ; i++)
            {
                if (int.TryParse(message.Substring(i,1), out int a) == true)
                {
                    TempString = TempString + message.Substring(i, 1);
                }
                
            }
            if (TempString != "")
            {
                ReturnInteger = int.Parse(TempString);
                Console.WriteLine($"{message} is successfully parse to {ReturnInteger}.");
                Console.WriteLine();
                return ReturnInteger;
            }
            else
            {
                ReturnInteger = 0;
                Console.WriteLine($"{message} has no numbers to parse.");
                Console.WriteLine();
                return ReturnInteger;
            }
        }

    }

}