using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Agenda
    {
        private string _nombre;
        private string _tipo;
        private List<Contacto> _contactos;
        private int _cantidadMaximaContactos;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public int CantidadMaximaContactos { get => _cantidadMaximaContactos; set => _cantidadMaximaContactos = value; }
        public List<Contacto> Contactos { get => _contactos; set => _contactos = value; }


        public Agenda (string nombre, string tipo, int cantidadMaximaContactos)
        {
            Nombre = nombre;
            Tipo = tipo;
            CantidadMaximaContactos = cantidadMaximaContactos;
            _contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto c)
        {
            if(_contactos.Count > _cantidadMaximaContactos)
            {
                throw new Exception("Ya se alcanzo la cantidad maxima de contactos");
            }

            else
            {
                foreach (Contacto a in _contactos)
                {
                    if (c.Codigo == a.Codigo)
                    {
                        throw new Exception("Este contacto ya existe en su agenda");
                    }

                    else
                    {
                        _contactos.Add(c);
                    }
                }
            }
        }

        public void EliminarContacto(int codigo)
        {
            Contacto contacto = _contactos.Find(x => x.Codigo == codigo);

            if (contacto == null)
            {
                throw new Exception("El Contacto ingresado no es valido");
            }
            else
            {
                _contactos.Remove(contacto);
            }
        }

        public Contacto  TraerContactoFrecuente()
        {

            int CantidadLlamadas = 0;
            Contacto ContactoFrecuenta = null;
            foreach (var contacto in _contactos)
            {
                if (contacto.Llamadas > CantidadLlamadas)
                {
                    CantidadLlamadas = contacto.Llamadas;
                    ContactoFrecuenta = contacto;
                }
            }
            return ContactoFrecuenta;

        }
    }
}
