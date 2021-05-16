using System;


namespace Assignment
{
     
    public class MemberCollection : iMemberCollection
    {
        private BSTree memberTree;
        public MemberCollection()
        {
            memberTree = new BSTree();
        }

        public int Number => throw new NotImplementedException();

        public void add(Member aMember)
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nEnter new member details below:");
            Console.WriteLine("\nFirst Name: ");
            aMember.FirstName =  Console.ReadLine();       
            Console.WriteLine("\nLast Name: ");
            aMember.LastName =  Console.ReadLine();       
            Console.WriteLine("\nPhone Number: ");
            aMember.ContactNumber =  Console.ReadLine();           
            Console.WriteLine("\nPIN: ");
            aMember.PIN =  Console.ReadLine();
            Console.WriteLine("\nNew member created succesfully!\nDetails: {0}\nPress Any Key to return to Previous Menu\n", aMember);
            Console.ReadKey();
            return;
        }

        public void delete(Member aMember)
        {
            throw new NotImplementedException();
        }

        public bool search(Member aMember)
        {
            throw new NotImplementedException();
        }

        public Member[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
