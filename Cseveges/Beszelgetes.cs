using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cseveges
{
    public class Beszelgetes
    {

        //szét bontott adatok a csevegés.txt állományból.
        public string kezdet;
        public string veg;
        public string kezdemenyezo;
        public string fogado;

        //Adatok össze vonva
        string[] kezdetFelbontva = new string[2];
        string[] vegFelbontva = new string[2];

        public Beszelgetes (string poss)
        {

            string[] splitted = poss.Split(';');
            kezdet = splitted[0];
            veg = splitted[1];
            kezdemenyezo = splitted[2];
            fogado = splitted[3];
            kezdetFelbontva = kezdet.Split('-');
            vegFelbontva = veg.Split('-');

        }

        public DateTime KezdetDatum()
            => DateTime.Parse("20" + kezdetFelbontva[0]);
        public DateTime VegDatum()
            => DateTime.Parse("20" + vegFelbontva[0]);
        public TimeSpan KezdetIdo()
            => TimeSpan.Parse(kezdetFelbontva[1]);
        public TimeSpan VegIdo()
            => TimeSpan.Parse(vegFelbontva[1]);
        public TimeSpan TmpElteltIdo()
            => TmpVegDT().Subtract(TmpKezdetDT());

        public DateTime TmpKezdetDT()
        {

            DateTime tmpKezdetDT = new DateTime(
                this.KezdetDatum().Year,
                this.KezdetDatum().Month,
                this.KezdetDatum().Day,
                this.KezdetIdo().Hours,
                this.KezdetIdo().Minutes,
                this.KezdetIdo().Seconds);
            return tmpKezdetDT;

        }

        public DateTime TmpVegDT()
        {

            DateTime tmpVegDT = new DateTime(
                this.VegDatum().Year,
                this.VegDatum().Month,
                this.VegDatum().Day,
                this.VegIdo().Hours,
                this.VegIdo().Minutes,
                this.VegIdo().Seconds);
            return tmpVegDT;

        }

    }
}
