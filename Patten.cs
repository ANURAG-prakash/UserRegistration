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
        public static string Regex_Email = "^[a - z0 - 9A - Z] + ([._ + -][a - z0 - 9A - Z] +) *[@][a - z0 - 9A - Z] +[.][a - zA - Z]{2,3}(.[a-zA-Z]{2})?$";
        public static string Regex_Mobile = "^[0-9]{2}[6-9]{1}[0-9]{9}$";

        public bool validateFirstName(string name)
        {
            return Regex.IsMatch(name, Regex_First_Name);
        }
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_Last_Name);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
        public bool validateMobile(string email)
        {
            return Regex.IsMatch(email, Regex_Mobile);
        }
    }
}
