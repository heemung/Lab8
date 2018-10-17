using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
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

            int studentNum;
            bool contYN = true, validdata, caseTemp;
            string userAnswer;
            string userWantMore;

            Console.Write("Welcome to Our C# Class. ");

            while (contYN)
            {
                validdata = true;
                studentNum = UserInput();
                Console.WriteLine("Student {0} is {1}. What would you like to know" +
                    "about {2}? (enter of 'hometown' or 'favorite food'",studentNum +1,
                    names[studentNum+1], names[studentNum+1]);
                userAnswer = Console.ReadLine().ToLower();
                while (validdata)
                {
                    caseTemp = true;
                    switch(userAnswer)
                        {
                        case "hometown":
                            {
                                Console.WriteLine("{0} hometown is {1}. Would you like to know more?" +
                                    " (enter 'yes' or 'no')", names[studentNum], hometown[studentNum]);
                                while(caseTemp == true)
                                { 
                                userWantMore = Console.ReadLine().ToLower();
                                    if (userWantMore == "yes")
                                    {
                                        validdata = true;
                                        caseTemp = false;
                                    }
                                    else if (userWantMore == "no")
                                    {
                                        validdata = false;
                                        caseTemp = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Enter something besides yes or no. " +
                                            "Please Try Again\nDid you want to know more? 'yes' or 'no'");
                                        caseTemp = true;
                                    }
                                }
                                break;
                            }
                        case "favorite food":
                            {
                                Console.WriteLine("{0} is {1}. Would you like to know more?" +
                                    " (enter 'yes' or 'no')", names[studentNum], food[studentNum]);
                                while (caseTemp == true)
                                {
                                    userWantMore = Console.ReadLine().ToLower();
                                    if (userWantMore == "yes")
                                    {
                                        validdata = true;
                                        caseTemp = false;
                                    }
                                    else if (userWantMore == "no")
                                    {
                                        validdata = false;
                                        caseTemp = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Enter something besides yes or no. " +
                                            "Please Try Again/n Did you want to know more? 'yes' or 'no'");
                                        caseTemp = true;
                                    }
                                }
                                break;
                            }
                    }
                    if (validdata == true)
                    {
                        Console.WriteLine("What do you want to know about {0}? (enter of 'hometown' or " +
                            "'favorite food'", names[studentNum]);
                        userAnswer = Console.ReadLine().ToLower();
                    }
                    /*if (userAnswer == "hometown")
                    {
                        Console.WriteLine("{0} is {1}. Would you like to know more?" +
                            " (enter 'yes' or 'no')",names[studentNum], hometown[studentNum]);
                        userAnswer = userAnswer = Console.ReadLine().ToLower();


                    }
                    else if (userAnswer == "favorite food")
                    {
                        Console.WriteLine("{0} is {1}.", names[studentNum], food[studentNum]);
                        userAnswer = userAnswer = Console.ReadLine().ToLower();
                    }
                    else
                        Console.WriteLine("That data does not exist. Please try again." +
                            "(enter 'hometown' or 'favorite food'");
                    userAnswer = userAnswer = Console.ReadLine().ToLower();*/
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

        static string CheckUserAnswer(string temp)
        {
            switch(temp)
            {
                case "hometown":
                    return "hometown";
                case "favorite food":
                    return "favorite food";
                default: return null;
            }
        }

    }
}
