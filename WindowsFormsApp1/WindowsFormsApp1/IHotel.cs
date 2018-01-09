using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP
{
    interface IHotel
    {
        void DodajRezerwacje(string imie, string nazwisko, int nrPokoju, double cenaZaDzien);
        void OdwolajRezerwacje();
    }
}
