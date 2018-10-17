using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static string strCheck;
        static void Main(string[] args)
        {

            string[] names = { "Clayton", "Jim", "Bob", "Billy Bob", "Maurico",
            "Heemung", "Sammie", "Sam", "Dumb Person Bill", "Taylor", "Matthew",
            "Sean0", "Jacky", "Tony", "Heather", "Dan the Man", "Dan not the Man", "Rodney",
            "Cara","Drug Guy"};
            string[] hometown = { "Indy", "JimVille", "Ja", "Billy Bobbyville", "US",
            "Korea", "Indiana", "Country", "the dump", "Cali", "Space",
            "Knightstown", "Jackyville", "Tony Town", "Heats", "Manville", "not manville", "ktown",
            "Indianapolis","Hell"};
            string[] food = { "ice cream", "carrots", "pizza", "hot dogs", "fries",
            "chips", "dog food", "hamburger", "grass", "apples", "steak",
            "beer", "baked potatos", "hero dogs", "bacon", "24oz steak", "babies", "bananas",
            "fruit","coke"};

            int studentNum, orginalNum;
            bool contYN = true, yesOrNo = true, validData = true;
            string userAnswer;

            Console.Write("Welcome to Our C# Class. ");

            while (contYN)
            {
                orginalNum = UserInput();
                studentNum = orginalNum - 1;
                try
                {
                    Console.WriteLine("Student {0} is {1}. What would you like to know" +
                        "about {2}? (enter of 'hometown' or 'favorite food'", orginalNum,
                        names[studentNum], names[studentNum]);

                    userAnswer = Console.ReadLine().ToLower();
                    Answers(validData, userAnswer, names, hometown, food, studentNum);

                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Error: please a number between 1 and 20." +
                        " Try Again\n");
                    orginalNum = UserInput();
                    studentNum = orginalNum - 1;
                }

            }
        }

        static int UserInput()
        {
                int userInput;
                Console.WriteLine("Which student would you" +
                " like to learn more about? (enter a number 1-20)");
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    return userInput;
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Please check your input");
                    return UserInput();
                } 
        }

        static bool ContinueMethod()
        {
            strCheck = Console.ReadLine().ToLower();
            if (strCheck == "yes")
            {
                return true;
            }
            else if (strCheck == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("You entered something besides yes or no.\n " +
                    "Please Try Again. 'yes' or 'no'");
               return ContinueMethod();
            }
        }
        static void Answers(bool validData, string userAnswer,string[] names,
            string[]hometown,string[] food, int studentNum )
        {
            while (validData)
            {
                switch (userAnswer)
                {
                    case "hometown":
                        {
                            Console.WriteLine("{0} hometown is {1}. Would you like to know more?" +
                                " (enter 'yes' or 'no')", names[studentNum], hometown[studentNum]);

                            if (!ContinueMethod())
                            {
                                validData = false;
                            }
                        }
                        break;

                    case "favorite food":
                        {
                            Console.WriteLine("{0} favorite food is {1}. Would you like to know more?" +
                                " (enter 'yes' or 'no')", names[studentNum], food[studentNum]);
                            if (!ContinueMethod())
                            {
                                validData = false;
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("That data does not exist. Please Try Again: \n");
                            break;
                        }

                }
                if (validData == true)
                {
                    Console.WriteLine("What do you want to know about {0}? (enter of 'hometown' or " +
                        "'favorite food')", names[studentNum]);
                    userAnswer = Console.ReadLine().ToLower();
                }
            }
        }

    }
}
