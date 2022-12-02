using System.Text;

namespace Cseveges
{
    internal class Program
    {
        static List<Beszelgetes> BeszelgetesLST = new();

        static List<string> TagokLST = new();


        static void Main(string[] args)
        {
            StreamReader sr = new(path: "../../../src/csevegesek.txt", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
                BeszelgetesLST.Add(new Beszelgetes(sr.ReadLine()));


            sr = new(path: "../../../src/tagok.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
                TagokLST.Add(sr.ReadLine());

            sr.Close();


            //Console.WriteLine($"dasjihjkafgbaskf {BeszelgetesLST[0].KezdetDatum().Year}");

            feladat4();

            feladat5();

            feladat6();

            feladat7();

            feladat8();
        }

        private static void feladat8()
        {
            Console.WriteLine("8. feladat: Leghosszabb csendes indőszak 15h-tól");
            TimeSpan leghosszabCsend = new(0);
            int index = 0;
            for (int i = 1; i < BeszelgetesLST.Count; i++)
            {
                TimeSpan temp = BeszelgetesLST[i].TmpKezdetDT().Subtract(BeszelgetesLST[i - 1].TmpVegDT());
                if (leghosszabCsend < temp)
                {
                    leghosszabCsend = temp;
                    index = i - 1;
                }
            }

            Console.WriteLine(
                $"\tKezdete: {BeszelgetesLST[index].veg}" +
                $"\n\tVége: {BeszelgetesLST[index].kezdet}" +
                $"\n\tHossza: {leghosszabCsend.Hours}:{leghosszabCsend.Minutes}:{leghosszabCsend.Seconds}");
        }

        private static void feladat7()
        {
            Console.WriteLine("7. feladat: Nem beszélgettek senkivel");

            Dictionary<string, TimeSpan> felhasznaloHivDb = new Dictionary<string, TimeSpan>();

            for (int i = 0; i < TagokLST.Count; i++)
            {

                for (int j = 0; j < BeszelgetesLST.Count; j++)
                {

                    if (TagokLST[i] == BeszelgetesLST[j].fogado || TagokLST[i] == BeszelgetesLST[j].kezdemenyezo)
                    {

                        if (!felhasznaloHivDb.ContainsKey(TagokLST[i]))
                            felhasznaloHivDb.Add(TagokLST[i], BeszelgetesLST[j].TmpElteltIdo());

                        else
                            felhasznaloHivDb[TagokLST[i]] += BeszelgetesLST[j].TmpElteltIdo();
                    }
                }

                if (!felhasznaloHivDb.ContainsKey(TagokLST[i]))
                    Console.WriteLine($"\t{TagokLST[i]}");
            }
        }

        private static void feladat6()
        {
            Console.Write("6. feladat: Adja meg egy tag nevét: ");
            string tagNeve = Console.ReadLine().ToLower();

            TimeSpan tmpTimeSpan = new(0, 0, 0);
            TimeSpan timeSpan = new(0, 0, 0);

            for (int i = 0; i < BeszelgetesLST.Count; i++)
            {
                if (BeszelgetesLST[i].kezdemenyezo.ToLower() == tagNeve || BeszelgetesLST[i].fogado.ToLower() == tagNeve)
                {
                    tmpTimeSpan = BeszelgetesLST[i].TmpElteltIdo();

                    timeSpan += tmpTimeSpan;
                }
            }

            Console.WriteLine($"\tA beszélgetések összes ideje: {timeSpan}");
        }

        private static void feladat5()
        {
            TimeSpan longestDT = new(0);
            TimeSpan tmpDT;
            int index = 0;

            for (int i = 0; i < BeszelgetesLST.Count; i++)
            {
                tmpDT = BeszelgetesLST[i].TmpElteltIdo();

                if (tmpDT > longestDT)
                {
                    longestDT = tmpDT;
                    index = i;
                }
            }

            Console.WriteLine(
                $"5. Feladat: Leghosszabb beszélgetés adatai" +
                $"\n\tKezdeményező: {BeszelgetesLST[index].kezdemenyezo}" +
                $"\n\tFogadó: {BeszelgetesLST[index].fogado}" +
                $"\n\tKezdete: { (((BeszelgetesLST[index].KezdetDatum()).ToString() +"-"+ (BeszelgetesLST[index].KezdetIdo()).ToString()).Replace(" ","")).Replace(".0:00:00", "")}" +
                $"\n\tVége: {(((BeszelgetesLST[index].VegDatum()).ToString() + "-" + (BeszelgetesLST[index].VegIdo()).ToString()).Replace(" ", "")).Replace(".0:00:00", "")}" +
                $"\n\tHossz: {longestDT.TotalSeconds}mp");
        }

        private static void feladat4()
        {
            Console.WriteLine($"4. feladat: Tagok száma: {TagokLST.Count}fő - Beszélgetések: {BeszelgetesLST.Count}db");
        }
    }
}