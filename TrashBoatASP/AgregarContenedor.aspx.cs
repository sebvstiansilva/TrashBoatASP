using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrashBoatModel.DAL;
using TrashBoatModel.DTO;

namespace TrashBoatASP
{
    public partial class AgregarContenedor : System.Web.UI.Page
    {

        private Regex rg = new Regex("^[a-zA-Z0-9 ]*$");
        
        private static List<Sede> sedes = new List<Sede> {
            new Sede {
                Id = 1,
                Nombre = "Sede Central",
                Direccion = "Sede Central Santiago"
            },
            new Sede
            {
                Id = 2,
                Nombre = "Sede Valparaiso",
                Direccion = "Av. España 225"
            }
            };
        private static List<Contenedor> contenedores = new ContenedorDAL().GetAll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.sedeDdl.DataSource = sedes;
                this.sedeDdl.DataValueField = "Id";
                this.sedeDdl.DataTextField = "Nombre";
                this.sedeDdl.DataBind();
            }
        }

        protected void registrarContenedorBtn_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                string numeroSerie = this.numeroSerieTxt.Text.Trim().ToUpper();
                string region = this.regionDdl.SelectedValue.ToString();
                int idSedeSelected = Int32.Parse(sedeDdl.SelectedItem.Value);
                Sede sedeSelected = sedes.Find(s => s.Id == idSedeSelected); // Predicado que busca el objeto con el id obtenido en el dropdown
                
                Contenedor contenedor = new Contenedor()
                {
                    NumeroDeSerie = numeroSerie,
                    Region = region,
                    Sede = sedeSelected
                };

                IContenedor dal = new ContenedorDAL();
                
                dal.Add(contenedor);
                
                Response.Redirect("DetalleContenedores.aspx");

            }
        }

        protected void numeroSerieValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (contenedores.Exists(c => c.NumeroDeSerie == numeroSerieTxt.Text))
            {
                args.IsValid = false;
                existValidator.ErrorMessage = "Ya existe este contenedor<br>";
            } else if (!rg.IsMatch(numeroSerieTxt.Text))
            {
                args.IsValid = false;
                existValidator.ErrorMessage = "No puede ingresar caracteres especiales<br>";
            } else
            {
                args.IsValid = true;
            }

        }

        protected void regionValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (regionDdl.SelectedItem.Value != "0");
        }
    }
}