using System;
using System.Collections.Generic;
using System.Text;
using BoxDLL;

namespace CommonBots
{
    class DataCheckerBot
    {
        public bool MemberFormIntegrityChecker()
        {
            //if (NUSIDVerification(idbuttonvalue) == true || PositiveIntCheck(mobilebuttonvalue)==true)
            //{
            //      return true;
            //}
            return false;
        }

        public bool PositiveIntCheck(string textBoxValue)
        {
            if (int.TryParse(textBoxValue, out int a))
            {
                if (a >= 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool NUSIDVerification(string textBoxValue)
        {
            textBoxValue = textBoxValue.Trim();
            textBoxValue = textBoxValue.ToUpper();
            if (textBoxValue.Length > 9)
            {
                return false;
            }
            if (textBoxValue.Substring(0, 1) != "A")
            {
                return false;
            }
            if (!int.TryParse(textBoxValue.Substring(1,7), out int a))
            {
                return false;
            }
            if (!char.IsLetter(textBoxValue, 8))
            {
                return false;
            }
            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            DataCheckerBot DB = new DataCheckerBot();            
            MemberBox tbox = new MemberBox();
            Console.WriteLine(tbox.Name);
            Console.ReadKey();
        }
    }

}
