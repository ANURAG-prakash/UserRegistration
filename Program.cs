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
            Console.WriteLine(firstName.validateFirstName("Anurag"));
            Console.WriteLine(lastName.validateFirstName("Prakash"));
            Console.WriteLine(email.validateFirstName("prakash.shanu80@gmail.com"));
            Console.WriteLine(email.validateFirstName("9518039211"));

            Console.ReadKey();

        }
    }
}
