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
            throw new NotImplementedException();
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
