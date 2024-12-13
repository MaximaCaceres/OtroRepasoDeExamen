using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTUP.Models
{
    public abstract class Producto:IExportable
    {
        protected double precioBase = 0;
        protected double largo = 0;
        private int codigo = 0;
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public Producto(double pre, double lar)
        {
            precioBase = pre;
            largo = lar;
        }
        public abstract double Peso();
        public abstract double Precio();
        public virtual string Detalle()
        {
            string date = $"{codigo};{precioBase};{largo}";
            return date;
        }

        public virtual void Leer(string n)
        {
           
        }

        public virtual string Escribir()
        {
            return Detalle();
        }
    }
}
