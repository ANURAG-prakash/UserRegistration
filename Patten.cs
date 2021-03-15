using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexPatternMatchingDemo
{
    class Patterns
    {
        public static string Regex_First_Name = "^[A-Z][a-z]{2,}$";
        public static string Regex_Last_Name = "^[A-Z][a_z]{2,}$";



        public bool validateFirstName(string name)
        {
            return Regex.IsMatch(name, Regex_First_Name);
        }
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_Last_Name);
        }
    }
}
