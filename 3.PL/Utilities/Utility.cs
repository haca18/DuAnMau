using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.PL.Utilities
{
    public class Utility
    {
        private bool CheckPass(string temp)
        {
            Regex r = new Regex("(?=.*[A-Z])[A-Za-z0-9]{8,8}$");
            if (!r.IsMatch(temp))
            {
                return false;
            }
            return true;
        }
        private bool CheckNumber(string temp)
        {
            Regex r = new Regex("^[0-9]*$");
            if (!r.IsMatch(temp))
            {
                return false;
            }
            return true;
        }
        private bool CheckSDT(string temp)
        {
            Regex rgx = new Regex("(\\+84|0)\\d{9,10}");
            if (!rgx.IsMatch(temp))
            {
                return false;
            }
            return true;
        }
    }
}
