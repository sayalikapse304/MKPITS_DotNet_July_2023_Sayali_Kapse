using System;
namespace UserDefinedException
{
    class program
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.showage();
            }
            catch (AgeIsZeroException e)
            {
                Console.WriteLine("AgeIsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
public class AgeIsZeroException : ApplicationException
{
    public AgeIsZeroException(string message) : base(message)
    {
    }
}
public class Age
{
    int age = 19;
    public void showage()
    {
        if (age <= 18)
        {
            throw (new AgeIsZeroException("age should be greater than 18 "));
        }
        else
        {
            Console.WriteLine("Age: {0}", age);
        }
    }
}