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
            Students students = new Students();
            string userInput = Initialize();
            string selectedStudent = "";
            int studentIndex = 0;
            //do
            //{
            //    if (int.TryParse(userInput, out int value))
            //    {
            //        studentIndex = value - 1;
            //        try
            //        {
            //            selectedStudent = Students.Names[studentIndex];
            //        }
            //        catch (ArgumentOutOfRangeException e)
            //        {
            //            Console.WriteLine("ID must be between 1 and 20");
            //        }

            //        Console.WriteLine($"Student chosen: ({userInput})-{selectedStudent}");
            //    }

            //    break;
            //} while (true);

            //Console.Write($"What would you like to know about {selectedStudent}? (height or birthdate):");
            //userInput = Console.ReadLine();

            //if (userInput == "height")
            //{
            //    Console.WriteLine($"{selectedStudent} is {Students.Heights[studentIndex]} tall.");
            //}
            //else if (userInput == "birthdate")
            //{
            //    Console.WriteLine($"{selectedStudent} was born on {Birthdates[studentIndex]}.");
            //}

            Console.ReadKey();
        }

        public static string Initialize()
        {
            Console.Write("Welcome to Class 1-A. Please choose a student to learn more information about them. (enter a number 1-20): ");
            return Console.ReadLine();            
        }        
    }
}
