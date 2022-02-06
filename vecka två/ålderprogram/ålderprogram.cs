using System;
class ålderprogram
{
    static void Main()
    {
        // frågar efter och tar emot ålder i heltal, sparar i variabel
        Console.WriteLine("ange ålder i heltal");
        int ålder = int.Parse(Console.ReadLine());

        //testar ålder mot givna parametrar
        if (ålder == 18)
        {
            Console.WriteLine("Du har angett att du är 18 år gammal, dags att bli vuxen?");
        }
        else if (ålder > 18)
        {
            Console.WriteLine("Du har angett att du är :" + ålder + " år gammal");
        }
    }  

}