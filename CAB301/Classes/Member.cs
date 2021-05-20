using System;
using System.Linq;

namespace Assignment
{
    public class Member : iMember, IComparable<Member>
    {
        private string firstName;
        private string lastName;
        private string contactNumber;
        private string pin;
        private ToolCollection tools;
        public Member(string firstName, string lastName, string contactNumber, string pin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
            this.pin = pin;
            this.tools = new ToolCollection();
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }

        public string PIN { get => pin; set => pin = value; }


        public string[] Tools => tools.toArray()?.Select(t => t.Name).ToArray();

        public void addTool(Tool aTool)
        {
            // a Tool colletion has an array inside it that contains tools.
            // you can access this array by using ToolCollection.toArray() where ToolCollection is an instance of tool collection
            if (tools.toArray().Length < 3)
                tools.add(aTool);
        }

        public int CompareTo(Member other)
        {
            return (LastName + FirstName).CompareTo(other.LastName + other.FirstName);
        }

        public void deleteTool(Tool aTool)
        {
            tools.delete(aTool);
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " Phone:" + this.ContactNumber + " Pin:" + this.PIN + "\n";
        }

    }
}
