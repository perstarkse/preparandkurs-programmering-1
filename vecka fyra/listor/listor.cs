using System;
using System.Collections.Generic;

class Listor
{
    static void Main()
    {
        List<string> strängLista = new List<string>();
        Console.WriteLine("välj hur många strängar du vill skriva in");
        int.TryParse(Console.ReadLine(), out int val);
        Console.WriteLine("du har valt att skriva in " + (val) + " entries");
        for (int i = 0; i < val; i++)
        {
            strängLista.Add(Console.ReadLine());
        }
        for (int i = 0; i < val; i++)
        {
            Console.WriteLine(strängLista[i]);
        }
    }
}