using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashBoatModel.DTO;

namespace TrashBoatModel.DAL
{
    public interface IContenedor 
    {
        void Add(Contenedor contenedor);
        List<Contenedor> GetAll();
        void Delete(Contenedor contenedor);
        List<Contenedor> FindByRegion(string region);
    }
}
