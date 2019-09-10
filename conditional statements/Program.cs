using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many years experience do you have in professional programming?");
                int years = int.Parse(Console.ReadLine());
                if (years == 0)
                    Console.WriteLine("needs lot of practise");
                else if (years == 1)
                    Console.WriteLine("looks likeu have a little experience");
                else if (years == 2)
                    Console.WriteLine("wow! You've been doing this for a little while");
                else
                    Console.WriteLine("you are a expert");
            }
            catch
            {
                Console.WriteLine("please enter an integer");
            }
        }
    }
}
