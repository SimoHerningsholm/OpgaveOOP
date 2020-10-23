using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Instrument
    {
        public int VareNummer { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public double IndkøbsPris { get; set; }
        public double Fortjeneste { get; set; }
        public DateTime LagerDato { get; set; }
        public int Antal { get; set; }
        public string Producent { get; set; }
        public int VareGruppe { get; set; }
        public double UdsalgsPris {get{return (double)IndkøbsPris * (Fortjeneste + 1);}}
    }
}
