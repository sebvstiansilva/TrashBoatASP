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
        private int nivelLlenado;
        private String region;
        private String idSede;
        private int tipoEstado;

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

        public int NivelLlenado
        {
            get
            {
                return nivelLlenado;
            }

            set
            {
                nivelLlenado = value;
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

        public string IdSede
        {
            get
            {
                return idSede;
            }

            set
            {
                idSede = value;
            }
        }

        public int TipoEstado
        {
            get
            {
                return tipoEstado;
            }

            set
            {
                tipoEstado = value;
            }
        }
    }
}
