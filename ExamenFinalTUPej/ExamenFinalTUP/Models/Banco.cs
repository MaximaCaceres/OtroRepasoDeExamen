using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTUP.Models
{
    public class Banco:Producto,IComparable
    {
        public Banco(double pre, double lar) : base(pre, lar)
        {

        }

        public int CompareTo(object obj)
        {
            Banco b = obj as Banco;
            if (b!= null)
            {
                return Codigo.CompareTo(b.Codigo);
            }
            return 1;
        }

        public override double Peso()
        {
            double pesoT = (largo * 0.25) * 0.42;
            return pesoT;
        }
        public override double Precio()
        {
            double precioT = Peso() * precioBase * 1.15;
            return precioT;
        }

        public override string Detalle()
        {
            return base.Detalle();
        }
        public Banco() : base(0, 0)
        {

        }
        public override void Leer(string n)
        {
            string[] dat = n.Split(';');
            Codigo = Convert.ToInt32(dat[0]);
            precioBase = Convert.ToDouble(dat[1]);
            largo = Convert.ToDouble(dat[2]);
            //codigo;precioBase;Largo
        }

        public override string Escribir()
        {
            return Detalle();
        }
    }

    
}
