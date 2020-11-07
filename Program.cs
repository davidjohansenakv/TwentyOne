using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Values = new string[2] { "2", "3" };
            Prompt("Hey Jude!");

        }

        static void Prompt(string msg)
        { 
            Console.WriteLine($"=> {msg}" ); 
        }
    }   
}
