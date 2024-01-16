using System;
using System.Collections.Generic;
using System.Linq;

namespace BejegyzesProjekt{ 
    class Program
    {
        static void Main()
        {
            //2.a Feladat
            List<Bejegyzes> bejegyzesek = new List<Bejegyzes>
            {
                new Bejegyzes("Felhasznalo1", "Első bejegyzés"),
                new Bejegyzes("Felhasznalo2", "Második bejegyzés")
            };
            //2.b Feladat
            Console.Write("Adja meg, hány új bejegyzést szeretne hozzáadni: ");
            int ujBejegyzesekSzama = int.Parse(Console.ReadLine());
            for (int i = 0; i < ujBejegyzesekSzama; i++)
            {
                Console.Write("Adja meg a(z) {0}. bejegyzés szerzőjét: ", i + 3);
                string szerzo = Console.ReadLine();
                Console.Write("Adja meg a(z) {0}. bejegyzés tartalmát: ", i + 3);
                string tartalom = Console.ReadLine();
                bejegyzesek.Add(new Bejegyzes(szerzo, tartalom));
            }
            //2.c Feladat
            Random random = new Random();
            int tempRandom = random.Next(0, bejegyzesek.Count);
            for (int i = 0; 20*bejegyzesek.Count > i; i++)
            {
                bejegyzesek[tempRandom].Like();
            }
		    //2.d Feladat
		    Console.Write("Kérem változtassa meg a második bejegyzést: ");
            bejegyzesek[1].Tartalom = Console.ReadLine();
	        Console.WriteLine();
            //2.e Feladat
            foreach (Bejegyzes bejegyzes in bejegyzesek)
	        {
		        Console.WriteLine(bejegyzes);
		    }
            //3.a Feladat
            int maxLikeok = 0;
            foreach (Bejegyzes bejegyzes in bejegyzesek)
            {
                if (bejegyzes.Likeok >= maxLikeok)
		        {
                    maxLikeok = bejegyzes.Likeok;
			    }
            }
            //3.b Feladat
            bool eldont = false;
            foreach (Bejegyzes bejegyzes in bejegyzesek)
            {
		        if (bejegyzes.Likeok > 35)
			    {
                    eldont = true;
			    }
                break;
            }
            if (eldont)
		    {
		        Console.WriteLine("Van 35-nél több like-kal rendelkező bejegyzés!");
		    }   else {
				    Console.WriteLine("Nincs 35-nél több like-kal rendelkező bejegyzés!");
                }
            //3.c Feladat
            int tizenotLikeosok = 0;
            foreach (Bejegyzes bejegyzes in bejegyzesek)
            {
                if(bejegyzes.Likeok == 15)
			    {
                    tizenotLikeosok += 1;
			    }
            }
		    Console.WriteLine($"{tizenotLikeosok} db 15 like-kal rendelkező bejegyzés van!");
            //3.d Feladat
            List<Bejegyzes> bejegyzesKlonja = new List<Bejegyzes>(bejegyzesek);
            bejegyzesKlonja.OrderByDescending(bejegyzes => bejegyzes.Likeok);
        }
    }
}