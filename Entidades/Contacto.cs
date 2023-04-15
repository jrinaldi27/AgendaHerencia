using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Contacto

    {
        private int _codigo;
        private string _direccion;
        private string _telefono;
        private int _llamadas;

        public int Codigo{ get => _codigo; set => _codigo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public string Telefono { get => _telefono; set => _telefono = value; }

        public int Llamadas { get => _llamadas; set => _llamadas = value; }

        public  Contacto (int codigo, string direccion, string telefono)
        {
            _codigo = codigo;
            _direccion = direccion;
            _telefono = telefono;
            _llamadas = 0;
        }

        public abstract void Llamar();
        
       

    }
}
