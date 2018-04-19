using System;

namespace D2assignment
{
    class Assignment
    {

        static void Main()
        {
        MainSelection:

            Console.WriteLine("********************************************************");
            Console.WriteLine("*Welcome to Assignment 2 selection page                *");
            Console.WriteLine("*Please choose an option below (only integers)         *");
            Console.WriteLine("********************************************************");
            Console.WriteLine("* 1. Quiz                                              *");
            Console.WriteLine("* 2. Assignment Question 1 - Square numbers            *");
            Console.WriteLine("* 3. Assignment Question 2 - Square-root               *");
            Console.WriteLine("* 4. Assignment Question 3 - Salary computation        *");
            Console.WriteLine("* 5. Assignment Question 4 - Centigrade to Fahreinheit *");
            Console.WriteLine("* 6. Assignment Question 5 - Formula Computation       *");
            Console.WriteLine("* 7. Assignment Question 6 - Dist between Coordinates  *");
            Console.WriteLine("* 8. Assignment Question 7 - Meter charges             *");
            Console.WriteLine("* 9. Assignment Question 8 - Taxi fare (2 decimals)    *");
            Console.WriteLine("* 10. Assignment Question 9 - Taxi Fare (rounding)     *");
            Console.WriteLine("* 11. Assignment Question 10 - Area of triangle        *");
            Console.WriteLine("* 12. Assignment Question 11 - Greeting modified       *");
            Console.WriteLine("* 13. Assignment Question 12 - Grading for marks       *");
            Console.WriteLine("* 14. Assignment Question 13 - Area computation        *");
            Console.WriteLine("* 15. Assignment Question 14 - Fare computation        *");
            Console.WriteLine("* 16. Assignment Question 15 - Armstrong Number        *");
            Console.WriteLine("********************************************************");
            string mainselectionans = Console.ReadLine();
            switch (mainselectionans)
            {
                case "1":
                    goto AssignmentBlock0;
                case "2":
                    goto AssignmentBlock1;
                case "3":
                    goto AssignmentBlock2;
                case "4":
                    goto AssignmentBlock3;
                case "5":
                    goto AssignmentBlock4;
                case "6":
                    goto AssignmentBlock5;
                case "7":
                    goto AssignmentBlock6;
                case "8":
                    goto AssignmentBlock7;
                case "9":
                    goto AssignmentBlock8;
                case "10":
                    goto AssignmentBlock9;
                case "11":
                    goto AssignmentBlock10;
                case "12":
                    goto AssignmentBlock11;
                case "13":
                    goto AssignmentBlock12;
                case "14":
                    goto AssignmentBlock13;
                case "15":
                    goto AssignmentBlock14;
                case "16":
                    goto AssignmentBlock15;
                default:
                    goto Earlyexit;
            }

        //quiz block
        AssignmentBlock0:
            int retry0 = 0;
            Console.WriteLine("Hi. This is a program to convert cm to inches.");
        Question:
            Console.Write("Please enter a number >>>");
            string numberinput = Console.ReadLine();
            try
            {
                double testnumber = double.Parse(numberinput);
            }
            catch
            {
                if (retry0 <= 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter only numbers!");
                    retry0++;
                    goto Question;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double inchanswer = double.Parse(numberinput) / 2.54;
            Console.WriteLine($"Converted {numberinput} cm to {inchanswer:#0.000} inch.");
            goto Menuselector;


        //Assignment Question1 Block

        AssignmentBlock1:

            int retryAQ1 = 0;

        AssignmentQ1:

            Console.WriteLine("This is a program to find the square of a number.");
            Console.Write("Please enter any number >>>");
            string userinputAQ1 = Console.ReadLine();

            try
            {
                double testnumberAQ1 = double.Parse(userinputAQ1);
            }
            catch
            {
                if (retryAQ1 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ1++;
                    goto AssignmentQ1;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double squarenumber = Math.Pow(double.Parse(userinputAQ1), 2);
            Console.WriteLine($"The square of {userinputAQ1} is {squarenumber}");
            goto Menuselector;

        //Assignment Question2 Block

        AssignmentBlock2:

            int retryAQ2 = 0;

            Console.WriteLine("This is a program to find the square-root of a number.");
        AssignmentQ2:
            Console.Write("Please enter any number >>>");
            string userinputAQ2 = Console.ReadLine();

            try
            {
                double testnumberAQ2 = double.Parse(userinputAQ2);
            }
            catch
            {
                if (retryAQ2 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ2++;
                    goto AssignmentQ2;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double squarerootnumber = Math.Sqrt(double.Parse(userinputAQ2));
            Console.WriteLine($"The square root of {userinputAQ2} is {squarerootnumber}");
            goto Menuselector;


        //Assignment Question3 Block

        AssignmentBlock3:

            int retryAQ3 = 0;

            Console.WriteLine("This is a program to calculate Total Income -  with benefits.");
        AssignmentQ3:
            Console.Write("Please enter your income (only numbers without the $ sign) >>>");
            string userinputAQ3 = Console.ReadLine();

            try
            {
                double testnumberAQ3 = double.Parse(userinputAQ3);
            }
            catch
            {
                if (retryAQ3 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ3++;
                    goto AssignmentQ3;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double income = double.Parse(userinputAQ3);
            double housingbenefit = income * 0.1;
            double transportallowance = income * 0.03;
            double totalincome = income + housingbenefit + transportallowance;
            Console.WriteLine("");
            Console.WriteLine($"Income (without benefits)   : $ {income:###,###,###,###.00}");
            Console.WriteLine($"Housing Benefit             : $ {housingbenefit:###,###,###.00}");
            Console.WriteLine($"Transport Allowance         : $ {transportallowance:###,###,###.00}");
            Console.WriteLine($"Total Income with benefits  : $ {totalincome:###,###,###,###.00}");
            Console.WriteLine("");
            goto Menuselector;

        //Assignment Question4 Block

        AssignmentBlock4:

            int retryAQ4 = 0;

            Console.WriteLine("This is a program to convert Centrigrade to Fahrenheit.");
        AssignmentQ4:
            Console.Write("Please enter the temperatue in Fahrenheit (only numbers without the sign) >>>");
            string userinputAQ4 = Console.ReadLine();

            try
            {
                double testnumberAQ4 = double.Parse(userinputAQ4);
            }
            catch
            {
                if (retryAQ4 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ4++;
                    goto AssignmentQ4;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double degreeC = double.Parse(userinputAQ4) * 1.8 + 32;
            Console.WriteLine($"The temperature today in Fahrenheit is {degreeC:###.##}");
            goto Menuselector;

        //Assignment Question5 Block

        AssignmentBlock5:

            int retryAQ5 = 0;

            Console.WriteLine("This is a program to calculate the value of y when the formula is y = 5x^2 - 4x + 3.");
        AssignmentQ5:
            Console.Write("Please the value of x  (only numbers) >>>");
            string userinputAQ5 = Console.ReadLine();

            try
            {
                double testnumberAQ5 = double.Parse(userinputAQ5);
            }
            catch
            {
                if (retryAQ5 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ5++;
                    goto AssignmentQ5;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double xvalue = double.Parse(userinputAQ5);
            double yvalue = 5 * Math.Pow(xvalue, 2) - 4 * xvalue + 3;
            Console.WriteLine($"The value of y is {yvalue:######.##} when x is {xvalue}.");
            goto Menuselector;
        
            //Assignment Question6 Block

            AssignmentBlock6:

            Console.WriteLine("This is a program to calculate the distance between 2 coordinates.");
            int casecount = 1;
            double coornum1 = 0, coornum2 = 0, coornum3 = 0, coornum4 = 0;
            AssignmentQ6:
            
            switch (casecount)
            {
                case 1:
                    Console.Write("Please the value of x axis for the 1st coordinate (only numbers) >>>");
                    goto userinputtesting;

                case 2:
                    Console.Write("Please the value of y axis for the 1st coordinate (only numbers) >>>");
                    goto userinputtesting;

                case 3:
                    Console.Write("Please the value of x axis for the 2nd coordinate (only numbers) >>>");
                    goto userinputtesting;

                case 4:
                    Console.Write("Please the value of x axis for the 2nd coordinate (only numbers) >>>");
                    goto userinputtesting;
            }

            userinputtesting:
            int testcountnumber = 0;
            string userinputnumber = Console.ReadLine();

            try
            {
                double.Parse(userinputnumber);
            }
            catch
            {
                if (testcountnumber <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers.");
                    testcountnumber++;
                    goto AssignmentQ6;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            

            switch (casecount)
            {
                case 1:
                    coornum1 = double.Parse(userinputnumber);
                    break;
                case 2:
                    coornum2 = double.Parse(userinputnumber);
                    break;
                case 3:
                    coornum3 = double.Parse(userinputnumber);
                    break;
                case 4:
                    coornum4 = double.Parse(userinputnumber);
                    break;
            }

            if (casecount <= 3)
            {
                casecount++;
                goto AssignmentQ6;
            }

            double distancecoor = Math.Sqrt(Math.Pow((coornum3 - coornum1),2) + Math.Pow((coornum4 - coornum2),2));
            Console.WriteLine($"Distance batween ({coornum1},{coornum2}) and ({coornum3},{coornum4}) is {distancecoor:###.##} units.");
            goto Menuselector;

            //Assignment Question7 Block

            AssignmentBlock7:

            int retryAQ7 = 0;

            Console.WriteLine("This is a program to calculate the total taxi meter fare.");
            AssignmentQ7:
            Console.Write("Please the distance travelled in kilometeres (only in numbers) >>>");
            string userinputAQ7 = Console.ReadLine();

            try
            {
                double testnumberAQ7 = double.Parse(userinputAQ7);
            }
            catch
            {
                if (retryAQ7 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ7++;
                    goto AssignmentQ7;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double distancefare = double.Parse(userinputAQ7)*0.4;
            double standardfare = 2.4;
            double totalfare = distancefare + standardfare;
            Console.WriteLine("");
            Console.WriteLine($"Standard Fare = ${standardfare}");
            Console.WriteLine($"Distance Fare = ${distancefare}");
            Console.WriteLine($"Total Fare    = ${totalfare}");
            Console.WriteLine("");
            goto Menuselector;

            //Assignment Question8 Block

            AssignmentBlock8:

            int retryAQ8 = 0;

            Console.WriteLine("This is a program to calculate the total taxi meter fare.");
            AssignmentQ8:
            Console.Write("Please the distance travelled in kilometeres (only in numbers) >>>");
            string userinputAQ8 = Console.ReadLine();

            try
            {
                double testnumberAQ8 = double.Parse(userinputAQ8);
            }
            catch
            {
                if (retryAQ8 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ8++;
                    goto AssignmentQ8;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double distancefare2 = double.Parse(userinputAQ8) * 0.4;
            double standardfare2 = 2.4;
            double totalfare2 = Math.Round(distancefare2 + standardfare2, 2);
            Console.WriteLine("");
            Console.WriteLine($"Standard Fare = ${standardfare2:###.#0}");
            Console.WriteLine($"Distance Fare = ${distancefare2:###.#0}");
            Console.WriteLine($"Total Fare    = ${totalfare2:###.#0}");
            Console.WriteLine("");
            goto Menuselector;

            //Assignment Question9 Block

            AssignmentBlock9:

            int retryAQ9 = 0;

            Console.WriteLine("This is a program to calculate the total taxi meter fare.");
            AssignmentQ9:
            Console.Write("Please the distance travelled in kilometeres (only in numbers) >>>");
            string userinputAQ9 = Console.ReadLine();

            try
            {
                double testnumberAQ9 = double.Parse(userinputAQ9);
            }
            catch
            {
                if (retryAQ9 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ9++;
                    goto AssignmentQ9;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double distancefare3 = double.Parse(userinputAQ9) * 0.4;
            double standardfare3 = 2.4;
            decimal totalfare3 = Math.Ceiling((decimal)(Math.Round(distancefare3 + standardfare3, 2)) * 100) / 100;
            Console.WriteLine("");
            Console.WriteLine($"Standard Fare = ${standardfare3:###.#0}");
            Console.WriteLine($"Distance Fare = ${distancefare3:###.#0}");
            Console.WriteLine($"Total Fare    = ${totalfare3:###.#0}");
            Console.WriteLine("");
            goto Menuselector;


            //Assignment Question10 Block

            AssignmentBlock10:

            Console.WriteLine("This is a program to calculate the area of a triangle.");
            int testcountnumber2b = 0;
            int casecount2 = 1;
            double triside1 = 0, triside2 = 0, triside3 = 0;
            AssignmentQ10:

            switch (casecount2)
            {
                case 1:
                    Console.Write("Please the value of the 1st side (in numbers only) >>>");
                    goto userinputtesting2;

                case 2:
                    Console.Write("Please the value of the 2nd side (in numbers only) >>>");
                    goto userinputtesting2;

                case 3:
                    Console.Write("Please the value of the 3rd side (in numbers only) >>>");
                    goto userinputtesting2;
                    
            }

            userinputtesting2:
            int testcountnumber2 = 0;
            string userinputnumber2 = Console.ReadLine();

            try
            {
                double.Parse(userinputnumber2);
            }
            catch
            {
                if (testcountnumber2 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers.");
                    testcountnumber2++;
                    goto AssignmentQ10;
                }
                else
                {
                    goto Earlyexit;
                }
            }


            switch (casecount2)
            {
                case 1:
                    triside1 = double.Parse(userinputnumber2);
                    break;
                case 2:
                    triside2 = double.Parse(userinputnumber2);
                    break;
                case 3:
                    triside3 = double.Parse(userinputnumber2);
                    break;
            }

            if (casecount2 != 3)
            {
                casecount2++;
                goto AssignmentQ10;
            }
            
            double snumber = (triside1 + triside2 + triside3)/2;
            double triarea = Math.Sqrt(snumber * (snumber - triside1) * (snumber - triside2) * (snumber - triside3));

            if (triarea != double.NaN)
            {
                if (testcountnumber2b <= 2)
                {
                    Console.WriteLine("The 3 sides do not form a triangle. Error! Retry!");
                    testcountnumber2b++;
                    casecount2 = 1;
                    goto AssignmentQ10;
                }
                else
                {
                    goto Earlyexit;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Side A = {triside1:###.00} units");
            Console.WriteLine($"Side B = {triside2:###.00} units");
            Console.WriteLine($"Side C = {triside3:###.00} units");
            Console.WriteLine($"Area   = {triarea:###.00} square units");

            goto Menuselector;

            //Assignment Question11 Block

            AssignmentBlock11:

            int retryAQ11 = 0;

            Console.WriteLine("This is a program to greet the user.");
            Console.Write("Hi. Please enter your name >>> ");
            string userinputAQ11 = Console.ReadLine();
            GenderSelect:
            Console.Write("Hi. Please enter your gender (M/F) >>> ");
            string userinputAQ11b = Console.ReadLine();

            if (userinputAQ11b == "M" || userinputAQ11b == "m")
            {
                Console.WriteLine($"Good Morning Mr {userinputAQ11}.");
                goto Menuselector;
            }
            else if (userinputAQ11b == "F" || userinputAQ11b == "f")
            {
                Console.WriteLine($"Good Morning Ms {userinputAQ11}.");
                goto Menuselector;

            }
            else
            {
                Console.WriteLine($"{userinputAQ11b} is not a valid entry for gender.");
                retryAQ11++;
                if (retryAQ11 < 3)
                {
                    goto GenderSelect;
                }
                else
                {
                    goto Earlyexit;
                }
            }

            //Assignment Question12 Block

            AssignmentBlock12:

            int retryAQ12 = 0;
            int retryAQ12b = 0;
            AssignmentQ12:

            Console.WriteLine("This is a program to greet the user - specifically.");
            Console.Write("Hi. Please enter your name >>> ");
            string userinputAQ12 = Console.ReadLine();
            ageasking:
            Console.Write("Please enter your age (integers only) >>> ");
            string userinputAQ12b = Console.ReadLine();
            try
            {
                int.Parse(userinputAQ12b);
            }
            catch
            {
                if (retryAQ12 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only integers.");
                    retryAQ12++;
                    goto AssignmentQ12;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            int userinputAQ12bb = int.Parse(userinputAQ12b);
            if (userinputAQ12bb > 150)
            {
                Console.WriteLine("Are you serious? Please enter something valid in this world.");
                Console.WriteLine("");
                goto ageasking;
            }

            GenderSelect2:
            Console.Write("Hi. Please enter your gender (M/F) >>> ");
            string userinputAQ12c = Console.ReadLine();

            if (userinputAQ12c == "M" || userinputAQ12c == "m" && userinputAQ12bb < 40)
            {
                Console.WriteLine($"Good Morning Mr {userinputAQ12}.");
                goto Menuselector;
            }
            else if (userinputAQ12c == "M" || userinputAQ12c == "m" && userinputAQ12bb >= 40)
            {
                Console.WriteLine($"Good Morning Uncle {userinputAQ12}.");
                goto Menuselector;
            }
            else if (userinputAQ12c == "F" || userinputAQ12c == "f" && userinputAQ12bb < 40)
            {
                Console.WriteLine($"Good Morning Ms {userinputAQ12}.");
                goto Menuselector;
            }
            else if (userinputAQ12c == "F" || userinputAQ12c == "f" && userinputAQ12bb >=40)
            {
                Console.WriteLine($"Good Morning Aunty {userinputAQ12}.");
                goto Menuselector;
            }
            else
            {
                Console.WriteLine($"{userinputAQ12c} is not a valid entry for gender.");
                retryAQ12b++;
                if (retryAQ12b < 3)
                {
                    goto GenderSelect2;
                }
                else
                {
                    goto Earlyexit;
                }
            }

            //Assignment Question13 Block

            AssignmentBlock13:

            int retryAQ13 = 0;
            int retryAQ13b = 0;
            Console.WriteLine("This is a program to show the grades obtain for certain marks.");
            AssignmentQ13:
            Console.Write("Please enter your marks (only in integers) >>>");
            string userinputAQ13 = Console.ReadLine();

            try
            {
                int.Parse(userinputAQ13);
            }
            catch
            {
                if (retryAQ13 <= 2)
                {
                    Console.WriteLine("Invalid. Please enter only integers.");
                    retryAQ13++;
                    goto AssignmentQ13;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            int markgrade = int.Parse(userinputAQ13);
            if (markgrade < 0 || markgrade > 100)
            {
                if (retryAQ13b <= 2)
                {
                    Console.WriteLine("Please enter integers only from 0 to 100.");
                    retryAQ13b++;
                    goto AssignmentQ13;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            else
            {
                if (markgrade >= 80)
                {
                    Console.WriteLine($"You scored {markgrade} marks which is A grade");
                }
                if (markgrade >= 60 && markgrade < 80)
                {
                    Console.WriteLine($"You scored {markgrade} marks which is B grade");
                }
                if (markgrade >= 40 && markgrade < 60)
                {
                    Console.WriteLine($"You scored {markgrade} marks which is C grade");
                }
                if (markgrade < 40)
                {
                    Console.WriteLine($"You scored {markgrade} marks which is F grade");
                }
                Console.WriteLine("");
            }
            goto Menuselector;

            //Assignment Question14 Block

            AssignmentBlock14:

            int retryAQ14 = 0;

            Console.WriteLine("This is a program to calculate the total taxi meter fare. (staggered distance fare)");
            AssignmentQ14:
            Console.Write("Please the distance travelled in kilometeres (only in numbers) >>>");
            string userinputAQ14 = Console.ReadLine();

            try
            {
                double.Parse(userinputAQ14);
            }
            catch
            {
                if (retryAQ14 <= 2)
                {
                    Console.WriteLine("Invalid. Please use only numbers and decimal point.");
                    retryAQ14++;
                    goto AssignmentQ14;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            double distancetravel = double.Parse(userinputAQ14);
            if (distancetravel <= 0.5)
            {
                double standardfare4 = 2.4;
                double distancefare4a = 0;
                double distancefare4b = 0;
                double totaldistancefare = distancefare4a + distancefare4b;
                decimal totalfare4 = Math.Ceiling((decimal)(Math.Round(totaldistancefare + standardfare4, 2)) * 100) / 100;
                Console.WriteLine("");
                Console.WriteLine($"Standard Fare = ${standardfare4:###.#0}");
                Console.WriteLine($"Distance Fare = ${totaldistancefare:###.#0}");
                Console.WriteLine($"Total Fare    = ${totalfare4:###.#0}");
                Console.WriteLine("");
            }
            if (distancetravel > 0.5 && distancetravel <=9)
            {
                double standardfare4 = 2.4;
                double distancefare4a = distancetravel / 0.1 * 0.04;
                double distancefare4b = 0;
                double totaldistancefare = distancefare4a + distancefare4b;
                decimal totalfare4 = Math.Ceiling((decimal)(Math.Round(totaldistancefare + standardfare4, 2)) * 100) / 100;
                Console.WriteLine("");
                Console.WriteLine($"Standard Fare = ${standardfare4:###.#0}");
                Console.WriteLine($"Distance Fare = ${totaldistancefare:###.#0}");
                Console.WriteLine($"Total Fare    = ${totalfare4:###.#0}");
                Console.WriteLine("");
            }
            if (distancetravel > 9)
            {
                double standardfare4 = 2.4;
                double distancefare4a = 85 * 0.04;
                double distancefare4b = (distancetravel - 9)/0.1 * 0.05;
                double totaldistancefare = distancefare4a + distancefare4b;
                decimal totalfare4 = Math.Ceiling((decimal)(Math.Round(totaldistancefare + standardfare4, 2)) * 100) / 100;
                Console.WriteLine("");
                Console.WriteLine($"Standard Fare = ${standardfare4:###.#0}");
                Console.WriteLine($"Distance Fare = ${totaldistancefare:###.#0}");
                Console.WriteLine($"Total Fare    = ${totalfare4:###.#0}");
                Console.WriteLine("");
            }
            goto Menuselector;

            //Assignment Question15 Block

            AssignmentBlock15:

            int retryAQ15 = 0;

            Console.WriteLine("This is a program to test if a number is an Armstrong number.");
            AssignmentQ15:
            Console.Write("Please an 3-digit integer (eg. 100-999) >>>");
            string userinputAQ15 = Console.ReadLine();

            try
            {
                int.Parse(userinputAQ15);
            }
            catch
            {
                if (retryAQ15 <= 2)
                {
                    Console.WriteLine("Invalid. Please only enter integers.");
                    retryAQ15++;
                    goto AssignmentQ15;
                }
                else
                {
                    goto Earlyexit;
                }
            }
            int armstrongnumber = int.Parse(userinputAQ15);
            if (armstrongnumber<100 || armstrongnumber >999)
            {
                Console.WriteLine("Please enter only integers from 100 to 999.");
                goto AssignmentQ15;            
            }
            int armstrongnumber1 = armstrongnumber/100;
            int armstrongnumber2 = armstrongnumber/10 % 10;
            int armstrongnumber3 = armstrongnumber % 10;
            if (armstrongnumber == Math.Pow(armstrongnumber1,3)+ Math.Pow(armstrongnumber2, 3)+ Math.Pow(armstrongnumber3, 3))
            {
                Console.WriteLine($"The number {armstrongnumber} is an Armstrong number.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"The number {armstrongnumber} is not an Armstrong number.");
                Console.Write("Retry? (Type Y for yes or enter any other key to exit");
                string askretry = Console.ReadLine();
                if (askretry == "Y" || askretry == "y")
                {
                    goto AssignmentQ15;
                }
                else
                {
                    goto Normalexit;
                }
            }
            goto Menuselector;

            Menuselector:
            Console.Write("Go back to main menu? Press Y to proceed to Main Menu, another other key to exit >>>");
            string userretryMS = Console.ReadLine();
            if (userretryMS == "Y" || userretryMS == "y")
            {
                Console.WriteLine("");
                goto MainSelection;
            }
            else
            {
                goto Normalexit;
            }

            Earlyexit:
            Console.WriteLine("You have made an invalid selection or you have exceeded the max number of tries!");
            Console.WriteLine("Either way, have a nice day.");
            Console.ReadKey();


            Normalexit:

            Console.WriteLine("Have a nice day.");
            Console.ReadKey();
        }


    }
}
