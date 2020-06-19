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
        private int id;
        private Contenedor idContenedor;
        private DateTime fechaLectura; //incluye la hora 
        private int tipoEstado; //1 Cerca del limite,  0 OK, -1 ERROR

        public Estado(int id, Contenedor idContenedor, DateTime fechaLectura, int tipoEstado)
        {
            this.id = id;
            this.idContenedor = idContenedor;
            this.fechaLectura = fechaLectura;
            this.tipoEstado = tipoEstado;
        }

        public Estado()
        {
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

        public Contenedor IdContenedor
        {
            get
            {
                return idContenedor;
            }

            set
            {
                idContenedor = value;
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
    }
}
