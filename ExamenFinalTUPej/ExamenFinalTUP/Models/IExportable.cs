using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalTUP.Models
{
    public interface IExportable
    {
        void Leer(string n);

        string Escribir();
    }
}
