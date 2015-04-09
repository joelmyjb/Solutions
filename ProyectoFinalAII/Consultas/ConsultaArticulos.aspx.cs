using BLL;
using ProyectoFinalAII.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaArticulos : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = articulos.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }

        }
        Articulos articulos = new Articulos();
        string Filtro = "1=1";
        string Campos = "IdArticulo,Descripcion, Existencia, Costo, Precio ";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and IdArticulo like '%" + BuscarText.Text + "'";

            }
            else
                if (BuscarDropDownList.SelectedIndex == 1)
                {
                    Filtro += " and Descripcion like '%" + BuscarText.Text + "%'";
                }


            ConsultaGridView.DataSource = articulos.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();

        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}