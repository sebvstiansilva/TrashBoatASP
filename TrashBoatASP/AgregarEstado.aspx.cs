using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrashBoatModel.DAL;
using TrashBoatModel.DTO;

namespace TrashBoatASP
{
    public partial class AgregarEstado : System.Web.UI.Page
    {
        private static IContenedor contenedoresDAL = new ContenedorDAL();
        private static IEstado estadosDAL = new EstadoDAL();
        private static List<Contenedor> contenedores = contenedoresDAL.GetAll();
        private static List<Estado> estados = estadosDAL.GetAll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                this.contenedoresDdl.DataSource = contenedores;
                this.contenedoresDdl.DataTextField = "NumeroDeSerie";
                this.contenedoresDdl.DataValueField = "NumeroDeSerie";
                this.contenedoresDdl.DataBind();
            }
        }

        protected void registrarEstadoBtn_Click(object sender, EventArgs e)
        {
            if (this.Page.IsValid)
            {
                // TODO: Todos los datos para ingresar un nuevo Estado a un Contenedor.
                // TODO: Traer el contenedor seleccionado y luego darle el contenedor a la lista de estado.
                String contenedorListSelected = this.contenedoresDdl.SelectedItem.Value;
                Contenedor contenedorSelected = contenedores.Find(c => c.NumeroDeSerie == contenedorListSelected);

                int horaTxt = Convert.ToInt32(this.horaTxt.Text);
                int minutosTxt = Convert.ToInt32(this.minutosTxt.Text);
                var date = new DateTime(
                    this.fechaLectura.SelectedDate.Year,
                    this.fechaLectura.SelectedDate.Month,
                    this.fechaLectura.SelectedDate.Day,
                    horaTxt,
                    minutosTxt, 0);
                DateTime fechaLectura = date;
                int nivelLlenado = Convert.ToInt32(this.nivelLlenadoTxt.Text);
                int tipoEstado = Convert.ToInt32(this.tipoDdl.SelectedItem.Value);

                int idEstadoU = horaTxt + minutosTxt + contenedorSelected.GetHashCode();

                Estado estado = new Estado()
                {
                    IdEstado = idEstadoU,
                    FechaLectura = fechaLectura,
                    TipoEstado = tipoEstado,
                    NivelDeLlenado = nivelLlenado,
                    Contenedor = contenedorSelected
                };

                IEstado dal = new EstadoDAL();
                dal.Add(estado);

                Contenedor contenedor = contenedores.FindLast(c => c.NumeroDeSerie == contenedorListSelected);
                contenedor.setEstados(estados);
                // Agregar ese estado a la lista de estados del contenedor seleccionado.
                Response.Redirect("MostrarEstados.aspx");

            }
        }

        protected void fechaLecturaValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (fechaLectura.SelectedDate.Date == DateTime.MinValue)
            {
                args.IsValid = false;
            } else
            {
                args.IsValid = true;
            }
        }

        protected void horaValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Regex rg = new Regex("[0-9]*$");
            args.IsValid = rg.IsMatch(this.horaTxt.Text);
        }

        protected void minutoValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Regex rg = new Regex("[0-9]*$");
            args.IsValid = rg.IsMatch(this.minutosTxt.Text);
            int minuto = 0;
            args.IsValid = Int32.TryParse(this.minutosTxt.Text, out minuto);
            if (minuto >= 0)
            {
                args.IsValid = true;
            }
            else if (minuto <= 59)
            {
                args.IsValid = true;

            }
            else
            {
                args.IsValid = false;
                horaValidator.ErrorMessage = "Minuto invalida";
            }
        }

        protected void nivelValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Regex rg = new Regex("[0-9]*$");
            args.IsValid = rg.IsMatch(this.nivelLlenadoTxt.Text);
        }
    }
}