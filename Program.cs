using System;
namespace RegexPatternMatchingDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Patterns firstName = new Patterns();
            Patterns lastName = new Patterns();
            Patterns email = new Patterns();
            Patterns mobile = new Patterns();
            Patterns password = new Patterns();
            Console.WriteLine(firstName.validateFirstName("Anurag"));
            Console.WriteLine(lastName.validateLastName("Prakash"));
            Console.WriteLine(email.validateEmail("prakash.shanu80@gmail.com"));
            Console.WriteLine(mobile.validateMobile("9518039211"));
            Console.WriteLine(password.validateFirstName("@Anurag123"));
            Console.ReadKey();

        }
    }
}
