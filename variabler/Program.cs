using System;
class Konvertering
{
    static void Main()
    {
        Console.WriteLine("ange heltal ett:");
        int heltalEtt = int.Parse(Console.ReadLine());
        Console.WriteLine("ange heltal två:");
        int heltalTvå = int.Parse(Console.ReadLine());
        Console.WriteLine(heltalEtt * heltalTvå);
    }
}