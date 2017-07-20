using Turbomix.CategoriasReceta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbomix
{
    public class CategoriaRecetaRepository : ICategoriaRecetaRepository
    {
        public static IList<CategoriaReceta> ListaCategorias = new List<CategoriaReceta>();

        public void Create(CategoriaReceta _Receta)
        {
            ListaCategorias.Add(_Receta);
        }

        public CategoriaReceta Lee(String _Nombre)
        {
            foreach (CategoriaReceta Categoria in ListaCategorias)
            {
                if (Categoria.Nombre.Equals(_Nombre))
                {
                    return Categoria;
                }
            }
            return null;
        }

        public IList<CategoriaReceta> Lista()
        {
            return ListaCategorias;
        }

        public void Update(String _Nombre, String _NuevoNombre, String _NuevaDescripcion)
        {
            foreach (CategoriaReceta Categoria in ListaCategorias)
            {
                if (Categoria.Nombre.Equals(_Nombre))
                {
                    Categoria.Nombre = _NuevoNombre;
                    Categoria.Descripcion = _NuevaDescripcion;
                }
            }
        }

        public void Delete(String _Nombre)
        {
            foreach (CategoriaReceta Categoria in ListaCategorias)
            {
                if (Categoria.Nombre.Equals(_Nombre))
                {
                    ListaCategorias.Remove(Categoria);
                }
            }
        }
    }
}
