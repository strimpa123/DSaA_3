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
                int[] table = new int[100];               // Creates a 100 index array [Box Shape]
                int numUserinput = 0;
                Random intRnd = new Random();

                for (int i = 0; i < table.Length; i++) {  // This is the Loop that assigns a random number element to each index and prints it out [Box Shape]
                    table[i] = intRnd.Next(0, 10);
                    Console.Write($"[{table[i]}] ");
                }

                Console.Write("\n\nPlease Input a Number from [0 - 9] you want to Find: ");
                while (numCheck) {                                                           // This loop is reponsible for checking the user input for the number [Diamond Shape]
                    numUserinput = 0;
                    string firstUserinput = Console.ReadLine();                              // For user Number Choice [Rhombus Shape]

                    if (int.TryParse(firstUserinput, out numUserinput) == true) {            // This checks if the input is a Valid integer [Diamond Shape]
                        if (numUserinput <= 9)
                            numCheck = false;
                        else
                            Console.Write("\nPlease Input a Number Between [0 - 9] only : "); // Error for Invalid Input [Rhombus Shape]
                    }
                    else
                        Console.Write("\nPlease Input a Valid Integer: ");
                }

                // While this, this is reponsible for checking the user input on the mode  [Diamond Shape]
                // There are 2 mode whether it is a first instance or all instance
                Console.Write("\nPlease Type [1] for First Instance or [2] for All Instance: ");
                while (selectChoice) {
                    string choiceUserinput = Console.ReadLine();                     // For User Choice of Mode [Rhombus Shape]
                    if (choiceUserinput == "1") {
                        selectChoice = false;
                        Mode = "1";
                    }
                    else if (choiceUserinput == "2") {
                        selectChoice = false; Mode = "2";
                    }
                    else
                        Console.Write("\nPlease Input a Valid Mode: ");              // Error for Invalid Input [Rhombus Shape]
                }

                // And here is the main logic where it checks each element
                // It also assigns them a color appropriately base on the mode chosen   

                Console.Clear();
                if (Mode == "1") {   // This is for First Instance Mode  [Diamond Shape]
                    int insCount = 0;
                    for (int i = 0; i < table.Length; i++) {
                        if (table[i] == numUserinput) {                              // Here if User Input and Element Match [Diamond Shape]
                            insCount++; 
                            if (insCount == 1)                                       // Checks For Is first instance [Diamond Shape]
                                Console.ForegroundColor = ConsoleColor.Green;        // If First Instance colors it Green [Box Shape]
                            else                                          
                                Console.ForegroundColor = ConsoleColor.Red;          // If not, it colors it red [Box Shape] 
                        }
                        else                                                         
                            Console.ResetColor();
                        Console.Write($"[{table[i]}] ");                              // If it is not a match then it just colors the text default [Box Shape]
                    }
                }
                else {             // This is for All Instance Mode
                    for (int i = 0; i < table.Length; i++) {
                        if (table[i] == numUserinput)                                 // Here if User Input and Element Match [Diamond Shape]
                            Console.ForegroundColor = ConsoleColor.Green;             // If Match Colors it Green [Box Shape]
                        else
                            Console.ResetColor();                                      // and default color if not a match [Box Shape]
                        Console.Write($"[{table[i]}] ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine("\n\nDo you Want to Repeat? Type Y/Yes"); // User Input for Retry [Rhombus Shape]
                string userRepeat = Console.ReadLine().ToUpper();
                if (userRepeat != "Y" && userRepeat != "YES") // This just checks the input of the user if it wants to repeat or not [Diamond Shape]
                    main = false;
   
            }
        }
    }
}
