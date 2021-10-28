using System;
using System.Collections.Generic;

namespace Calcutron_5000
{
    class Calcugram
    {
        static List<string> calclist = new List<string>();
        static string calcutron = "Welcome to Calcutron 5000";
        static string line = "--------------------------\n";


        static void calculator()
        {

            bool calculating = true;


            while (calculating)
            {

                double num1 = 0;
                double num2 = 0;

                Console.Write("Enter your first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());


                Console.Write("Enter your second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                
                
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

                Console.WriteLine("How will you proceed?");
                Console.WriteLine("a = new mathulation");
                Console.WriteLine("b = check previous mathulation");
                Console.WriteLine("c = exit program\n");
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    Console.Clear();
                    calculator();
                }
                else if (choice == "b")
                {
                    Console.Clear();
                    foreach (string pastCal in calclist)
                    {
                        Console.WriteLine(pastCal);
                    }

                }
                else if (choice == "c")
                {
                    Console.Clear();
                    Console.WriteLine("You're sufficiently calculated. Good bye.");
                    calculating = (false);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You did not comply, Calcutron terminated.");
                    calculating = (false);

                }
            }
            Console.ReadLine();

        }








        static void Main(string[] args)

        {
            Console.WriteLine(calcutron);
            Console.WriteLine(line);






            string name = "";



            Console.Write("Type the name you're assigned: ");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(calcutron);
            Console.WriteLine(line);
            Console.WriteLine($"Confirmed ID: {name}");
            Console.WriteLine(line);



            calculator();










        }

    }
}
