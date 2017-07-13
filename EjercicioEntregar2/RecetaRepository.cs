using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaRepository : IRecetaRepository
    {
        public static List<Receta> ListaRecetas;
        //CRUD
        public void CreateReceta(Receta _Receta)
        {
            ListaRecetas.Add(_Receta);
        }

    }
}
