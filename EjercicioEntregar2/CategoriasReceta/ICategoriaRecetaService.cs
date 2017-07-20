using System.Collections.Generic;

namespace Turbomix
{
    public interface ICategoriaRecetaService
    {
        void Delete(string _Nombre);
        void Guardar(CategoriaReceta _CategoriaReceta);
        CategoriaReceta Lee(string _Nombre);
        IList<CategoriaReceta> Lista();
        void Update(string _Nombre, string _NuevoNombre, string _NuevaDescripcion);
    }
}