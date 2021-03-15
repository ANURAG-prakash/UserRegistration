using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexPatternMatchingDemo
{
    class Patterns
    {
        public static string Regex_First_Name = "^[A-Z][a-z]{2,}$";
       


        public bool validateFirstName(string name)
        {
            return Regex.IsMatch(name, Regex_First_Name);
        }
    }
}
