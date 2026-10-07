using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp2
{
    internal class Reserva
    {
        public decimal TarifaPorNoche = 180m;
        public int Noches = 10;
        public string Huesped;
        public int tasa = 63;
        public decimal pesos = 1;
        public decimal Total
        {
            get { return Noches * TarifaPorNoche; }
        }


    }
}
