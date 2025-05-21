using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] numbers = new int[2];
        numbers[0] = 1;
        numbers[1] = 2;
        Console.WriteLine(numbers[1]);


        string[] numbers2 = new string[4];

        numbers2[0] = "Hamza";
        numbers2[1] = "Mujahid";
        numbers2[2] = "Haris";
        numbers2[3] = "Khalid";

        //for (int i = 0; i < numbers2.Length; i++) 
        //{
        //    Console.WriteLine(numbers2[i]);
        //}

        foreach(string item in numbers2)
        {
            Console.WriteLine(item);
        }



    }
}

public class Product
{
    [Required]
    public string prodName { get; set; } = null!;
    public int Rate { get; set; } 
}