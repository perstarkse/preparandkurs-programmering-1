using System;

class aktivitetsdiagram
{
    static void Main()
    {
        int siffraEtt = int.Parse(Console.ReadLine());
        int siffraTvå = int.Parse(Console.ReadLine());
        Console.WriteLine("Tryck \n1 för att addera sifforna \n2 för att multiplicera");
        switch(int.Parse(Console.ReadLine()))
        {
            case 1:
                int siffraTotalAddering = siffraEtt + siffraTvå;
                Console.WriteLine(siffraTotalAddering);
                break;
            case 2:
                int siffraTotalMultiplicering = siffraEtt * siffraTvå;
                Console.WriteLine(siffraTotalMultiplicering);
                break;
        }
    }
}