using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
Debe desplegar un GridView con la lista de contenedores, mostrando:
- Numero de serie 
- Nivel de llenado actual (correspondiente a la ultima lectura obtenida)
- Region
- Sede a la cual pertenece.
En la parte superior debe mostrar un DropDownList para permitir el filtro de
contenedor por Región.
*/

namespace TrashBoatModel.DTO
{
    public class Contenedor
    {
        private String numeroDeSerie;
        private List<Estado> estados; // nivel de llenado y el tipo.
        private String region;
        private Sede sede; // Nombre de sede.

         

        public Contenedor()
        {

        }
        

        public Contenedor(string numeroDeSerie, string region, Sede sede)
        {
            this.numeroDeSerie = numeroDeSerie;
            this.region = region;
            this.sede = sede;
        }

        public Contenedor(string numeroDeSerie, List<Estado> estados)
        {
            this.numeroDeSerie = numeroDeSerie;
            this.estados = estados;
        }

        public string NumeroDeSerie
        {
            get
            {
                return numeroDeSerie;
            }

            set
            {
                numeroDeSerie = value;
            }
        }

        public List<Estado> Estados
        {
            get
            {
                return estados;
            }

            set
            {
                estados = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        public Sede Sede
        {
            get
            {
                return sede;
            }

            set
            {
                sede = value;
            }
        }

        public void setEstados(List<Estado> estados)
        {
            this.estados = estados;
        }
    }
}
