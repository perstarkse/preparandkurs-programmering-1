using System;

class Vektorer
{
    static int Addera(int[] siffor)
    {
        int totalsumma = 0;
        for (int i = 0;i < siffor.Length;i++)
        {
            totalsumma = totalsumma + siffor[i];
        }
        return totalsumma;
    }

    static void Main()
    {
        int[] sifferarray = new int[5];
        for (int i = 0; i < 5; i++) {
            int.TryParse(Console.ReadLine(), out sifferarray[i]);
        }
        Console.WriteLine(Addera(sifferarray));
    }
}