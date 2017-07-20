using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbomix.CategoriasReceta
{
    public class CategoriaRecetaService : ICategoriaRecetaService
    {
        private ICategoriaRecetaRepository CategoriaRecetaRepository;

        public CategoriaRecetaService(ICategoriaRecetaRepository CategoriaRecetaRepository)
        {
            this.CategoriaRecetaRepository = CategoriaRecetaRepository;
        }

        public void Guardar(CategoriaReceta _CategoriaReceta)
        {
            CategoriaRecetaRepository.Create(_CategoriaReceta);
        }

        public CategoriaReceta Lee(String _Nombre)
        {
            return CategoriaRecetaRepository.Lee(_Nombre);
        }

        public IList<CategoriaReceta> Lista()
        {
            return CategoriaRecetaRepository.Lista();
        }

        public void Update(String _Nombre, String _NuevoNombre, string _NuevaDescripcion)
        {
            CategoriaRecetaRepository.Update(_Nombre, _NuevoNombre, _NuevaDescripcion);
        }

        public void Delete(String _Nombre)
        {
            CategoriaRecetaRepository.Delete(_Nombre);
        }
    }
}
