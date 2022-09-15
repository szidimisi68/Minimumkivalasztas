using System;

namespace minimumkiválasztás
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Mennyi legyen: ");
            int mennyi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mekkora tartományban: ");
            int tartomany = Convert.ToInt32(Console.ReadLine());

            int[] szamok = new int[mennyi];
            for (int i = 0; i < mennyi; i++)
            {
                szamok[i] = rnd.Next(1, tartomany + 1);
            }
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            szamok = minimumKivalasztas(szamok);
            watch.Stop();
            Console.WriteLine(string.Join(" ", szamok));
            Console.WriteLine("A futási idő: " + watch.ElapsedMilliseconds / 1000d + "s");
        }

        static int[] minimumKivalasztas(int[] szamok)
        {
            for (int i = 0; i < szamok.Length - 1; i++)
            {
                int minimum = i;
                for (int j = i + 1; j < szamok.Length; j++)
                {
                    if (szamok[minimum] > szamok[j])
                    {
                        minimum = j;
                    }
                }
                (szamok[i], szamok[minimum]) = (szamok[minimum], szamok[i]);
            }
            return szamok;
        }
    }
}
