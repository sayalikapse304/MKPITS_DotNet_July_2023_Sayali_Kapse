using System;
public class exercise18
{
    class bill
    {
        static void Main()
        {
            int custid, conunit;
            double chg, surchg = 0, amt, netamt;
            string custname;

            Console.Write("Input Customer ID :");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            custname = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            conunit = Convert.ToInt32(Console.ReadLine());
            if (conunit < 200)
                chg = 1.20;

            else if (conunit >= 200 && conunit < 400)
                chg = 1.50;

            else if (conunit >= 400 && conunit < 600)
                chg = 1.80;

            else
                chg = 2.00;

            amt = conunit * chg;
            if (amt > 400)
                surchg = amt * 15 / 100.0;
            netamt = amt + surchg;
            
            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer IDNO=" + custid);
            Console.Write("Customer Name=" + custname);
            Console.Write("unit Consumed=" + conunit);
            Console.Write("Amount Charges=" + chg +" " + amt );
            Console.Write("Surchage Amount=" + surchg);
            Console.Write("Net Amount Paid By the Customer" + netamt);

            Console.ReadKey();
        }
    }
}