using System;
class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello Please enter your First Name:");
        String FirstName = Console.ReadLine();
        Console.WriteLine("Hello {0}, please enter you Lastname", FirstName);
        String LastName = Console.ReadLine();
        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
        Console.ReadLine();


    }
    }
