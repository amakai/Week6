﻿using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit.");
        }
    }
}
