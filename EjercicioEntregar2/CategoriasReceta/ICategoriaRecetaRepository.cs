using System.Collections.Generic;
using Turbomix.CategoriasReceta;

namespace Turbomix
{
    public interface ICategoriaRecetaRepository
    {
        void Create(CategoriaReceta _Receta);
        void Delete(string _Nombre);
        CategoriaReceta Lee(string _Nombre);
        IList<CategoriaReceta> Lista();
        void Update(string _Nombre, string _NuevoNombre, string _NuevaDescripcion);
    }
}