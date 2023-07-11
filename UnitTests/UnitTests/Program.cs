using NUnit.Framework;
using Xunit;

namespace UnitTestingExample
{
    public class Test
    {
        public class Program
        {
            public bool IsPrime(int number)
            {
                if (number < 2)
                {
                    return false;
                }

                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public class PrimeServiceTests
        {
            [Fact]
            public void IsPrime_ReturnsTrue()
            {
                var service = new Program();
                Assert.True(service.IsPrime(2));
                Assert.True(service.IsPrime(3));
                Assert.True(service.IsPrime(5));
            }

            [Fact]
            public void IsPrime_ReturnsFalse()
            {
                var service = new Program();
                Assert.False(service.IsPrime(1));
                Assert.False(service.IsPrime(4));
                Assert.False(service.IsPrime(6));
            }
        }

        public static void Main(string[] args)
        {
            var service = new Program();
            Console.WriteLine("2 is prime: " + service.IsPrime(2));
            Console.WriteLine("3 is prime: " + service.IsPrime(3));
            Console.WriteLine("4 is prime: " + service.IsPrime(4));
            Console.WriteLine("5 is prime: " + service.IsPrime(5));
        }
    }
   
}