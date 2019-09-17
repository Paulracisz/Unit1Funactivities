using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Fun_Activities
{
    class Program
    {
        static void Main(string[] args)
        {
            //greet the user, and list the user's option.
            Console.WriteLine("Greetings user, welcome to the fun activities reccomendation machine!");
            Console.WriteLine("What fun activity are you in the mood for?");
            Console.WriteLine("1.Action");
            Console.WriteLine("2.Chill Times");
            Console.WriteLine("3.Danger");
            Console.WriteLine("4.Good Food");
            // Using a string to collect the user's selection because Readline cannot be defined as an int
            String checkSelection = Console.ReadLine();
            int numberSelection = Convert.ToInt32(checkSelection);
            if (numberSelection <= 4)
            {
                
            
            String userSelection = Console.ReadLine();
            //Converting userSelection into an int.
            int intSelection = Convert.ToInt32(userSelection);
                //our if else statements to determine where the user will be traveling to
                if (intSelection is 1)
                {
                    Console.WriteLine("You have selected Action.");
                    Console.WriteLine("You should go Stock Car Racing!");

                }
                else if (intSelection is 2)
                {
                    Console.WriteLine("You have selected Chill Times.");
                    Console.WriteLine("You should go Hiking!");
                }
                else if (intSelection is 3)
                {
                    Console.WriteLine("You have selected Danger.");
                    Console.WriteLine("You should go Skydiving!");

                }
                else if (intSelection is 4)
                {
                    Console.WriteLine("You have selected Good Food");
                    Console.WriteLine("You should go to Taco-Bell!");

                }
                else if (intSelection > 4)
                {
                    Console.WriteLine("Error, please enter numbers 1 through 4.");
                
                    //Now we need to get a new string for the input of how many people the user is bringing with them
                    //Convert the string into an int, so we can use less than and greater than in our else if statements
                    if (intSelection <= 4)
                    {
                        Console.WriteLine("How many people are you bringing with you: ");
                        String peopleInput = Console.ReadLine();
                        Console.WriteLine($"You have selected {peopleInput}");
                        int intPeople = Convert.ToInt32(peopleInput);
                        if (intPeople is 0)
                        {
                            Console.WriteLine("You should travel in your sneakers!");
                        }
                        else if (intPeople < 5)
                        {
                            Console.WriteLine("You should travel in a sedan!");
                        }
                        else if (intPeople < 0)
                        {
                            Console.WriteLine("Please enter a positive number!");
                            Thread.Sleep(5000);
                            System.Environment.Exit(0);
                        }
                        else if (intPeople <= 10)
                            Console.WriteLine("You should travel in a Volkswagen Bus!");
                        else if (intPeople > 11)
                        {
                            Console.WriteLine("You shold travel in an airplane!");
                        }
                        else if (intPeople is 11)
                        {
                            Console.WriteLine("you should travel in an airplane!");
                        }
                    }
                    }
                    Console.WriteLine("Thank you for using the Fun Activities Reccomendation program. Have a nice day!");
                }
            }
        }
    }




