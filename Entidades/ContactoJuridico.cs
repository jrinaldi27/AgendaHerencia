using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ContactoJuridico: Contacto
    {
        private string _razonSocial;
        private DateTime _fechaConstitucion;

        public string razonSocial { get => _razonSocial; set => _razonSocial = value; }
        public DateTime fechaConstitucion { get => _fechaConstitucion; set => _fechaConstitucion = value; }


        public ContactoJuridico(int codigo, string razonSocial, DateTime fechaConstitucion, string telefono, string direccion): base (codigo, direccion, telefono)
        {

        }

        public override void Llamar()
        {
            Llamadas++;
        }

        public int Antiguedad()
        {
            double calculo = ((DateTime.Now - _fechaConstitucion).TotalDays) / 365;

            return Convert.ToInt32(calculo);
        }

    }
}
