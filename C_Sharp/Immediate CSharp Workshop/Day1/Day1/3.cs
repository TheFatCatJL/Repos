using System;
using ISS.LIB;
public class Dice
{
    int faceup=0;
    int userprefix=8;
    public int tries = 0;
    public int lastthrow = 0;
    
    // constructor
    public Dice()
    {
        diceThrow();
    }
    public void setUserPrefix(int a)
    {
        userprefix = a;
    }

    public int getfaceup()
    {
        return faceup;
    }
    public int diceThrow()
    {
        if (faceup != 0) lastthrow = faceup; 
        faceup = MyMath.RNDInt(6) +1;
        tries++;
        return faceup;
    }
    public string strFaceUp
    {
        get
        {
            if (getfaceup() + lastthrow == userprefix)
            {
                return "Success, you got it.";
            }
            else return "Got to try again.";
        }
    }
}

public class DiceGame
{
    public static void Main()
    {
        bool repeatflag = false;
        string userinput = "";
        int a = -1;
        Console.WriteLine("This is a program to check for an user input number using 2 dices");
        do
        {
            do
            {
                Console.Write("Please enter your number (Enter 2 to 12 only) >> ");
                userinput = Console.ReadLine();
                Console.WriteLine();
            } while (int.TryParse(userinput, out a) == false);
        } while (a < 2 || a > 12);
        Dice dice1 = new Dice();
        dice1.setUserPrefix(a);
        do
        {
            Console.WriteLine("Dice 1, Result : {0}", dice1.getfaceup());
            dice1.diceThrow();
            Console.WriteLine("Dice 2, Result : {0}", dice1.getfaceup());
            Console.WriteLine(dice1.strFaceUp);
            Console.WriteLine();
            if (dice1.getfaceup() + dice1.lastthrow == a)
            { repeatflag = true; }
            dice1.diceThrow();
        } while (repeatflag==false);
        Console.WriteLine("You got this result in {0} tries.",dice1.tries/2);
    }
}