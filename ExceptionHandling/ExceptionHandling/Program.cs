using System;

namespace ExceptionHandling
{
    class Program
    {
       public static void Main(string[] args)
        {
            // Create a string variable.
            string str = "Jay";

            try
            {
                // Try to access the length of the string.
                int length = str.Length;
            }
            catch (NullReferenceException e)
            {
                // Handle the exception.
                Console.WriteLine(e);
            }
            finally
            {
                // This code will always execute, regardless of whether or not an exception is thrown.
                Console.WriteLine("The finally block has executed.");
            }

            // Exit the program.
            Console.ReadLine();
        }
    }
}