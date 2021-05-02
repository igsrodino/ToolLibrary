using System;

namespace CAB301
{
    class Program
    {

        static void Main(string[] args)
        {
            Intro();

            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                StaffMenu();
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
            if (userChoice == 2)
            {
                MemberMenu();
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
            if (userChoice == 0)
            {
                Intro();
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("==========Main Menu=========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("============================\n");
            Console.WriteLine("Please make a selection (1-2, or 0 to exit):");
        }

        static void StaffMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("==========Staff Menu=========");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add new pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of a tool");
            Console.WriteLine("4. Register a new member");
            Console.WriteLine("5. Remove a member");
            Console.WriteLine("6. Find the contact number of a member");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("=============================\n");
            Console.WriteLine("Please make a selection (1-6, or 0 to return to main menu):");
        }

        static void MemberMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("==========Member Menu=========");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all the tools that I am renting");
            Console.WriteLine("5. Display top three (3) most frequently rented tools");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("==============================\n");
            Console.WriteLine("Please make a selection (1-5, or 0 to return to main menu):");
        }
    }
}
