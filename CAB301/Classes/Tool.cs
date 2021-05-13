using System;

namespace Assignment
{
    public class Tool : iTool, IComparable<Tool>
    {
        private string name;
        private int quantity;
        private int availableQuantity;
        private int noBorrowings;
        private MemberCollection members;
        public Tool(string name)
        {
            this.name = name;
            this.quantity = 1;
            this.availableQuantity = 1;
            this.noBorrowings = 0;
            this.members = new MemberCollection();
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Quantity { get => this.quantity; set => this.quantity = value; }
        public int AvailableQuantity { get => this.availableQuantity; set => this.availableQuantity = value; }        
        public int NoBorrowings { get => this.noBorrowings; set => this.noBorrowings = value; }


        public MemberCollection GetBorrowers => throw new NotImplementedException();

        public void addBorrower(Member aMember)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Tool other)
        {
            throw new NotImplementedException();
        }

        public void deleteBorrower(Member aMember)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
