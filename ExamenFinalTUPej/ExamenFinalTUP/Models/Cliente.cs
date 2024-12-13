using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTUP.Models
{
    public class Cliente
    {
        private string nombre;
        private string direccion;
        public Cliente(string nom, string dir)
        {
            nombre = nom;
            direccion = dir;
        }
        public override string ToString()
        {
            string date = $"{nombre};{direccion}";
            return date;
        }
    }
}
