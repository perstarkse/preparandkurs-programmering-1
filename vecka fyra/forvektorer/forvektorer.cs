using System;

class ForVektorer
{
    static void Main()
    {
        int.TryParse(Console.ReadLine(), out int antalVektorer);
        double[] vektorLista = new double[antalVektorer];
        for (int i = 0; i < vektorLista.Length; i++)
        {
            double.TryParse(Console.ReadLine(),out double _input);
            vektorLista[i] = _input;
        }
        double totalsumma = 0;
        for (int i = 0;i < vektorLista.Length; i++)
        {
            totalsumma += vektorLista[i];
        }
        Console.WriteLine(totalsumma);
    }
}