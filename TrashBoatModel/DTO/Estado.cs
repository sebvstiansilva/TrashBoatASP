using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Debe permitir ingresar una lectura de estado manualmente a un
contenedor, para lo cual se debe solicitar
o Contenedor (Seleccionable mediante un DropDownList)
o Fecha de Lectura (Debe utilizar un componente asp:Calendar)
o Hora de Lectura (Mediante 2 TextBox, uno para la hora y otro para
los minutos)
o Datos adicionales requeridos en el caso de la evaluación 2*/
namespace TrashBoatModel.DTO
{
    public class Estado
    {
        private int idEstado;
        private DateTime fechaLectura; //incluye la hora 
        private int tipoEstado; //1 Cerca del limite,  0 OK, -1 ERROR
        private int nivelDeLlenado;
        private Contenedor contenedor;

        public Estado()
        {

        }
        public Estado(int idEstado, DateTime fechaLectura, int tipoEstado, int nivelDeLlenado, Contenedor contenedor)
        {
            this.idEstado = idEstado;
            this.fechaLectura = fechaLectura;
            this.tipoEstado = tipoEstado;
            this.nivelDeLlenado = nivelDeLlenado;
            this.contenedor = contenedor;
        }

        public int IdEstado
        {
            get
            {
                return idEstado;
            }

            set
            {
                idEstado = value;
            }
        }

        public DateTime FechaLectura
        {
            get
            {
                return fechaLectura;
            }

            set
            {
                fechaLectura = value;
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

        public int NivelDeLlenado
        {
            get
            {
                return nivelDeLlenado;
            }

            set
            {
                nivelDeLlenado = value;
            }
        }

        public Contenedor Contenedor
        {
            get
            {
                return contenedor;
            }

            set
            {
                contenedor = value;
            }
        }
    }
}
