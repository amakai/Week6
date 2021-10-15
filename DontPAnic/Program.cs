using System;

namespace DontPAnic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Dont panic" nulliga
            //programm asendab kõik 'a' tähed neljaga

            string dontP = "Dont Panic";

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');
            Console.WriteLine(dontP);
        }
    }
}
