using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SportFacilitySystem
{
    //code by Jason
    class DataChecker
    {
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
        
            if (textBoxValue.Length != 8)
            {
                return false;
            }
            if (textBoxValue.Substring(0, 1) != "A")
            {
                return false;
            }
            if (!int.TryParse(textBoxValue.Substring(1,6), out int a))
            {
                return false;
            }
            if (!char.IsLetter(textBoxValue, 7))
            {
                return false;
            }
            return true;
        }
    }
}
