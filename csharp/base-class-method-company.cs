using System;
using System.Reflection;

namespace program
{ 
    class Company
{
    public string name = "mkcl";
    public void display()
    {
        Console.WriteLine("company name:" + name);
    }
}
class TCS : Company
{
    public string name = "mkpits";
    public void display()
    {
        base.display();
        Console.WriteLine("Tcs name " + name);
    }
}
class program
{
    static void Main(string[] args)
    {
        TCS t = new TCS();
        t.display();
        Console.ReadKey();
    }
}
}
