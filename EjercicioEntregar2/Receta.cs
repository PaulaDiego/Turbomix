using Turbomix.CategoriasReceta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbomix
{
    public class Receta
    {
        public Alimento Alimento1;
        public Alimento Alimento2;
        public CategoriaReceta Categoria;

        public Receta()
        {

        }
        public Receta(Alimento _Alimento1, Alimento _Alimento2)
        {
            this.Alimento1 = _Alimento1;
            this.Alimento2 = _Alimento2;
        }
        public Receta(Alimento _Alimento1, Alimento _Alimento2,CategoriaReceta _Categoria)
        {
            this.Alimento1 = _Alimento1;
            this.Alimento2 = _Alimento2;
            this.Categoria = _Categoria;
        }
    }
    

}
