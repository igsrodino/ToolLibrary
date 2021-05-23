using System;

namespace Assignment
{
    class Program
    {
        private static ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem();
        private static MemberCollection memberCollection = new MemberCollection();
        private static Tool tool;
        public static string name;

        //  private static Tool tool = new Tool();
        static void Main(string[] args)
        {

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
                    MemberLogin();
                    break;
            }

            Intro();
        }

        static void StaffLogin()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Staff Menu Login");
            Console.WriteLine("To Log In, Enter Username (First Name): ");
            string username = Console.ReadLine();
            Console.WriteLine("\nEnter Password: ");
            string password = Console.ReadLine();
            if (username.Equals("staff", StringComparison.OrdinalIgnoreCase) && password == "today123")
                StaffMenu();
            else
            {
                Console.WriteLine("\nIncorrect Login Details. \nPress any key to go back to Main Menu.\n");
                Console.ReadKey();
                Intro();
            }
        }

        static void MemberLogin()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Member Menu Login");
            Console.WriteLine("To Log In, Enter Username (First Name): ");
            string username = Console.ReadLine();
            Console.WriteLine("\nEnter Password/PIN: ");
            string password = Console.ReadLine();
            if (username.Equals("", StringComparison.OrdinalIgnoreCase) &&
                password.Equals("", StringComparison.OrdinalIgnoreCase))
                MemberMenu();
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
            Console.WriteLine("Please make a selection (1-6, or 0 to return to Main Menu):");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.D0:
                    return;
                case ConsoleKey.D1:
                    AddTools();
                    break;
                case ConsoleKey.D2:
                    NewPieceOfATool();
                    break;
                case ConsoleKey.D3:
                    DeleteTools();
                    break;
                case ConsoleKey.D4:
                    AddMember();
                    break;
                case ConsoleKey.D5:
                    DeleteMember();
                    break;
                case ConsoleKey.D6:
                    SearchMember();
                    break;
            }

            StaffMenu();
        }

        static void AddTools()
        {
            Console.WriteLine("\n=============================\n");
            Console.WriteLine("Write New Tool Name: ");
            var tool = new Tool(name);
            tool.Name = Console.ReadLine();
            toolLibrarySystem.add(tool);
            Console.WriteLine("You added tool: {0}", tool.Name);
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
            }

        static void NewPieceOfATool()
        {
            Console.WriteLine("\n=============================\n");
            Console.WriteLine("Write New Tool Name: ");
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
            Console.WriteLine("Tool To Delete: ");
            var tool = new Tool(name);
            tool.Name = Console.ReadLine();
            //GardeningTools[0].delete(tool);
            Console.WriteLine("You deleted tool: {0}", tool.Name);
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
        }

        static void AddMember()
        {
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
        }

        static void DeleteMember()
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nEnter the member's details who you'd like to delete below:");
            Console.WriteLine("\nFirst Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("\nLast Name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("\nPhone Number: ");
            string ContactNumber = Console.ReadLine();
            Console.WriteLine("\nPIN: ");
            string PIN = Console.ReadLine();
            toolLibrarySystem.delete(new Member(FirstName, LastName, ContactNumber, PIN));
        }

        static void SearchMember()
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nEnter the member's phone details who you'd like find below:");
            Console.WriteLine("\nFirst Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("\nLast Name: ");
            string lastName = Console.ReadLine();
            Member searchMember;
            foreach (Member member in memberCollection.toArray())
            {
                if (member.FirstName == firstName && member.LastName == lastName)
                {
                    Console.WriteLine("Member found.");
                    searchMember = member;
                    Console.WriteLine(searchMember.ContactNumber); //DOESN'T WORK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                }
                else
                    Console.WriteLine("Member not found.");
            }

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
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.D0:
                    return;
                case ConsoleKey.D1:
                    DisplayTools();
                    break;
                case ConsoleKey.D2:
                    BorrowTools();
                    break;
                case ConsoleKey.D3:
                    ReturnTools();
                    break;
                case ConsoleKey.D4:
                    ToolsBorrowed();
                    break;
                case ConsoleKey.D5:
                    Top3ToolsBorrowed();
                    break;
            }

            MemberMenu();
        }

        static void DisplayTools()
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nPlease select a category:");
            string[] toolTypes = { "1. Gardening Tools", "2. Flooring Tools", "3. Fencing Tools", "4. Measuring Tools", "5. Cleaning Tools", "6. Painting Tools", "7. Electric Tools", "8. Electricity Tools", "9. Automotive Tools" };
            foreach (var category in toolTypes)
            {
                Console.WriteLine(category.ToString());
            }
            Console.WriteLine("Please make a selection (1-9, or 0 to return to Main Menu):");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("\n=============================\n\nTool Types:");
            switch (keyInfo.Key)
            {
                 case ConsoleKey.D1:
                    Console.WriteLine("1. Line Trimmers\n2. Lawn Mowers\n3. Hand Tools\n4. Wheelbarrows\n5. Garden Power Tools");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("1. Scrapers\n2. Floor Lasers\n3. Floor Levelling Tools\n4. Floor Levelling Materials\n. 5. Floor Hand Tools\n6. Tiling Tools");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("1. Hand Tools\n2. Electric Fencing\n3. Steel Fencing Tools\n4. Power Tools\n5. Fencing Accessories");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("1.Distance Tools\n2. Laser Measurer\n3. Measuring Jugs\n4. Temperature & Humidity Tools\n5. Levelling Tools\n6. Markers");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("1.Draining\n2. Car Cleaning\n3. Vacuum\n4. Pressure Cleaners\n5. Pool Cleaning\n6. Floor Cleaning");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("1.Sanding Tools\n2. Brushes\n3. Rollers\n4. Paint Removal Tools\n5. Paint Scrapers\n6. Sprayers");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine("1.Voltage Tester\n2. Oscilloscopes\n3. Thermal Imaging\n4. Data Test Tool\n5. Insullation Tester");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D8:
                    Console.WriteLine("1.Test Equipment\n2. Safety Equipment\n3. Basic Hand Tools\n4. Circuit Protection\n5. Cable Tools");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D9:
                    Console.WriteLine("1.Jacks\n2. Air Compressors\n3. Battery Chargers\n4. Socket Tools\n5. Braking\n6. Drivetrain");
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            MemberMenu();
            Console.ReadKey();
            }

        static void BorrowTools()
        {
            Console.WriteLine("\nEnter the tool you'd like to borrow below:");
            Console.WriteLine("\nTool: ");
            string toolName = Console.ReadLine();
            Console.WriteLine("\nYou've succesfully borrowed: {0}", toolName);
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
        }

        static void ReturnTools()
        {
            Console.WriteLine("\nEnter the tool you'd like to return below:");
            Console.WriteLine("\nTool: ");
            string toolName = Console.ReadLine();
            Console.WriteLine("\nYou've succesfully returned: {0}", toolName);
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
        }

        static void ToolsBorrowed()
        {
            Console.WriteLine("\nYou've borrowed these tools: ");
            Console.WriteLine("\nPress any key to go back to Menu.");
            Console.ReadKey();
        }

        static void Top3ToolsBorrowed()
        {
            Console.WriteLine("\nTop 3 Borrowed Tools are: \n1. Power Tools\n2. Floor Cleaning\n3. Air Compressors");
            Console.WriteLine("\nPress any key to go back to Menu.");
            Console.ReadKey();
        }
    }
}

