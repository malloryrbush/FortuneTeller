using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARING
            string firstName = "";
            string lastName = "";
            string color = "";
            int age;
            double birthMonth;
            int siblings;  
            //END DECLARE

            //CONSOLE ASK QUESTIONS
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            lastName = Console.ReadLine();
            //END CONSOLE ASK QUESTIONS

            //AGE MOD
            Console.WriteLine("Please enter your age.");
            age = int.Parse(Console.ReadLine());

            if (age % 2 == 0)
            {
                age = age + 30;
            }
            else
            {
                age = age + 35;
            }
            //END AGE
            //I think I did this wrong (should have stored as a bool?) but I'm not sure I totally understand why I would use a bool instead of just writing if age % 2 do one thing, else do another thing. 

            //IF ELSE IF BIRTH MONTH
            Console.WriteLine("In which month were you born?");
            birthMonth = int.Parse(Console.ReadLine());

            if ((birthMonth >= 1) && (birthMonth <= 4))
            {
                birthMonth = 16.50;
            }
            else if ((birthMonth >= 5) && (birthMonth <= 8))
            {
                birthMonth = 1000000;
            }
            else if ((birthMonth >= 9) && (birthMonth <= 12))
            {
                birthMonth = 100000;
            }
            else if ((birthMonth <1) || (birthMonth >12))
            {
                birthMonth = 0.00;
            }
            //END BIRTHMONTH

            //IF STATEMENT / FAVE COLOR HELP 
            Console.WriteLine("What is your favorite color from ROYGBIV?");
            color = Console.ReadLine();

            if (color == "help")
            {
                Console.WriteLine("ROYGBIV IS AN ACRONYM FOR THE COLORS IN THE RAINBOW. R = RED. O = ORANGE. Y = YELLOW. G = GREEN. B = BLUE. I = INDIGO. V = VIOLET.");
                Console.WriteLine("What is your favorite color from ROYGBIV?");
                color = Console.ReadLine();
            }
            //END HELP MENU

            //SWITCH STATEMENTS / ROYGBIV
            switch (color)
            {
                case "r":
                    color = "Lexus RX";
                    break;

                case "o":
                    color = "Toyota Corolla";
                    break;

                case "y":
                    color = "Cadillac CTS";
                    break;

                case "g":
                    color = "Harley V-Rod";
                    break;

                case "b":
                    color = "Range Rover";
                    break;

                case "i":
                    color = "Hummer";
                    break;

                case "v":
                    color = "Private Jet";
                    break;
            }
            //END ROYGBIV SWITCH STATEMENTS


            //SIBLINGS IF ELSE IF STATEMENTS
            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());

            if (siblings == 0)
            {
                Console.WriteLine((firstName) + " " + (lastName) + " will retire in " + (age) + " years with $" + (birthMonth) + " in the bank, a vacation home in Hawaii, and a " + (color) + ".");
            }
            else if (siblings == 1)
            {
                Console.WriteLine((firstName) + " " + (lastName) + " will retire in " + (age) + " years with $" + (birthMonth) + " in the bank, a vacation home in Switzerland, and a " + (color) + ".");
            }
            else if (siblings == 2)
            {
                Console.WriteLine((firstName) + " " + (lastName) + " will retire in " + (age) + " years with $" + (birthMonth) + " in the bank, a vacation home in Italy, and a " + (color) + ".");
            }
            else if (siblings == 3)
            {
                Console.WriteLine((firstName) + " " + (lastName) + " will retire in " + (age) + " years with $" + (birthMonth) + " in the bank, a vacation home in Greece, and a " + (color) + ".");
            }
            else if (siblings >= 4)
            {
                Console.WriteLine((firstName) + " " + (lastName) + " will retire in " + (age) + " years with $" + (birthMonth) + " in the bank, a vacation home in Flint, MI, and a " + (color) + ".");
            }


            //////FORTUNE
            //Console.WriteLine((firstName) + " " + (lastName) + " will retire in " + (age) + " years with $" + (birthMonth) + " in the bank, a vacation home in " + (siblings) + ", and a " + (color) + ".");
            //I had this on its own initially but I could not figure any way to store siblings as an int and have that make the variable equivalent to a string (the city for the vacation home.)
            //So I had to add this sentence repeatedly as a console.writeline in the siblings if else if statements and I know it's wrong so sorry. 
        }
    }
}
