using System;
using System.Collections.Generic;

namespace Calcutron_5000
{
    class Calcugram
    {
        static List<string> calclist = new List<string>();
        static string calcutron = "Welcome to Calcutron 5000";
        static string line = "--------------------------\n";
        static string name = "";
        static void Main(string[] args)
        {

            calculator();

        }
        
        //The master function
        static void calculator()
        {

            bool calculating = true;


            while (calculating)
            {
                

                double num1 = 0;
                double num2 = 0;


                
                header();
                // Verifies number 1 for calculator
                while (true)
                {
                    

                    Console.Write("Enter your first number: ");
                    if (double.TryParse(Console.ReadLine(), out num1)) 
                    {
                        //number 1 is verified
                        break;
                    }
                    else 
                    {
                        header();
                        Console.WriteLine("Number not valid");
                    }

                }
                header();
                // Verifies number 2 for calculator
                while (true)
                {
                    

                    Console.Write("Enter your second number: ");
                    if (double.TryParse(Console.ReadLine(), out num2))
                    {
                        //number 2 is verified
                        break;
                    }
                    else
                    {
                        header();
                        Console.WriteLine("Number not valid");
                    }

                }

                


                header();
                Console.WriteLine($"First number: {num1} Second number: {num2}");
                Console.WriteLine("\n");
                Console.WriteLine("+  Additate: ");
                Console.WriteLine("-  Subtractiate: ");
                Console.WriteLine("*  Multiplifly: ");
                Console.WriteLine("/  Dividise: ");
                Console.WriteLine("\n");
                Console.Write("What's your targeted operator?: ");
                

               

                switch (Console.ReadLine())
                {

                    case "+":
                        string addResult = $"{ num1 } + { num2} = {num1 + num2}";
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your Result: {addResult}\n");
                        calclist.Add(addResult);
                        break;
                    case "-":
                        string subResult = $"{ num1 } - { num2} = {num1 - num2}";
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your Result: {subResult}\n");
                        calclist.Add(subResult);
                        break;
                    case "*":
                        string multiResult = $"{ num1 } * { num2} = {num1 * num2}";
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your Result: {multiResult}\n");
                        calclist.Add(multiResult);
                        break;
                    case "/":
                        string divResult = $"{ num1 } / { num2} = {num1 / num2}";
                        Console.WriteLine("\n");
                        Console.WriteLine($"Your Result: {divResult}\n");
                        calclist.Add(divResult);
                        break;
                    default:
                        {
                            Console.WriteLine("Not an operator");
                        }
                        break;




                }

                calculating = Menu();
            }
            Console.ReadLine();

        }

        static bool Menu()
        {
            while (true)
            {
                Console.WriteLine("How will you proceed?");
                Console.WriteLine("a = new mathulation");
                Console.WriteLine("b = check previous mathulation");
                Console.WriteLine("c = exit program\n");
                string choice = Console.ReadLine();

                if (choice == "a")
                {



                    return true;
                }

                else if (choice == "b")
                {
                    header();
                    int nrCalc = calclist.Count;
                    Console.WriteLine($"{name} has made {nrCalc} calculations."); //Shows number of calculations with text.
                    foreach (string pastCal in calclist)
                    {
                        Console.WriteLine(pastCal);
                    }
                    Console.WriteLine();
                    Console.WriteLine(line);
                    

                }
                else if (choice == "c")
                {
                    Console.Clear();
                    Console.WriteLine("You're sufficiently calculated. Good bye.");
                    return false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You did not comply, Calcutron terminated.");
                    return false;

                }

            }
        }


        //Displays name of user and name of calculator
        static void header()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(calcutron);
                Console.WriteLine(line);


                if (name.Length == 0)
                {
                    Console.Write("Type the name you're assigned: ");
                    name = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Confirmed ID: {name}");
                    Console.WriteLine(line);
                    break;
                }
            }

        }

    }

}
