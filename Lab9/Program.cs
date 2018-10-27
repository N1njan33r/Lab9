using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Class 1-A. Please choose a student to learn more information about them. (enter a number 1-20): ");
            string userInput;
            try
            {
                userInput = Console.ReadLine();
            }
            catch (IndexOutOfRangeException e)
            {
                throw e;
            }
            Console.WriteLine($"Student chosen: {userInput}");

            Console.ReadKey();
        }
    }

    public enum Student
    {
        Sally,

        Daniel,

        Markus,

        Galinda,

        Peter,

        Stephen,

        Tyler,

        Maddie,

        June,

        Roger,

        Frank,


    }
}
