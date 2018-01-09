using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP
{
    class Pokoj: IComparable<Pokoj>
    {
        private int nrPokoju;
        private double cenaZaDzien;

        public Pokoj(int nrPokoju, double cenaZaDzien)
        {
            this.nrPokoju = nrPokoju;
            this.cenaZaDzien = cenaZaDzien;
        }
        public override string ToString()
        {
            return "Pokój, nr: " + nrPokoju + ", cena za dzień: " + cenaZaDzien;
        }
        public int PobierzNrPokoju()
        {
            return nrPokoju;
        }
        public double PobierzCene()
        {
            return cenaZaDzien;
        }



        public int CompareTo(Pokoj other)
        {
            //throw new NotImplementedException();
            return nrPokoju.CompareTo(other.nrPokoju);
        }
    }
}
