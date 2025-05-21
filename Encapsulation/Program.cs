
public class Persone
{
    private string Fname;
    private int Age;
    public void setData(string fname,int age)
    {
        if (int.IsNegative(age) || age == 0 )
        {
            Console.WriteLine("Age should not be Negative and Zero");
        } else
        {
            this.Age = age;
        }

        if (string.IsNullOrEmpty(fname) == true )
        {
            Console.WriteLine("please enter fname!");
        }
        else
        {
            this.Fname = fname;
        }
    }
    public void getData()
    {
        if(Age <= 0 )
        {
        } else 
        {
            Console.WriteLine($"The age is : {this.Age}");

        }
        if (string.IsNullOrEmpty(this.Fname))
        {

        }
        else
        {
            Console.WriteLine($"The name is : {this.Fname}");
        }
    }


}


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Persone p = new Persone();
        p.setData("", 1);
        p.getData();
    }

}