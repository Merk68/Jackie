using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackie
{
  class Program
  {
    static List<Race> lista = new List<Race>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      Console.ReadKey();
    }

    private static void HatodikFeladat()
    {   
    }

    private static void OtodikFeladat()
    {
      //Két változó az évtizedeknek = 0
      //Végigmegyünk az adatokon
      //megnézzük, hogy melyik évtized majd hozzáadjuk a megfelelő évtizedhez.
      int hatvanas = 0, hetvenes = 0;
      foreach (var l in lista)
      {
        if (l.Year == hatvanas)
        {

        }
      }
    }

    private static void NegyedikFeladat()
    {
      int maxEv = 0, maxRace = 0;
      foreach (var l in lista)
      {
        if (l.Races > maxRace)
        {
          maxRace = l.Races;
          maxEv = l.Year;
        }
      }
      Console.WriteLine("4. Feladat. {0}",maxEv);
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine("3. Feladat: {0}", lista.Count());

    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("Második Feladat: Adatok beolvasása!");
      StreamReader be = new StreamReader("Jackie.txt");

      be.ReadLine();

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split('\t');
        lista.Add(new Race(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4]), int.Parse(a[5]))); 
        //Console.WriteLine(be.ReadLine()); [Beolvasás ellenőrzése]
      }
      be.Close();
    }
  }
}
