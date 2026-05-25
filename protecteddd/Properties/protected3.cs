using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protecteddd.Properties
{
    internal class protected3
    {
        class branch
        {
            protected int bid;
            protected string branchname;
            protected string branchaddress;
            public branch(int bid, string branchname, string branchaddress)
            {
                this.bid = bid;
                this.branchname = branchname;
                this.branchaddress = branchaddress;
            }
            public void branchdisplay()
            {
                Console.WriteLine("Branch id is " + bid);
                Console.WriteLine("Branch name is " + branchname);
                Console.WriteLine("Branch address is " + branchaddress);
            }
        }
        class student : branch
        {
            int sid;
            string sname;
            String scollege;
            public student(int sid, string sname, string scollege) : base(111, "AAA", "KPHB")
            {
                this.sid = sid;
                this.sname = sname;
                this.scollege = scollege;

            }
            public void studentdisplay()
            {
                Console.WriteLine("Student id is" + sid);
                Console.WriteLine("Student name is " + sname);
                Console.WriteLine("Student college is " + scollege);
                base.branchdisplay();
            }
        }
        internal class inheritance
        {
            static void Main(string[] args)
            {
                student obj = new student(1, "Nikhil", "VIT");
                obj.studentdisplay();
            }
        }
    }
}
