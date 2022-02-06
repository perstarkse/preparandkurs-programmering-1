using System;
class MinMeny
{
    static void Main()
    {
        string minString = "";
        bool running = true;
        while (running)
        {
            int.TryParse(Console.ReadLine(), out int menyval);
            switch (menyval)
            {
                    case 1:
                        minString = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(minString);
                        break;
                    case 3:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("välj ett av de tre valen tack");
                        break;
                }
        }
    }
}