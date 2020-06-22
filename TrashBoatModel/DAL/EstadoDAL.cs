using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashBoatModel.DTO;

namespace TrashBoatModel.DAL
{
    public class EstadoDAL : IEstado
    {
        public static List<Estado> estados = new List<Estado>();
        private static EstadoDAL instance;

        public EstadoDAL() {

        }

        private static EstadoDAL Instance() {
            if (instance == null) {
                instance = new EstadoDAL();
            }
            return instance;
        }

        public void Add(Estado estado)
        {
            estados.Add(estado);
        }

        public void Delete(Estado estado)
        {
            estados.Remove(estado);
        }

        public Estado EstadoById(int id)
        {
            return estados.Find(e => e.IdEstado == id);
        }

        public List<Estado> FindByContenedor(Contenedor contenedor)
        {
            return estados.FindAll(e => e.Contenedor.NumeroDeSerie == contenedor.NumeroDeSerie);
        }

        public List<Estado> GetAll()
        {
            return estados;
        }
    }
}
