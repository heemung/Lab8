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
            //made 3 arrays with data
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

            //init vars and loop booleans
            int studentNum, orginalNum;
            bool contYN = true, validData = true;
            string userAnswer;

            //start of program, will only run cw once
            Console.Write("Welcome to Our C# Class. ");

            //all of program in while loop, will run until false
            while (contYN)
            {
                if (contYN)
                {
                    //setting user input to match the array input for the user
                    //example user enters 1 and will pull array element 0
                    orginalNum = UserInput();
                    studentNum = orginalNum - 1;
                    //this 'try' will run on the whole program but will catch on the first
                    //cw when calling the arrays. if the array is out of index it catch.
                    try
                    {
                        Console.WriteLine("Student {0} is {1}. What would you like to know" +
                            "about {2}? (enter of 'hometown' or 'favorite food'", orginalNum,
                            names[studentNum], names[studentNum]);

                        //passes user answer into Answers method.
                        userAnswer = Console.ReadLine().ToLower();
                        Answers(validData, userAnswer, names, hometown, food, studentNum);

                        //asks if user wants to continue calls ContinueMEthod which returns bool
                        Console.WriteLine("Do you want to run this again? 'Yes' or 'No'");
                        contYN = ContinueMethod();

                    }

                    //catches try and ask user to try again resets student num to 0 to prevent 
                    //number adding 
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Error: please a number between 1 and 20." +
                            " Try Again\n");
                        studentNum = 0;
                    }
                }

            }
            //while false exits program
            Console.WriteLine("Thank You Come Again!");
            Console.ReadLine();
        }

        //user input method. uses recursion to make sure users inputs valid method.
        //try catch , catches if user input is number or not.
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

        // method for user input yes or no and returns bools.
        //uses recursion when not yes or no
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

        //
        static void Answers(bool validData, string userAnswer,string[] names,
            string[]hometown,string[] food, int studentNum )
        {
            //asks user if they want more info about the student while true.
            while (validData)
            {
                //switch case for different user inputs, hometown, food, default
                switch (userAnswer)
                {
                    case "hometown":
                        {
                            //wrties out hometown of user passing arrays and indexes
                            Console.WriteLine("{0} hometown is {1}. Would you like to know more?" +
                                " (enter 'yes' or 'no')", names[studentNum], hometown[studentNum]);

                            //ask yes or no and sets while loop
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
                        //default if doesnt match case and while loop will continue to run
                    default:
                        {
                            Console.WriteLine("That data does not exist. Please Try Again: \n");
                            break;
                        }

                }
                //reminding user what to enter before while loop runs again, sets user answer
                //to new value for case condition
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
