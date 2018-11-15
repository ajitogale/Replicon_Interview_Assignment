using System;


   public class Program
    {
       public static void Main(string[] args)

        {
            long fact = 0;
            Console.WriteLine("Enter a number");

            int number = Convert.ToInt32(Console.ReadLine());
	    Console.Write(" Factorial is ");

            for (int i = 0; i < number; i++)
            {
                 fact = GetFactorial(number);           
                 Console.Write((number - i)+"*");
            }
            Console.Write(" so output "+fact);
            Console.ReadLine();
        }

        private static long GetFactorial(int number)
        {
           if (number == 0)
           {
               return 1;
           } 

           return number * GetFactorial(number - 1);            
        }
    }