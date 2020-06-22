using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashBoatModel.DTO;

namespace TrashBoatModel.DAL
{
    public interface IEstado
    {
        void Add(Estado estado);
        List<Estado> GetAll();
        void Delete(Estado estado);
        List<Estado> FindByContenedor(Contenedor contenedor);
    }
}
