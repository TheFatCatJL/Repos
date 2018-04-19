using System;
using System.Collections;

namespace Day5
{

    public interface IInvestment
    {
        double CalculateTimeValue(int investyear, string investmenttype, string raritybenchmark, double capital);
        double CalculateValue(IInvestment investment);
        double CalculateProfit(IInvestment investment);
        void ShowInvestmentDetails(IInvestment investment);
        double GetCapitalValue();
        string GetInvestType();
        int GetInvestYear();
        string GetRarity();
    }

    public class RarityIndex
    {
        public double RarityBenchmarker(string investmenttype, string raritybenchmark)
        {
            switch (investmenttype)
            {
                case "Coin":
                    if (raritybenchmark == "Common") return 1.01;
                    else if (raritybenchmark == "Uncommon") return 1.025;
                    else if (raritybenchmark == "Rare") return 1.1;
                    else if (raritybenchmark == "Limited") return 1.25;
                    else return 1;
                case "Gold":
                    return 1.05;
                case "Antique":
                    if (raritybenchmark == "Common") return 1.00;
                    else if (raritybenchmark == "Uncommon") return 1.1;
                    else if (raritybenchmark == "Rare") return 1.5;
                    else if (raritybenchmark == "Limited") return 3;
                    else return 1;
            }
            return 1;
        }
    }
    public class Coin : RarityIndex, IInvestment
    {
        int InvestYear;
        string InvestmentType;
        string RarityBenchmark;
        double Capital;

        public Coin(int investyear, string investmenttype, string raritybenchmark, double capital)
        {
            InvestYear = investyear;
            InvestmentType = investmenttype;
            RarityBenchmark = raritybenchmark;
            Capital = capital;
        }

        public double CalculateProfit(IInvestment investment)
        {
            return CalculateValue(investment) - Capital;
        }

        public double CalculateTimeValue(int investyear, string investmenttype, string raritybenchmark, double capital)
        {
            double TempValue = 0;
            TempValue = capital * RarityBenchmarker(InvestmentType, RarityBenchmark) * (1+(DateTime.Now.Year - investyear) / (72/7));
            return TempValue;
        }

        public double CalculateValue(IInvestment investment)
        {
            return CalculateTimeValue(InvestYear, InvestmentType, RarityBenchmark, Capital);
        }

        public double GetCapitalValue()
        {
            return Capital;
        }

        public string GetInvestType()
        {
            return InvestmentType;
        }

        public int GetInvestYear()
        {
            return InvestYear;
        }

        public string GetRarity()
        {
            return RarityBenchmark;
        }

        public void ShowInvestmentDetails(IInvestment investment)
        {
            Console.WriteLine("Investment Type  : {0}",InvestmentType);
            Console.WriteLine("Rarity Benchmark : {0}", RarityBenchmark);
            Console.WriteLine("Investment Year  : {0}", InvestYear);
            Console.WriteLine("Capital Value    : {0:c}", Capital);
            Console.WriteLine("Current Value    : {0:c}",CalculateValue(investment));
        }
    }

    public class Gold : RarityIndex, IInvestment
    {
        int InvestYear;
        string InvestmentType;
        string RarityBenchmark;
        double Capital;

        public Gold(int investyear, string investmenttype, string raritybenchmark, double capital)
        {
            InvestYear = investyear;
            InvestmentType = investmenttype;
            RarityBenchmark = raritybenchmark;
            Capital = capital;
        }
        public double CalculateProfit(IInvestment investment)
        {
            return CalculateValue(investment) - Capital;
        }

        public double CalculateTimeValue(int investyear, string investmenttype, string raritybenchmark, double capital)
        {
            double TempValue = 0;
            TempValue = capital * RarityBenchmarker(InvestmentType, RarityBenchmark) * (1+(DateTime.Now.Year - investyear) / (72 / 7));
            return TempValue;
        }

        public double CalculateValue(IInvestment investment)
        {
            return CalculateTimeValue(InvestYear, InvestmentType, RarityBenchmark, Capital);
        }

        public double GetCapitalValue()
        {
            return Capital;
        }

        public void ShowInvestmentDetails(IInvestment investment)
        {
            Console.WriteLine("Investment Type  : {0}", InvestmentType);
            Console.WriteLine("Rarity Benchmark : {0}", RarityBenchmark);
            Console.WriteLine("Investment Year  : {0}", InvestYear);
            Console.WriteLine("Capital Value    : {0:c}", Capital);
            Console.WriteLine("Current Value    : {0:c}", CalculateValue(investment));
        }
        public string GetInvestType()
        {
            return InvestmentType;
        }

        public int GetInvestYear()
        {
            return InvestYear;
        }

        public string GetRarity()
        {
            return RarityBenchmark;
        }
    }

    public class Antique : RarityIndex, IInvestment
    {
        int InvestYear;
        string InvestmentType;
        string RarityBenchmark;
        double Capital;

        public Antique(int investyear, string investmenttype, string raritybenchmark, double capital)
        {
            InvestYear = investyear;
            InvestmentType = investmenttype;
            RarityBenchmark = raritybenchmark;
            Capital = capital;
        }

        public double CalculateProfit(IInvestment investment)
        {
            return CalculateValue(investment) - Capital;
        }

        public double CalculateTimeValue(int investyear, string investmenttype, string raritybenchmark, double capital)
        {
            double TempValue = 0;
            TempValue = capital * RarityBenchmarker(InvestmentType, RarityBenchmark) * (1+(DateTime.Now.Year - investyear) / (72 / 7));
            
            return TempValue;
        }

