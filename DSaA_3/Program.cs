using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool main = true;
            while (main) {
                Console.Clear();
                bool numCheck = true;
                bool selectChoice = true;
                string Mode = "";
                int[] table = new int[100];
                int numUserinput = 0;
                Random intRnd = new Random();

                for (int i = 0; i < table.Length; i++) {  // This is the Loop that assigns a random number element to each index and prints it out
                    table[i] = intRnd.Next(0, 10);
                    Console.Write($"[{table[i]}] ");
                }

                Console.Write("\n\nPlease Input a Number from [0 - 9] you want to Find: ");
                while (numCheck) {                       // This loop is reponsible for checking the user input for the number
                    numUserinput = 0;
                    string firstUserinput = Console.ReadLine();

                    if (int.TryParse(firstUserinput, out numUserinput) == true) {  // This checks if the input is a integer
                        if (numUserinput <= 9)
                            numCheck = false;
                        else
                            Console.Write("\nPlease Input a Number Between [0 - 9] only : ");
                    }
                    else
                        Console.Write("\nPlease Input a Valid Integer: ");
                }

                // While this, this is reponsible for checking the user input on the mode
                // There are 2 mode whether it is a first instance or all instance
                Console.Write("\nPlease Type [1] for First Instance or [2] for All Instance: ");
                while (selectChoice) {
                    string choiceUserinput = Console.ReadLine();
                    if (choiceUserinput == "1") {
                        selectChoice = false;
                        Mode = "1";
                    }
                    else if (choiceUserinput == "2") {
                        selectChoice = false; Mode = "2";
                    }
                    else
                        Console.Write("\nPlease Input a Valid Mode: ");
                }

                // And here is the main logic where it checks each element
                // It also assigns them a color appropriately base on the mode chosen

                Console.Clear();
                if (Mode == "1") {  // This is for First Instance Mode
                    int insCount = 0;
                    for (int i = 0; i < table.Length; i++) {
                        if (table[i] == numUserinput) {
                            insCount++;
                            if (insCount == 1) // Here it checks if it is the First Instance and assigns the Color Green
                                Console.ForegroundColor = ConsoleColor.Green;
                            else               // If not, it colors it red
                                Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else                   // If it is not a match then it just colors the text default
                            Console.ResetColor();
                        Console.Write($"[{table[i]}] ");
                    }
                }
                else { // This is for All Instance Mode
                    for (int i = 0; i < table.Length; i++) {
                        if (table[i] == numUserinput) // Here it checks if the element is same as the userinput then colors it green
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                            Console.ResetColor();      // and default color if not a match
                        Console.Write($"[{table[i]}] ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine("\n\nDo you Want to Repeat? Type Y/Yes");
                string userRepeat = Console.ReadLine().ToUpper();
                if (userRepeat != "Y" && userRepeat != "YES") // This just checks the input of the user if it wants to repeat or not
                    main = false;
   
            }
        }
    }
}
