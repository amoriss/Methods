using System;

namespace MethodsExercise
{
    class Program
    {
        
        public static string timeMeasurement;
        public static string jobTitle;
        public static string verb;
        public static string state;
         

        public static void MadLibsInput()
        {
            Console.WriteLine("Enter in a measure of time: ");
            timeMeasurement = Console.ReadLine();
            Console.WriteLine("Enter in a job title: ");
            jobTitle = Console.ReadLine();
            Console.WriteLine("Enter in a verb: ");
            verb = Console.ReadLine();
            Console.WriteLine("Enter in a vacation spot: ");
            state = Console.ReadLine();
        }

        public static int Add(params int[] arr)
        {
            int sum = 0;
            foreach(var x in arr)
            {
                sum += x;
            }
            return sum;
        }

       
        public static int Subtract(params int[] array)
        {
             var startingPoint = array[0];
              for (int i = 1; i < array.Length; i++)
                {
                    startingPoint-= array[i];
                }
              return startingPoint;          

        }

        public static double Multiply(params int [] array)
        {
            var answer = 1; 
            foreach (var x in array)
            {
                answer *= x; 
            }
            return answer; 
        }

        public static double Divide ()
        {
            Console.WriteLine("You will choose two number to divide.");
            Console.WriteLine("Enter in first number to divide from: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in second number that you want to divide by: ");
            var num2 = double.Parse(Console.ReadLine());
            return num1 / num2; 
        }

        public static double Modulus()
        {
            Console.WriteLine("You will choose two numbers to divide from " +
                "in order to find the remainder.");
            Console.WriteLine("Enter in first number to divide from: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in second number that you want to divide by: ");
            var num2 = double.Parse(Console.ReadLine());
            return num1 % num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is Mad Libs!");
            Console.WriteLine("Give answers to the following prompts.");
            MadLibsInput();
            Console.WriteLine($" Now this is the story all about how,\n " +
                $"My life got flipped - turned upside down,\n " +
                $"And I'd like to take a {timeMeasurement}, \n " +
                $"just {verb} right there, I'll tell you how I \n " +
                $"became the {jobTitle } of a " +
                $"town called {state}.");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("You will choose two number to add.");
            Console.WriteLine("Enter in first number: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in second number: ");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Adding those two numbers equals to: { Add(num1, num2) } ");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("You will subtract two numbers.");
            Console.WriteLine("Enter in first number to subtract from: ");
            var sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in number you want to subtract: ");
            var sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Subtracting those two numbers will give you: { Subtract(sub1, sub2) } ");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("You will choose two number to multiply.");
            Console.WriteLine("Enter in first number: ");
            var mult1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in second number: ");
            var mult2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplying those two numbers will give you: { Multiply(mult1, mult2) } ");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Dividing those two numbers will give you: { Divide() } ");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine($"The remainder of those two numbers will give you: { Modulus() } ");




        }


    }
}
