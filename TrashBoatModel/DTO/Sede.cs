using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashBoatModel.DAL;

namespace TrashBoatModel.DTO
{
    public class Sede
    {
        private int id;
        private String nombre;
        private String direccion;
        private List<Contenedor> contenedores;

        public Sede(int id, string nombre, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public void AgregarContenedor(Contenedor contenedor)
        {
            this.contenedores.Add(contenedor);
        }

        

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public List<Contenedor> Contenedores
        {
            get
            {
                return contenedores;
            }

            set
            {
                contenedores = value;
            }
        }
    }
}
