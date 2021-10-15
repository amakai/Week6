using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime

            //programm kontrollib andmete pikkust 
            //programm kuvab kumb nendest on pikem, kas ees-või perekonnanimi

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit.");

            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int lastNameLenght = lastName.Length;
            Console.WriteLine($"Sinu perekonnanimes on {lastNameLenght} sümbolit.");

            if (firstNameLenght > lastNameLenght)
            {
                Console.WriteLine(" Sinu eesnimi on pikem");
            }
            else
            {
                Console.WriteLine("Sinu perekonnanimi on pikem");
            }

            
            

        }
    }
}
