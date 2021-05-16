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
                    {
                        return;
                    }
                case ConsoleKey.D1:
                    {
                        StaffLogin();
                        return;
                    }
                case ConsoleKey.D2:
                    {
                        MemberMenu();
                        return;
                    }
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
            if (username == "Staff" && password == "today123")
            {
                StaffMenu();
            }
            else if (username == "staff" && password == "today123")
            {
                StaffMenu();
            }
            else if (username == "Staff" && password == "Today123")
            {
                StaffMenu();
            }
            else if (username == "staff" && password == "Today123")
            {
                StaffMenu();
            }
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
                    {
                        Intro();
                        return;
                    }
                case ConsoleKey.D1:
                    {
                        AddTools();
                        StaffMenu();
                        return;
                    }
                case ConsoleKey.D3:
                    {
                        DeleteTools();
                        StaffMenu();
                        return;
                    }
                case ConsoleKey.D4:
                    {
                        toolLibrarySystem.add(new Member("", "", "", ""));
                        Console.WriteLine(memberCollection);
                        StaffMenu();
                        return;
                    }

            }
        }

        static void AddTools()
        {
            Console.WriteLine("\n=============================\n");
            ToolCollection[] GardeningTools = new ToolCollection[5];
            var LineTrimmers = new ToolCollection();
            var LawnMowers = new ToolCollection();
            var HandTools = new ToolCollection();
            var Wheelbarrows = new ToolCollection();
            var GardenPowerTools = new ToolCollection();

            GardeningTools[0] = LineTrimmers;
            GardeningTools[1] = LawnMowers;
            GardeningTools[2] = HandTools;
            GardeningTools[3] = Wheelbarrows;
            GardeningTools[4] = GardenPowerTools;

            Console.WriteLine("Tool Name: ");
            var tool = new Tool(name);
            tool.Name = Console.ReadLine();        
            GardeningTools[0].add(tool);
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
