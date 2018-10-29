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
            // James - for checking Strings, you can use string.Equals(""), then put either == false or a "!" in front
            // of the string, so something like this.
            // while (!string.userInput.Equals("");
            while (userInput != "")
            {
                if (int.TryParse(userInput, out int value))
                {
                    studentIndex = value - 1;
                    try
                    {
                        selectedStudent = Students[studentIndex];
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("ID must be between 1 and 20");
                    }

                    // James - nice use of indexing for getting the correct user. 
                    Console.WriteLine($"Student chosen: ({userInput})-{selectedStudent}");
                }

                break;
            }

            Console.Write($"What would you like to know about {selectedStudent}? (height or birthdate):");
            userInput = Console.ReadLine();

            // James - I would validate for this information
            if (userInput == "height")
            {
                Console.WriteLine($"{selectedStudent} is {Heights[studentIndex]} tall.");
            }
            // James - I would also use validation for this input, also for checking if a string equals something, 
            // just like at the begenning of your app, you can use something like userInput.Equals("birthdate", StringComparison.OrdinalIgnoreCase);
            else if (userInput == "birthdate")
            {
                Console.WriteLine($"{selectedStudent} was born on {Birthdates[studentIndex]}.");
            }

            Console.ReadKey();
        }

        public static void Initialize()
        {
            // James - I like that this is in a seperate method.  I would change the name to something more meaningful like, GetUserNumber(),
            // I would also have this method return a string and store that string value where this method is called instead of using a 
            // field at the top of the file.      ie. var userInput = Initialize();
            Console.Write("Welcome to Class 1-A. Please choose a student to learn more information about them. (enter a number 1-20): ");
            userInput = Console.ReadLine();

        }

        // James - instead of three LIsts, I would consider using a Student class, and store each student into a single List
        // so like var students = List<Student>();
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
