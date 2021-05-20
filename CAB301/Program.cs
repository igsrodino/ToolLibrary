using System;

namespace Assignment
{
    class Program
    {
        private static ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem();
        private static MemberCollection memberCollection = new MemberCollection();
        public static string name;

        //  private static Tool tool = new Tool();
        static void Main(string[] args)
        {
            //toolLibrarySystem.add(new Member("Staff", "Smith", "0400000000", "today123"));
            //toolLibrarySystem.add(new Tool("Hammer"));
            Intro();

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
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.D0:
                    return;
                case ConsoleKey.D1:
                    StaffLogin();
                    break;
                case ConsoleKey.D2:
                    MemberMenu();
                    break;
            }

            Intro();
        }

        static void StaffLogin()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library");
            bool loggedIn = false;
            Console.WriteLine("To Log In, Enter Username (First Name): ");
            string username = Console.ReadLine();
            Console.WriteLine("\nEnter Password: ");
            string password = Console.ReadLine();
            if (username.Equals("staff", StringComparison.OrdinalIgnoreCase) &&
                password.Equals("today123", StringComparison.OrdinalIgnoreCase))
                StaffMenu();
            else
            {
                Console.WriteLine("\nIncorrect Login Details. \nPress any key to go back to Main Menu.\n");
                Console.ReadKey();
                Intro();
            }
        }

        static void StaffMenu()
        {
            Console.Clear();
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
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.D0:
                    return;
                case ConsoleKey.D1:
                    AddTools();
                    break;
                case ConsoleKey.D3:
                    DeleteTools();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("\n=============================");
                    Console.WriteLine("\nEnter new member details below:");
                    Console.WriteLine("\nFirst Name: ");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("\nLast Name: ");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("\nPhone Number: ");
                    string ContactNumber = Console.ReadLine();
                    Console.WriteLine("\nPIN: ");
                    string PIN = Console.ReadLine();

                    toolLibrarySystem.add(new Member(FirstName, LastName, ContactNumber, PIN));
                    break;
            }

            StaffMenu();
        }

        static void AddTools()
        {
            Console.WriteLine("\n=============================\n");


            Console.WriteLine("Tool Name: ");
            var tool = new Tool(name);
            tool.Name = Console.ReadLine();
            toolLibrarySystem.add(tool);
            Console.WriteLine("You added tool: {0}", tool.Name);
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
            }

        static void DeleteTools()
        {
            Console.WriteLine("\n=============================\n");
            ToolCollection[] GardeningTools = new ToolCollection[5];

            Console.WriteLine("Tool Name: ");
            var tool = new Tool(name);
            tool.Name = Console.ReadLine();
            GardeningTools[0].delete(tool);
            Console.WriteLine("You deleted tool: {0}", tool.Name);
            Console.WriteLine("Press any key to go back to Menu.");

            Console.ReadKey();
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
