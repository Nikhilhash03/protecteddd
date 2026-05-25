using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protecteddd
{
    class myclass
    {
        protected int a = 1;
        public void mymethod()
        {
            Console.WriteLine("Value of a under mymethod " + a);
        }
    }
    class newclass : myclass
    {
        public void newmethod()
        {
            Console.WriteLine("value of a under newmethod " + a);
            //base:mymethod();
        }
    }
    internal class protecteddd
    {
        static void Main(string[] args)
        {
            newclass obj = new newclass();
            obj.mymethod();
            obj.newmethod();
        }
    }
    }
