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
            
            Console.WriteLine("\nNew member created succesfully!\nDetails: {0}\nPress Any Key to return to Previous Menu\n", aMember);
            Console.ReadKey();
            return;
        }

        public void delete(Member aMember)
        {
            memberTree.Delete(aMember);
        }

        public bool search(Member aMember)
        {
            return memberTree.Search(aMember);
        }

        public Member[] toArray()
        {
            return memberTree.toArray();
        }
    }
}
