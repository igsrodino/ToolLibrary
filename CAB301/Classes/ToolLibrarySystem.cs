using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{

    public class ToolLibrarySystem : iToolLibrarySystem
    {
        private ToolCollection[/*cat*/][/*tool*/] toolCollection;
        private MemberCollection memberCollection;
        public ToolLibrarySystem()
        {
            memberCollection = new MemberCollection();
            toolCollection = new ToolCollection[9][];

            for (int i = 0; i < toolCollection.Length; i++)
            {

                switch(i)
                {
                    case 0:
                        toolCollection[i] = new ToolCollection[Tools.gardeningTools.Length];
                        for (int j = 0; j < Tools.gardeningTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                    case 1:
                        toolCollection[i] = new ToolCollection[Tools.flooringTools.Length];
                        for (int j = 0; j < Tools.flooringTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                    case 2:

                        toolCollection[i] = new ToolCollection[Tools.fencingTools.Length];
                        for (int j = 0; j < Tools.fencingTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                    case 3:

                        toolCollection[i] = new ToolCollection[Tools.measuringTools.Length];
                        for (int j = 0; j < Tools.measuringTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                    case 4:

                        toolCollection[i] = new ToolCollection[Tools.cleaningTools.Length];
                        for (int j = 0; j < Tools.cleaningTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                    case 5:

                        toolCollection[i] = new ToolCollection[Tools.paintingTools.Length];
                        for (int j = 0; j < Tools.paintingTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                    case 6:

                        toolCollection[i] = new ToolCollection[Tools.electricTools.Length];
                        for (int j = 0; j < Tools.electricTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                    case 7:

                        toolCollection[i] = new ToolCollection[Tools.electricityTools.Length];
                        for (int j = 0; j < Tools.electricityTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                    case 8:

                        toolCollection[i] = new ToolCollection[Tools.automotiveTools.Length];
                        for (int j = 0; j < Tools.automotiveTools.Length; j++)
                            toolCollection[i][j] = new ToolCollection();
                        break;                    
                }
            }
        }

        public void add(Tool aTool)
        {
            // Setup variables
            int cat;
            int sub;
            string[] subCat = new string[0];
            ConsoleKeyInfo keyInfo;

            // Console Select Category
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

            if (!toolCollection[cat][sub].search(aTool))
                toolCollection[cat][sub].add(aTool);
            else
                add(aTool, 1);
        }

        public void add(Tool aTool, int quantity)
        {
            aTool.Quantity += quantity;
            aTool.AvailableQuantity += quantity;
        }

        public void add(Member aMember)
        {
            if (!memberCollection.search(aMember))
                memberCollection.add(aMember);
            else
            {
                Console.WriteLine("Member already exists!\nPress any key to continue.");
                Console.ReadKey();
            }
        }

        public void borrowTool(Member aMember, Tool aTool)   
        {

            if (aTool.AvailableQuantity > 0 && aMember.Tools.Length < 3)
            {
                aMember.addTool(aTool);
                aTool.addBorrower(aMember);
            }
          
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            if (aTool.AvailableQuantity > 0 && aMember.Tools.Length < 3)
            {
                aMember.deleteTool(aTool);
                aTool.deleteBorrower(aMember);
            }
        }

        public void delete(Tool aTool)
        {
            // If the tool exists and isn't being borrowed, delete it
            //if (aTool.AvailableQuantity > 0)
                //toolCollection.
            throw new NotImplementedException();
        }

        public void delete(Tool aTool, int quantity)
        {
            if (aTool.AvailableQuantity > 0)
            {
                toolCollection[0][0].delete(aTool);
                aTool.Quantity--;
            }
        }

        public void delete(Member aMember)
        {
            // delete a member, can't do it if they are borrowing 
            if (memberCollection.search(aMember))
            {
                memberCollection.delete(aMember);
            }
            else
            {
                Console.WriteLine("Member not found.\nPress any key to continue.");
                Console.ReadKey();
            }
        }

        public void displayBorrowingTools(Member aMember)
        {
            //foreach (Tool in aMember.toArray())
            //    Console.WriteLine(tool.ToString());
        }

        public void displayTools(string aToolType)
        {
            string[] split = aToolType.Split("/");
            int cat = int.Parse(split[0]);
            int sub = int.Parse(split[1]);

            foreach (Tool tool in toolCollection[cat][sub].toArray())
                Console.WriteLine(tool.ToString());
        }

        public void displayTopThree()
        {
            // Implement mergesort?
            throw new NotImplementedException();

        }

        public string[] listTools(Member aMember)
        {
            return aMember.Tools;
        }

        private Tool[] toArray()
        {
            List<Tool> result = new List<Tool>();

            for (int i = 0; i < toolCollection.Length; i++)
                for (int j = 0; j < toolCollection[i].Length; j++)
                    foreach (Tool tool in toolCollection[i][j].toArray())
                        result.Append(tool);

            return result.ToArray();
        }
    }
}
