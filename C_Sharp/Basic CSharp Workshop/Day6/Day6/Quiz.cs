using System;

namespace Day6
{
    class Day6Assignment
    {
        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 300000 };
        static double[] taxRateArray = new double[] { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };

        static void Main()
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        static int AskForIncome()
        {
            int annualIncome = 0;
            string annualIncomeStr = "";
            do
            {
                Console.WriteLine("Please enter your annual taxable income: ");
                annualIncomeStr = Console.ReadLine();
            }
            while (int.TryParse(annualIncomeStr, out int a) == false);
            annualIncome = int.Parse(annualIncomeStr);
            return annualIncome;
        }

        static int GetTaxBracket(int annualIncome)
        {
            int taxBracket = -1;
            for (int i = 0; i < minIncomeArray.GetLength(0); i++)
            {
                if (annualIncome > minIncomeArray[i])
                {
                    taxBracket++;
                }
            }
            return taxBracket;
        }

        static double CalculateIncomeTax(int annualIncome, int taxBracket)
        {
            if (taxBracket == -1)
            {
                return 0;
            }
            double taxPayable = 0;
            taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            taxPayable = Math.Round(taxPayable, 2);
            return taxPayable;
        }

        static void PrintResult(int annualIncome, double taxPayable)
        {
            Console.WriteLine($"For taxable annual income of ${annualIncome:###,###,###,###.00}, the tax payable amount is ${taxPayable:###,###,###.00}");
            Console.ReadKey();
        }

    }
}