using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaService : IRecetaService
    {
        private IRecetaRepository Recetario;

        public RecetaService(IRecetaRepository _Recetario)
        {
            this.Recetario = _Recetario;
        }
        public void Guardar(Receta _Receta)
        {
            Recetario.Create(_Receta);
        }

    }
}
