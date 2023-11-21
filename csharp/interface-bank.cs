using System;
namespace program
{ 
    interface bank
{
    string deposit(int actno, int amt);
}
    class saving : bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int acctno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposit successfully,bal is " + bal;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            bank b;
            b = new saving();

            string str = b.deposit(1233,500);
            Console.WriteLine(str);
        }
    }

}