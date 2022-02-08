using System;

class Hund
{
    public Hund(string _namn, string _ras, double _ålder, bool _levande) 
    {
        namn = _namn;
        ras = _ras;
        ålder = _ålder;
        levande = _levande;
    }
    private string namn;
    public string Namn
    {
        get { return namn; }
    }
    private string ras;
    public string Ras
    {
        get { return ras; }
    }

    private double ålder;
    public double Ålder
    {
        get { return ålder; }
    }

    private bool levande;
    public bool Levande
    {
        get { return levande; }
    }
    static void Main()
    {
        List<Hund> hundLista = new List<Hund>();
        bool igång = true;
        while (igång)
        {
            Console.WriteLine("var god tryck \n 1 för att lägga till hund \n 2 för att se hundar \n 3 för att söka efter en hund \n 4 för att avsluta");
            int.TryParse(Console.ReadLine(), out int menyval);
            switch (menyval)
            {
                case 1:
                    Console.WriteLine("var god skriv in hundens namn:");
                    string _namn = Console.ReadLine();
                    Console.WriteLine("var god skriv in hundens ras:");
                    string _ras = Console.ReadLine();
                    Console.WriteLine("var god skriv in hundens ålder:");
                    double.TryParse(Console.ReadLine(), out double _ålder);
                    Console.WriteLine("lever hunden? svara med true/false");
                    bool.TryParse(Console.ReadLine(), out bool _levande);
                    Hund hund = new Hund(_namn, _ras, _ålder, _levande);
                    Console.WriteLine("nu är hunden tillagd i listan");
                    hundLista.Add(hund);
                    break;
                case 2:
                    foreach (Hund varjehund in hundLista)
                    {
                        Console.Write(varjehund.Namn +" - " + varjehund.Ras + " - "+ varjehund.Ålder +" - " + varjehund.levande + "\n");
                    }
                    break;
                case 3:
                    Console.WriteLine("vänligen ange hundens namn du söker efter");
                    string söknamn = Console.ReadLine();
                    for (int i = 0; i < hundLista.Count; i++)
                    {
                        if (hundLista[i].Namn.ToUpper() == söknamn.ToUpper())
                        {
                            Console.WriteLine(hundLista[i].Namn + " - " + hundLista[i].Ras + " - " + hundLista[i].Ålder + " - " + hundLista[i].Levande);
                        }
                        else
                        {
                            Console.WriteLine("finns inga hundar med det namnet");
                        }
                    }
                    break;
                case 4:
                    igång = false;
                    break;
                default:
                    Console.WriteLine("välj ett av de tre valen tack");
                    break;
            }
        }//Console.WriteLine(hundLista[0].Namn + hundLista[0].Ålder + hundLista[0].Levande);
    }
}