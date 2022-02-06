using System;
class Metoder
{
    static string slåIhopSträngar(string strängEtt, string strängTvå)
    {
        string nySträng = strängEtt + " " + strängTvå;
        return nySträng;
    }

    static void Main()
    {
        Console.WriteLine(slåIhopSträngar("hej", "hej igen"));
    }
}