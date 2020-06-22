using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrashBoatModel.DAL;
using TrashBoatModel.DTO;

namespace TrashBoatASP
{
    public partial class DetalleContenedores : System.Web.UI.Page
    {
        private IContenedor contenedoresDAL = new ContenedorDAL(); //CHUPPICO POR LE PICO POR EL PICO

        private List<String> regiones = new List<string>() {
            "Todos",
            "Región Arica y Parinacota",
            "Región de Tarapacá",
            "Región de Atacama",
            "Región de Coquimbo",
            "Región de Valparaíso",
            "Región Metropolitana",
            "Región del Libertador Bernardo O'higgins",
            "Región del Maule",
            "Región del Ñuble",
            "Región del Bio Bío",
            "Región de la Araucanía",
            "Región de los Ríos",
            "Región del los Lagos",
            "Región de Aysén del General Carlos Ibáñez del Campo",
            "Región de Magallanes y de la Antártica Chilena"
        };
        private List<Contenedor> contenedores = new ContenedorDAL().GetAll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarTabla(contenedores);
                this.filtroDdl.DataSource = regiones;
                this.filtroDdl.DataBind();
            }
        }

        private void cargarTabla(List<Contenedor> contenedores)
        {
            this.contenedoresGrid.DataSource = contenedores;
            this.contenedoresGrid.DataBind();
        }

        protected void filtroDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.filtroDdl.SelectedItem.Value;
            if (selected == "Todos")
            {
                cargarTabla(this.contenedoresDAL.GetAll());
            } else
            {
                cargarTabla(this.contenedoresDAL.FindByRegion(selected));
            }
        }
    }
}