using System;
public class ControlStatements
{
    public static void Main(string[] args)
    {
        // If statement
        int num = 7;
        if (num > 5)
        {
            Console.WriteLine("The num is greater than 5");
        }

        // For loop
        int val = 0;
        for (int i = 0; i < num; i++)
        {
            val++;
            Console.WriteLine(val);
        }

        // If-else statement
        int age = 20;
        if (age >= 18)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are a minor");
        }

        // If-else-if 
        int grade = 63;
        if (grade >= 70)
        {
            Console.WriteLine("You got an A");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You got a B");
        }
        else if (grade >= 50)
        {
            Console.WriteLine("You got a C");
        }
        else
        {
            Console.WriteLine("You got a Pass");
        }

        // Switch statement
        string dayOfWeek = "Wednesday";
        switch (dayOfWeek)
        {
            case "Monday":
                Console.WriteLine("Today is Monday");
                break;
            case "Tuesday":
                Console.WriteLine("Today is Tuesday");
                break;
            case "Wednesday":
                Console.WriteLine("Today is Wednesday");
                break;
            case "Thursday":
                Console.WriteLine("Today is Thursday");
                break;
            case "Friday":
                Console.WriteLine("Today is Friday");
                break;
            case "Saturday":
                Console.WriteLine("Today is Saturday");
                break;
            case "Sunday":
                Console.WriteLine("Today is Sunday");
                break;
            default:
                Console.WriteLine("Invalid day of week");
                break;
        }
    }
}