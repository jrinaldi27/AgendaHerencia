using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ContactoPersona : Contacto
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public ContactoPersona(int codigoContacto, string nombre, string apellido, string telefono, DateTime fechaNacimiento, string direccion) : base(codigoContacto, direccion, telefono)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fechaNacimiento;
            
        }
        

        public override void Llamar()
        {
            Llamadas++;
        }

        public int Edad()
        {
            double calculo = ((DateTime.Now - _fechaNacimiento).TotalDays) / 365;

            return Convert.ToInt32(calculo);


        }

    }




}
