using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashBoatModel.DTO;

namespace TrashBoatModel.DAL
{
    class EstadoDAL : IEstado
    {
        private List<Estado> lista = new List<Estado>();
        private static EstadoDAL instance;

        private EstadoDAL() {

        }

        public static EstadoDAL Instance() {
            if (instance == null) {
                instance = new EstadoDAL();
            }
            return instance;
        }

        public void Add(Estado estado)
        {
            lista.Add(estado);
        }

        public void Delete(Estado estado)
        {
            lista.Remove(estado);
        }

        public List<Estado> GetAll()
        {
            return lista;
        }
    }
}
