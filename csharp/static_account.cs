using System;
namespace program
{
    public class Account
    {
        public int accno;
        public string name;
        public static float rateoFInterest = 8.8f;
        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateoFInterest);
        }
    }
    class TestAccount
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(101, "santosh");
            Account a2 = new Account(102, "sayali");
            a1.display();
            a2.display();
            Console.ReadKey();
        }
    }
}