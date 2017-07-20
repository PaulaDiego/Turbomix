using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbomix
{
    public class CategoriaReceta
    {
        public string Nombre;
        public string Descripcion;

        public CategoriaReceta()
        {

        }
        public CategoriaReceta(string _Nombre, string _Descripcion)
        {
            this.Nombre = _Nombre;
            this.Descripcion = _Descripcion;
        }
    }
}
