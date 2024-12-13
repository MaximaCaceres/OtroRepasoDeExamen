using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTUP.Models
{
    public class Presupuesto
    {
        public double Precio {  get; set; }
        private Cliente solicitante {  get; set; }
        List<Producto> listaProductos = new List<Producto>();
        public Presupuesto(string nom, string dir)
        {
           solicitante = new Cliente(nom, dir);//porque es por composicion.
        }
        public int CantidadPro
        {
            get
            {
                return listaProductos.Count;
            }
        }
        public Producto this[int idx]
        {
            get
            {
                Producto p = null;
                if(idx >= 0 && idx < listaProductos.Count)
                {
                    p = listaProductos[idx];
                }
                return p;
            }
        }
        public void AgregarProducto(Producto pro)
        {
            if (pro != null)
            {
                listaProductos.Add(pro);
            }        
        }
        public bool QuitarProducto(Producto pro)
        {
            bool quito = false;
            if(pro != null)
            {
                listaProductos.Remove(pro);
                quito = true;
            }
            return quito;
        }
        private Producto BuscarProducto(int code)
        {
            Producto p = null;
            Banco b = new Banco(0, 0);
            b.Codigo = code;
            listaProductos.Sort();
            int idx = listaProductos.BinarySearch(b);
            if(idx >= 0)
            {
                p = listaProductos[idx];
            }
            return p;
        }

        public string[] Resumen()
        {
            int count = 0;
            string[] date = new string[listaProductos.Count];
            foreach(Producto p in listaProductos)
            {
                date[count] = p.Detalle();
                count++;
            }
            return date;
        }
    }
}
