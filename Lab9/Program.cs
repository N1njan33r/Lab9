using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static string userInput;

        static void Main(string[] args)
        {
            Initialize();
            string selectedStudent = "";
            int studentIndex = 0;
            while (userInput != "")
            {
                if (int.TryParse(userInput, out int value))
                {
                    studentIndex = value;
                    try
                    {
                        selectedStudent = Students[studentIndex - 1];
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("ID must be between 1 and 20");
                    }

                    Console.WriteLine($"Student chosen: ({userInput})-{selectedStudent}");
                }

                break;
            }

            Console.Write($"What would you like to know about {selectedStudent}? (height or birthdate):");
            userInput = Console.ReadLine();

            if (userInput == "height")
            {
                Console.WriteLine($"{selectedStudent} is {Heights[studentIndex]} tall.");
            }
            else if (userInput == "birthdate")
            {
                Console.WriteLine($"{selectedStudent} was born on {Birthdates[studentIndex]}.");
            }

            Console.ReadKey();
        }

        public static void Initialize()
        {
            Console.Write("Welcome to Class 1-A. Please choose a student to learn more information about them. (enter a number 1-20): ");
            userInput = Console.ReadLine();

        }

        public static List<string> Students = new List<string>
        {
            "Aoyama Yuga",
            "Ashido Mina",
            "Asui Tsuyu",
            "Hagakure Toru",
            "Iida Tenya",
            "Jiro Kyoka",
            "Kaminari Denki",
            "Katsuki Bakugo",
            "Kirishima Eijiro",
            "Koda Koji",
            "Midoriya Izuku",
            "Mineta Minoru",
            "Ojiro Mashirao",
            "Sato Rikido",
            "Sero Hanta",
            "Shoji Mezo",
            "Todoroki Shoto",
            "Tokoyami Fumikage",
            "Uraraka Ochaco",
            "Yaoyorozu Momo"
        };

        public static List<string> Heights = new List<string>
        {
            "168cm",
            "159cm",
            "150cm",
            "154cm",
            "179cm",
            "154cm",
            "168cm",
            "172cm",
            "170cm",
            "186cm",
            "166cm",
            "108cm",
            "169cm",
            "185cm",
            "177cm",
            "187cm",
            "176cm",
            "158cm",
            "156cm",
            "173cm"
        };

        public static List<string> Birthdates = new List<string>
        {
            "30-May",
            "30-Jul",
            "12-Feb",
            "16-Jun",
            "22-Aug",
            "1-Aug",
            "29-Jun",
            "20-Apr",
            "16-Oct",
            "1-Feb",
            "15-Jul",
            "8-Oct",
            "28-May",
            "19-Jun",
            "28-Jul",
            "25-Feb",
            "11-Jan",
            "30-Oct",
            "27-Dec",
            "23-Sep"
        };
    }
}
