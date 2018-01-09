using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP
{
    class Hotel : IHotel, IData
    {
        private SortedDictionary<Pokoj, Gosc> rezerwacje = new SortedDictionary<Pokoj, Gosc>();
        private double zysk;
        private DateTime data;

        public Hotel() { zysk = -80d; }
        //public Hotel(SortedDictionary<Pokoj, Gosc> rezerwacje, double zysk, DateTime data)
        //{
        //    this.rezerwacje = rezerwacje;
        //    this.zysk = zysk;
        //    this.data = data;
        //}

        public void DodajRezerwacje(string imie, string nazwisko, int nrPokoju, double cenaZaDzien)
        {
            rezerwacje.Add(new Pokoj(nrPokoju, cenaZaDzien), new Gosc(imie, nazwisko));
            zysk += cenaZaDzien;
        }
        public void OdwolajRezerwacje()
        {
            rezerwacje.Remove(rezerwacje.Keys.Last());
        }

        public bool SprawdzDate()
        {
            if (data.Date >= DateTime.Now.Date) { return true; }
            return false;
        }

        public void UstawDate(DateTime date)
        {
            data = date;
        }

        public override string ToString()
        {
            string sr = "Rezerwacje: Data: " + data.Date.ToString("MM.dd.yyyy") + "\n";
            // +  rezerwacje.Values + rezerwacje.Keys + " Zysk: " + zysk;

            foreach (var s in rezerwacje)
            {
                sr += "[" + s.Key.ToString() + " ; " + s.Value.ToString() + "]" + "\n";

            }



            return sr + "Zysk: " + zysk;
        }
    }
}
