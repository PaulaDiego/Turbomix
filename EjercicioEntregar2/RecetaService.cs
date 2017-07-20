using Turbomix.CategoriasReceta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbomix
{
    public class RecetaService : IRecetaService
    {
        private IRecetaRepository Recetario;
        private ICategoriaRecetaService Categorias;

        public RecetaService(IRecetaRepository _Recetario, ICategoriaRecetaService _Categorias)
        {
            this.Recetario = _Recetario;
            this.Categorias = _Categorias;
        }
        public void Guardar(Receta _Receta)
        {
            if (Categorias.Lee(_Receta.Categoria.Nombre) != null)
            {
                Recetario.Create(_Receta);
            }else
            {
                throw new Exception();
            }
            
        }

        public Receta Lee(String _Nombre)
        {
            return Recetario.Lee(_Nombre);
        }

        public IList<Receta> Lista()
        {
            return Recetario.Lista();
        }

        public void Update(String _Nombre, String _NuevoNombre)
        {
            Recetario.Update(_Nombre, _NuevoNombre);
        }

        public void Delete(String _Nombre)
        {
            Recetario.Delete(_Nombre);
        }
    }
}
