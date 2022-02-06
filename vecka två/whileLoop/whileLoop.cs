using System;
class WhileLoop
{
    static void Main()
    {
        bool köra = true;

        while (köra == true)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1: 
                    Console.WriteLine("du tryckte på 1"); 
                    break; 
                case 2:
                    Console.WriteLine("du tryckte på 2");
                    break;
                case 3:
                    köra = false;
                    break;
            }
        }
    }
}