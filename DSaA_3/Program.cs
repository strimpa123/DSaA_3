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
                for (int i = 0; i < table.Length; i++) {
                    table[i] = intRnd.Next(0, 9);
                    Console.Write($"[{table[i]}] ");
                }
                Console.Write("\n\nPlease Input a Number from [0 - 9] you want to Find: ");

                while (numCheck) {
                    numUserinput = 0;
                    string firstUserinput = Console.ReadLine();

                    if (int.TryParse(firstUserinput, out numUserinput) == true) {
                        if (numUserinput <= 9)
                            numCheck = false;
                        else
                            Console.Write("\nPlease Input a Number Between [0 - 9] only : ");
                    }
                    else
                        Console.Write("\nPlease Input a Valid Integer: ");
                }
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

                Console.Clear();
                if (Mode == "1") {
                    int insCount = 0;
                    for (int i = 0; i < table.Length; i++) {
                        if (table[i] == numUserinput) {
                            insCount++;
                            if (insCount == 1)
                                Console.ForegroundColor = ConsoleColor.Green;
                            else
                                Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                            Console.ResetColor();
                        Console.Write($"[{table[i]}] ");
                    }
                }
                else {
                    for (int i = 0; i < table.Length; i++) {
                        if (table[i] == numUserinput)
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                            Console.ResetColor();
                        Console.Write($"[{table[i]}] ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine("\n\nDo you Want to Repeat? Type Y/Yes");
                string userRepeat = Console.ReadLine().ToUpper();
                if (userRepeat != "Y" && userRepeat != "YES")
                    main = false;
                    
            }
        }
    }
}
