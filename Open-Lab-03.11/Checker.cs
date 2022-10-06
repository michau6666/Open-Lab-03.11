using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);
            bool b = str.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
 