        public double CalculateValue(IInvestment investment)
        {
            return CalculateTimeValue(InvestYear, InvestmentType, RarityBenchmark, Capital);
        }

        public double GetCapitalValue()
        {
            return Capital;
        }

        public void ShowInvestmentDetails(IInvestment investment)
        {
            Console.WriteLine("Investment Type  : {0}", InvestmentType);
            Console.WriteLine("Rarity Benchmark : {0}", RarityBenchmark);
            Console.WriteLine("Investment Year  : {0}", InvestYear);
            Console.WriteLine("Capital Value    : {0:c}", Capital);
            Console.WriteLine("Current Value    : {0:c}", CalculateValue(investment));
        }
        public string GetInvestType()
        {
            return InvestmentType;
        }

        public int GetInvestYear()
        {
            return InvestYear;
        }

        public string GetRarity()
        {
            return RarityBenchmark;
        }
    }
    public class Investments
    {
        public ArrayList InvestmentList { get; }
        public Investments(ArrayList investmentlist)
        {
            InvestmentList = investmentlist;
        }
        public void TotalInvestmentValue(ArrayList investmentlist)
        {
            double TempValue=0;
            int count = 0;
            foreach (IInvestment investments in investmentlist)
            {
                count++;
                TempValue += investments.CalculateValue(investments);
                Console.WriteLine("{0} {1} acquired in Year {2} for {3:c} is worth {4:c} now.",investments.GetRarity(),investments.GetInvestType(),investments.GetInvestYear(),investments.GetCapitalValue(),investments.CalculateValue(investments));
            }
            Console.WriteLine("Total Investment Value for {0} items is {1:c}.", count, TempValue);
        }
        public void TotalInvestmentProfit(ArrayList investmentlist)
        {
            int count = 0;
            double TempValue = 0;
            foreach (IInvestment investments in investmentlist)
            {
                count++;
                TempValue = TempValue + investments.CalculateValue(investments) - investments.GetCapitalValue();
                Console.WriteLine("You have gained {4:c} for {0} {1} acquired in Year {2} for {3:c}.", investments.GetRarity(), investments.GetInvestType(), investments.GetInvestYear(), investments.GetCapitalValue(), investments.CalculateValue(investments) - investments.GetCapitalValue());
            }
            Console.WriteLine("Total Investment Value for {0} items is {1:c}.", count, TempValue);

        }
        public void AddInvestment(IInvestment investment)
        {
            InvestmentList.Add(investment);
        }

        public void ShowAllPortfolio(ArrayList investmentlist)
        {
            foreach(IInvestment investments in investmentlist)
            {
                investments.ShowInvestmentDetails(investments);
                Console.WriteLine();
            }
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            ArrayList InvestmentPortfolio = new ArrayList();
            Coin C1 = new Coin(2000, "Coin", "Rare", 40);
            Coin C2 = new Coin(1800, "Coin", "Common", 25);
            Coin C3 = new Coin(1900, "Coin", "Uncommon", 50);
            Coin C4 = new Coin(1940, "Coin", "Limited", 200);
            Coin C5 = new Coin(2010, "Coin", "Rare", 50);
            Coin C6 = new Coin(1980, "Coin", "Uncommon", 100);
            Gold G1 = new Gold(1950, "Gold", "Common", 100);
            Gold G2 = new Gold(2000, "Gold", "Common", 1500);
            Gold G3 = new Gold(2010, "Gold", "Common", 1000);
            Gold G4 = new Gold(2013, "Gold", "Common", 2000);
            Antique A1 = new Antique(1917, "Antique", "Uncommon", 2500);
            Antique A2 = new Antique(1789, "Antique", "Limited", 250);
            Antique A3 = new Antique(1823, "Antique", "Uncommon", 125);
            Antique A4 = new Antique(145, "Antique", "Uncommon", 25);
            Antique A5 = new Antique(1355, "Antique", "Limited", 20);
            Antique A6 = new Antique(1931, "Antique", "Rare", 125);
            Antique A7 = new Antique(1948, "Antique", "Common", 200);
            Investments MyPortfolio = new Investments(InvestmentPortfolio);
            MyPortfolio.AddInvestment(C1);
            MyPortfolio.AddInvestment(C2);
            MyPortfolio.AddInvestment(C3);
            MyPortfolio.AddInvestment(C4);
            MyPortfolio.AddInvestment(C5);
            MyPortfolio.AddInvestment(C6);
            MyPortfolio.AddInvestment(G1);
            MyPortfolio.AddInvestment(G2);
            MyPortfolio.AddInvestment(G3);
            MyPortfolio.AddInvestment(G4);
            MyPortfolio.AddInvestment(A1);
            MyPortfolio.AddInvestment(A2);
            MyPortfolio.AddInvestment(A3);
            MyPortfolio.AddInvestment(A4);
            MyPortfolio.AddInvestment(A5);
            MyPortfolio.AddInvestment(A6);
            MyPortfolio.AddInvestment(A7);
            //MyPortfolio.TotalInvestmentValue(MyPortfolio.InvestmentList);
            //MyPortfolio.TotalInvestmentProfit(MyPortfolio.InvestmentList);
            MyPortfolio.ShowAllPortfolio(MyPortfolio.InvestmentList);
        }
    }
}
