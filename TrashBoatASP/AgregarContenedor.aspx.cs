using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrashBoatModel.DAL;
using TrashBoatModel.DTO;

namespace TrashBoatASP
{
    public partial class AgregarContenedor : System.Web.UI.Page
    {
        List<Sede> sedes = new List<Sede>();
        private Sede sede = new Sede(1, "Sede Central", "Sede Central Santiago");

        protected void Page_Load(object sender, EventArgs e)
        {
            sedes.Add(sede);
            this.sedeDdl.DataSource = sedes;
            this.sedeDdl.DataTextField = "Nombre";
            this.sedeDdl.DataValueField = "Id";
            this.sedeDdl.DataBind();
        }

        protected void registrarContenedorBtn_Click(object sender, EventArgs e)
        {
            // if(this.Page.IsValid)
            // {
                string numeroSerie = this.numeroSerieTxt.Text.Trim();
                int nivelLlenado = Convert.ToInt32(this.nivelLlenadoTxt.Text.Trim());
                string region = this.regionDdl.SelectedValue.ToString();
                string sede = this.sedeDdl.SelectedValue.ToString();
                int estado = 0;
                switch (estadoDdl.SelectedIndex)
                {
                    case 0:
                        estado = 1;
                        break;
                    case 1:
                        estado = 0;
                        break;
                    case 2:
                        estado = -1;
                        break;
                }

            Contenedor contenedor = new Contenedor()
                {
                    NumeroDeSerie = numeroSerie,
                    NivelLlenado = nivelLlenado,
                    Region = region,
                    IdSede = sede,
                    TipoEstado = estado
                };
                IContenedor dal = new ContenedorDAL();
                dal.Add(contenedor);

                Response.Redirect("DetalleContenedores.aspx");
                
            // }
        }
    }
}