using System;
namespace RegexPatternMatchingDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.validateFirstName("Anurag"));
            Console.ReadKey();

        }
    }
}
