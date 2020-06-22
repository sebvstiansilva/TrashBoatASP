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
    public partial class MostrarEstados : System.Web.UI.Page
    {
        private static IEstado estadoDAL = new EstadoDAL();
        private static List<Estado> estados = estadoDAL.GetAll();
        private static List<Contenedor> contenedores = new ContenedorDAL().GetAll();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                
                //ListItem li = new ListItem();
                //li.Text = "Seleccione contenedor...";
                //li.Value = "0";
                
                //cargarTabla(estados);
                //filtroContenedorDdl.DataSource = estados;
                //filtroContenedorDdl.DataTextField = "IdEstado";
                //filtroContenedorDdl.DataValueField = "IdEstado";
                //filtroContenedorDdl.DataBind();
                //filtroContenedorDdl.Items.Add(li);
            }
        }

        //private void cargarTabla(List<Estado> estados)
        //{
        //    this.estadosGrid.DataSource = estados;
        //    this.estadosGrid.DataBind();
        //}

        //protected void filtroContenedorDdl_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selected = this.filtroContenedorDdl.SelectedItem.Value;
        //    Contenedor contenedor = contenedores.Find(c => c.NumeroDeSerie == selected);
        //    if (selected == "0")
        //    {
        //        cargarTabla(estadoDAL.GetAll());
        //    } else
        //    {
        //        cargarTabla(estadoDAL.FindByContenedor(contenedor));
        //    }
        //}

        protected void Chart1_Load(object sender, EventArgs e)
        {
            
        }
    }
}