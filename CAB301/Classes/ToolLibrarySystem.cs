﻿using Assignment;
using System;

namespace Assignment
{

    public class ToolLibrarySystem : iToolLibrarySystem
    {
        private MemberCollection memberCollection;
        public ToolLibrarySystem()
        {
            memberCollection = new MemberCollection();
        }

        public void add(Tool aTool)
        {
            Console.WriteLine("Not implemented");
        }

        public void add(Tool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void add(Member aMember)
        {
            memberCollection.add(aMember);
        }

        public void borrowTool(Member aMember, Tool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(Tool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void delete(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void displayBorrowingTools(Member aMember)
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

        public string[] listTools(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
