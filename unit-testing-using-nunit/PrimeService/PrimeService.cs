using System;
namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            throw new NotImplementedException("Please create a test first.");
        }
        public static void Main() {
            PrimeService primo = new PrimeService();    
            Console.WriteLine("funciona?");
            Console.WriteLine(primo.IsPrime(4));
        }
    }
}
