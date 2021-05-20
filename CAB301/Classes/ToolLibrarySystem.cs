using Assignment;
using System;

namespace Assignment
{

    public class ToolLibrarySystem : iToolLibrarySystem
    {
        private ToolCollection[/*category*/][/*tooltype*/] toolCollection;
        private MemberCollection memberCollection;
        public ToolLibrarySystem()
        {
            toolCollection = new ToolCollection[9][];
            memberCollection = new MemberCollection();
        }

        public void add(Tool aTool)
        {
            // Use the console to select a category/subtype
            int cat = 0;
            int sub = 0;

            // Check if the tool already exists
            bool toolExists = false;

            if (toolExists)
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
        }

        public void borrowTool(Member aMember, Tool aTool)
        {
            /* Add the member to the tools MemberCollection
             * add the tool to the members ToolCollection */
            throw new NotImplementedException();
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            /*
             * a member can borrow multiple of the same tool, but the tool can only have one of the same member
             */
            throw new NotImplementedException();
        }

        public void delete(Tool aTool)
        {
            // If the tool exists and isn't being borrowed, delete it
            throw new NotImplementedException();
        }

        public void delete(Tool aTool, int quantity)
        {
            // removes some quantity, can't remove if the value exceeds what is available
            throw new NotImplementedException();
        }

        public void delete(Member aMember)
        {
            // delete a member, can't do it if they are borrowing shit tho
            throw new NotImplementedException();
        }

        public void displayBorrowingTools(Member aMember)
        {
            // loop through aMember.Tools and show that shit
            throw new NotImplementedException();
        }

        public void displayTools(string aToolType)
        {
            // this is tricky, but you have to figure out how to index the ToolCollection with a string
            // then print out what is inside that tool collection
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            // You have to implement some sorting algorithm to do this, check lecture slides
            throw new NotImplementedException();
        }

        public string[] listTools(Member aMember)
        {
            return aMember.Tools;
        }
    }
}
