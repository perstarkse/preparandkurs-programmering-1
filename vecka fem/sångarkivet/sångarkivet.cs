using System;

class Hund
{
    class Sång
    {
        public Sång(string mottagenArtist, string mottagenSångnamn, int mottagenSpeltid)
        {
            artist = mottagenArtist;
            sångnamn = mottagenSångnamn;
            speltid = mottagenSpeltid;
        }

        private string artist;
        public string Artist
        {
            get { return artist; }
        }

        private string sångnamn;
        public string Sångnamn
        {
            get { return sångnamn; }
        }

        private int speltid;
        public int Speltid
        {
            get { return speltid; }
        }
    }
    static void Main()
    {
        List<Sång> SångLista = new List<Sång>();
        bool igång = true;
        while (igång)
        {
            Console.WriteLine("var god tryck \n 1 för att lägga till sång \n 2 för att se alla sånger \n 3 för att söka \n 4 för att avsluta");
            int.TryParse(Console.ReadLine(), out int menyval);
            switch (menyval)
            {
                case 1:
                    Console.WriteLine("var god skriv in artistens namn:");
                    string _artist = Console.ReadLine();
                    Console.WriteLine("var god skriv in sångens namn:");
                    string _sångNamn = Console.ReadLine();
                    Console.WriteLine("var god skriv in låtens längd:");
                    int.TryParse(Console.ReadLine(), out int _speltid);
                    Sång nySång = new Sång(_artist, _sångNamn, _speltid);
                    Console.WriteLine("nu är det tillagt i listan");
                    SångLista.Add(nySång);
                    break;
                case 2:
                    foreach (Sång varjesång in SångLista)
                    {
                        Console.Write(varjesång.Artist + " - " + varjesång.Sångnamn + " - " + varjesång.Speltid + " minuter" + "\n");
                    }
                    break;
                case 3:
                    Console.WriteLine("vänligen ange artistens namn du söker efter");
                    string söknamn = Console.ReadLine();
                    for (int i = 0; i < SångLista.Count; i++)
                    {
                        if (SångLista[i].Artist.ToUpper() == söknamn.ToUpper())
                        {
                            Console.WriteLine(SångLista[i].Artist + " - " + SångLista[i].Sångnamn + " - " + SångLista[i].Speltid + " minuter");
                        }
                        else
                        {
                            Console.WriteLine("finns inga artister med det namnet");
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
        }
    }
}