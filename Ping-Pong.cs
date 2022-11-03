using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);

        Console.WriteLine("//////////////////////////");

        for(int index = 1; index <= number; index += 1)
        {
            if(index % 3 == 0 && index % 5 == 0)
            {
                Console.WriteLine("ping-pong");
            }
            else if(index % 3 == 0)
            {
                Console.WriteLine("ping");
            }
            else if(index % 5 == 0)
            {
                Console.WriteLine("pong");
            }
            else
            {
                Console.WriteLine(index);
            }
        };

        Console.WriteLine("//////////////////////////");
        Main();
    }
}