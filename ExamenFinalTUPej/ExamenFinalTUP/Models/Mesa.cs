using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTUP.Models
{
    public class Mesa:Producto,IComparable
    {
        private double ancho = 0;
        private double grosor = 0;
        public Mesa(double pre, double lar,double anch,double gro) : base(pre, lar)
        {

        }
        public override double Peso()
        {
            double pesoT = (largo * ancho * grosor) * 0.3;
            return pesoT;
        }
        public override double Precio()
        {
            double precioT = Peso() * precioBase * 1.25;
            return precioT;
        }
        public int CompareTo(object obj)
        {
            Mesa m = obj as Mesa;
            if (m != null)
            {
                return Codigo.CompareTo(m.Codigo);
            }
            return 1;
        }
        public override string Detalle()
        {
           string date = $"{base.Detalle()};{ancho};{grosor}";
            return date;
        }
        public Mesa():base(0,0)
        {

        }
        public override void Leer(string n)
        {
            string[] dat = n.Split(';');
            Codigo = Convert.ToInt32(dat[0]);
            precioBase = Convert.ToDouble(dat[1]);
            largo = Convert.ToDouble(dat[2]);
            ancho = Convert.ToDouble(dat[3]);
            grosor = Convert.ToDouble(dat[4]);
        }

        public override string Escribir()
        {
            return Detalle();
        }
    }
}
