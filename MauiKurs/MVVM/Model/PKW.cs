using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.MVVM.Model
{
    public class PKW
    {
        public static ObservableCollection<PKW> PkwListe { get; set; } = new ObservableCollection<PKW>()
        {
            new PKW(){Hersteller="Audi", MaxGeschwindigkeit=230, Baujahr=new DateTime(2004,1,1)},
            new PKW(){Hersteller="BMW", MaxGeschwindigkeit=123, Baujahr=new DateTime(2007,1,1)},
            new PKW(){Hersteller="Mercedes", MaxGeschwindigkeit=234, Baujahr=new DateTime(1989,1,1)},
        };


        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public DateTime Baujahr { get; set; }
    }
}
