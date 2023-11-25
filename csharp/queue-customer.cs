using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program
{
    class Customer
    {
        public int cusid;
        public string name;
        public int moba;
        public int email;
        public Customer(int cusid, string name, int moba, int email)
        {
            this.cusid= cusid;
            this.name = name;
            this. moba = moba;
            this.email = email;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1, "sayali", 56778, 123);
            Customer c2 = new Customer(2, "mayuri", 80045, 567);
            Customer c3 = new Customer(3, "vrushali", 40056, 789);
            Customer c4 = new Customer(4, "asmi", 40023, 897);
            Queue cs = new Queue();
            cs.Enqueue(c1);
            cs.Enqueue(c2);
            cs.Enqueue(c3);
            cs.Enqueue(c4);

            foreach (Customer c in cs)
            {
                Console.WriteLine("cusid: " + c.cusid);
                Console.WriteLine("name: " + c.name);
                Console.WriteLine("moba: " + c.moba);
                Console.WriteLine("email: " + c.email);
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine("after dequeu------");
           cs.Dequeue();
            cs.Dequeue();

            foreach (Customer c in cs)
            { 
                Console.WriteLine("empno: " + c.cusid);
                Console.WriteLine("name: " + c.name);
                Console.WriteLine("salary: " + c.moba);
                Console.WriteLine("designation: " + c.email);
            }
            Console.ReadLine();
        }
    }
}






