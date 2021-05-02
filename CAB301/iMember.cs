using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    //The specification of Member ADT
    interface iMember
    {
        
        string FirstName  //get and set the first name of this member
        {
            get;
            set;
        }
        string LastName //get and set the last name of this member
        {
            get;
            set;
        }

        string ContactNumber //get and set the contact number of this member
        {
            get;
            set;
        }

        string PIN //get and set the password of this member
        {
            get;
            set;
        }

        string[] Tools //get a list of tools that this memebr is currently holding
        {
            get;
        }

        void addTool(iTool aTool); //add a given tool to the list of tools that this member is currently holding

        void deleteTool(iTool aTool); //delete a given tool from the list of tools that this member is currently holding

        //override string ToString(); //return a string containing the first name, lastname, and contact phone number of this memeber
    }
    class Member : iMember
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PIN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string[] Tools => throw new NotImplementedException();

        public void addTool(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void deleteTool(iTool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
