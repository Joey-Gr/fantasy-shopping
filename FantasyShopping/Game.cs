using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyShopping
{
    class Game
    {
        static bool run = true;
        static int choice;
        static string input;
        static int progress = 0;

        public static void Play()
        {
            Start();
            Create_Character();
            while (run == true)
            {
                Menu();
                End();
            }
        }

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Game\n");

            Console.WriteLine("Introductory text to the game");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
        }

        public static void End()
        {
            Console.Clear();
            Console.WriteLine("Exit game?\n1)Yes\n2)No");
            input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Thanks for playing!");
                        break;
                    case 2:
                        run = true;
                        break;
                    default:
                        Console.WriteLine("Thanks for playing?");
                        break;

                }
            }
            else
            {
                Console.WriteLine("I can only understand numbers.\n It wasn't a yes, so I will take it as a no.");
            }
        }

        public static void Create_Character()
        {
            Console.Clear();
            Console.WriteLine("Choose your class:\n1)Noble\n2)Warrior\n3)Thief\n4)Acolyte");
            input = Console.ReadLine();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu, What do you need?\n1)Return\n2)B\n3)C\n4)D\n9)Exit Game");
            input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                if (choice == 9)
                {
                    run = false;
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Return to game");
                            // Content here
                            Console.WriteLine("Press enter to continue..");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("B Content..");
                            // Content here
                            Console.WriteLine("Press enter to continue..");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("C Content..");
                            // Content here
                            Console.WriteLine("Press enter to continue..");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("D Content..");
                            // Content here
                            Console.WriteLine("Press enter to continue..");
                            Console.ReadLine();
                            break;
                        default:
                            // Invalid option, number outside of 1-5
                            Console.WriteLine("Please enter a number between 1-5.");
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            Menu();
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Menu();
            }
            // Progress through game, menu remains the same.
            // Prompt(input, progress);
        }

        public static void Prompt(string input, int progress)
        {
            

        }

    }
}
