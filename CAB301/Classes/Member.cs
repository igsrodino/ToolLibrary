using System;


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

        public string FirstName {
            get {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }
            set
            {
                contactNumber = value;
            }
        }

        public string PIN
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
            }
        }


        public string[] Tools => throw new NotImplementedException();

        public void addTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Member other)
        {
            return (LastName + FirstName).CompareTo(other.LastName + other.FirstName);
        }

        public void deleteTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " Phone:" + this.ContactNumber + " Pin:" + this.PIN + "\n";
        }

    }
}
