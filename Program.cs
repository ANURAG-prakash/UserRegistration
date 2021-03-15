using System;
namespace RegexPatternMatchingDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Patterns firstName = new Patterns();
            Patterns lastName = new Patterns();
            Console.WriteLine(firstName.validateFirstName("Anurag"));
            Console.WriteLine(lastName.validateFirstName("Prakash"));
            Console.ReadKey();

        }
    }
}
