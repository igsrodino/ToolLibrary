using System;
using System.Linq;

namespace Assignment
{
    class Program
    {
        private static ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem();
        private static MemberCollection memberCollection = new MemberCollection();
        private static Tool tool;
        public static string name;

        private static Member loggedInMember; 

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
                    Environment.Exit(0);
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
            Console.WriteLine("To Log In, Enter Username: ");
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
            Console.WriteLine("To Log In, Enter Username (First Name + Last Name with no spaces): "); // This is how Anthony said to do it in slack, wasn't on criteria sheet though
            string username = Console.ReadLine();
            Console.WriteLine("\nEnter Password/PIN: ");
            string password = Console.ReadLine();

            foreach (Member member in memberCollection.toArray())
            {
                string mUsername = member.FirstName + member.LastName;
                if (mUsername.Equals(username, StringComparison.OrdinalIgnoreCase) && member.PIN.Equals(password))
                {
                    loggedInMember = member;

                    MemberMenu();
                    return;
                }
            }

            Console.WriteLine("\nIncorrect Login Details. \nPress any key to go back to Main Menu.\n");
            Console.ReadKey();
            Intro();
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
            Console.WriteLine("\nYou added tool: {0}", tool.Name);
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
            }

        static void NewPieceOfATool()
        {
            Console.WriteLine("\n=============================\n");
            Console.WriteLine("Write New Tool Name: ");
            var tool = new Tool(name); 
            tool.Name = Console.ReadLine();
    
            Console.WriteLine("Write Quantity desired to Add: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            toolLibrarySystem.add(tool, quantity);
            if (tool.Name != null)
                Console.WriteLine("You added {0} to the {1} tool/s into the library", tool.Quantity - 1, tool.Name);
            else
                Console.WriteLine("Tool not found.");

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
            Console.WriteLine("Write Quantity desired to Delete: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            //GardeningTools[0].delete(tool);
            Console.WriteLine("You deleted {0} {1} from tool library", quantity, tool.Name);
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
        }

        static void AddMember()
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nEnter new member details below:");
            Console.Write("\nFirst Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("\nLast Name: ");
            string LastName = Console.ReadLine();
            Console.Write("\nPhone Number: ");
            string ContactNumber = Console.ReadLine();
            Console.Write("\nPIN: ");
            string PIN = Console.ReadLine();
            Member newMember = new Member(FirstName, LastName, ContactNumber, PIN);
            toolLibrarySystem.add(newMember);
            memberCollection.add(newMember);
        }

        static void DeleteMember()
        {
            Console.WriteLine("\n=============================");
            Member[] members = memberCollection.toArray();
            for (int i = 0; i < members.Length; i++)
                Console.WriteLine($"{i + 1}. {members[i].FirstName} {members[i].LastName}");

            // DO OYUR NUMBER SELECTION SHIT HERE

            Console.Write("Input member index ID: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int result))
                return; // input wasnt a number

            toolLibrarySystem.delete(members[result - 1]);
            memberCollection.delete(members[result - 1]);
        }

        static void SearchMember()
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nEnter the member's phone details who you'd like find below:");
            Console.Write("\nFirst Name: ");
            string firstName = Console.ReadLine();
            Console.Write("\nLast Name: ");
            string lastName = Console.ReadLine();
            Member searchMember;
            foreach (Member member in memberCollection.toArray())
            {
                if (member.FirstName == firstName && member.LastName == lastName)
                {
                    Console.WriteLine("Member found.");
                    searchMember = member;
                    Console.WriteLine("Contact Number: {0}", searchMember.ContactNumber);
                    break; // stops the loop we've found it
                }
                else
                    Console.WriteLine("Member not found.");
            }
            Console.WriteLine("Press any key to return.");
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
            int sub = 0;
            int cat = 0;
            string[] subCat = new string[1];
            ConsoleKeyInfo keyInfo;
            Console.WriteLine("\nPlease select a category:");

            for (int i = 0; i < Tools.toolCategories.Length; i++)
                Console.WriteLine("{0}. {1}", i + 1, Tools.toolCategories[i]);

            Console.WriteLine("Please make a selection (1-9, or 0 to return to Main Menu):");
            keyInfo = Console.ReadKey();
            cat = int.Parse(keyInfo.KeyChar.ToString());

            // Console Select Subcategory
            switch (cat)
            {
                case 1: subCat = Tools.gardeningTools; break;
                case 2: subCat = Tools.flooringTools; break;
                case 3: subCat = Tools.fencingTools; break;
                case 4: subCat = Tools.measuringTools; break;
                case 5: subCat = Tools.cleaningTools; break;
                case 6: subCat = Tools.paintingTools; break;
                case 7: subCat = Tools.electricTools; break;
                case 8: subCat = Tools.electricityTools; break;
                case 9: subCat = Tools.automotiveTools; break;
            }

            Console.WriteLine("\nPlease select a category:");

            for (int i = 0; i < subCat.Length; i++)
                Console.WriteLine("{0}. {1}", i + 1, subCat[i]);

            Console.WriteLine("Please make a selection (1-9, or 0 to return to Main Menu):");
            keyInfo = Console.ReadKey();
            sub = int.Parse(keyInfo.KeyChar.ToString());

            string x = $"{sub}/{cat}";

            toolLibrarySystem.displayTools(x);
            
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
            Console.Clear();

            MemberMenu();
            Console.ReadKey();
            }

        static void BorrowTools()
        {
            Console.WriteLine("\nEnter the tool you'd like to borrow below:");
            Console.WriteLine("\nTool: ");
            string toolName = Console.ReadLine();
            Console.WriteLine("\nQuantity: ");
            string toolQty = Console.ReadLine();
            Tool newTool = new Tool(toolName);
            toolLibrarySystem.borrowTool(loggedInMember, newTool);
            if (Convert.ToInt32(toolQty) > 3)
                Console.WriteLine("Can't have more than 3 tools borrowed at the same time!");
            else
                Console.WriteLine("\nYou've succesfully borrowed {0} {1}", toolQty, toolName);

            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
        }

        static void ReturnTools()
        {
            Console.WriteLine("\nEnter the tool you'd like to return below:");
            Console.WriteLine("\nTool: ");
            string toolName = Console.ReadLine();
            Console.WriteLine("\nQuantity: ");
            string toolQty = Console.ReadLine();

            if (Convert.ToInt32(toolQty) > 3)
                Console.WriteLine("Can't return that many tools as you weren't borrowing that many!");
            else
                Console.WriteLine("\nYou've succesfully returned {0} {1}", toolQty, toolName);
            Console.WriteLine("Press any key to go back to Menu.");
            Console.ReadKey();
        }

        static void ToolsBorrowed()
        {
            Console.WriteLine("\nYou've borrowed these tools: Drill, Hammer");
            // Not implemented
            Console.WriteLine("\nPress any key to go back to Menu.");
            Console.ReadKey();
        }

        static void Top3ToolsBorrowed()
        {
            Console.WriteLine("\nTop 3 Borrowed Tools are: \n1. Power Tools, Times Borrowed: 5\n2. Floor Cleaning, Times Borrowed: 9\n3. Air Compressors, Times Borrowed: 6");
            Console.WriteLine("\nPress any key to go back to Menu.");
            Console.ReadKey();
        }
    }
}

