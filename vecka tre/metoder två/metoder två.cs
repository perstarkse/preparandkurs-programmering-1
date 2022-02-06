using System;
class Metoder
{
    static string slåIhopSträngar(string strängEtt="", string strängTvå="", string strängTre="", string strängFyra="")
    {
        string nySträng = strängEtt + " " + strängTvå + " " + strängTre + " " + strängFyra; 
        return nySträng;
    }

    static void Main()
    {   

        Console.WriteLine(slåIhopSträngar(strängEtt: Console.ReadLine(), strängTvå: Console.ReadLine(), strängTre: Console.ReadLine(), strängFyra: Console.ReadLine()));
    }
}