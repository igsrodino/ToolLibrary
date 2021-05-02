using Assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface iToolLibrarySystem
    {
        void add(iTool aTool); // add a new tool to the system

        void add(iTool aTool, int quantity); //add new pieces of an existing tool to the system

        void delete(iTool aTool); //delte a given tool from the system

        void delete(iTool aTool, int quantity); //remove some pieces of a tool from the system

        void add(iMember aMember); //add a new memeber to the system

        void delete(iMember aMember); //delete a member from the system

        void displayBorrowingTools(iMember aMember); //given a member, display all the tools that the member are currently renting


        void displayTools(string aToolType); // display all the tools of a tool type selected by a member

        void borrowTool(iMember aMember, iTool aTool); //a member borrows a tool from the tool library

        void returnTool(iMember aMember, iTool aTool); //a member return a tool to the tool library

        string[] listTools(iMember aMember); //get a list of tools that are currently held by a given member

        void displayTopTHree(); //Display top three most frequently borrowed tools by the members in the descending order by the number of times each tool has been borrowed.

    }

    class ToolLibrarySystem : iToolLibrarySystem
    {
        public void add(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void add(iTool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void add(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void borrowTool(iMember aMember, iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void delete(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void displayBorrowingTools(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void displayTools(string aToolType)
        {
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            throw new NotImplementedException();
        }

        public string[] listTools(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(iMember aMember, iTool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
