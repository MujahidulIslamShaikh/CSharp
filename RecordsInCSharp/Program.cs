using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Person p1 = new Person("Mujahid", "Shaikh Mukhtar Ah");  // immutable
        Person p1 = new Person()
        {
               Fname = "Mujahid",
               Lname = "Mukhtar",
        };
        // p1.Fname = "Hamza";
        p1.Lname = "Mukhtar Ah";
        // p1.Fname = "Hamza";
        Console.WriteLine(p1);
        Person p2 = p1 with { Fname = "Haris" };
        Console.WriteLine(p2);
        //Person p2 = new Person()
        //{
        //    Fname = "Mujahid",
        //    Lname = "Shaikh Mukhtar Ah",
        //};
        // Console.WriteLine(p1 == p2);
    }
}

// public class Person   // reference deta hai
//public record Person  // values deta hai
//{
//    public string Fname { get; set; }
//    public string Lname { get; set; }
//}
public record Person  // values deta hai
{
    public string Fname { get; init; }
    public string Lname { get; set; }
}
// ====================
// public class Person(string Fname, string Lname);  // primary contructor ka use 