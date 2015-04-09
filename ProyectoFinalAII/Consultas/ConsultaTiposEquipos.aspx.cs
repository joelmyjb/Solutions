using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaTiposEquipos : System.Web.UI.Page
    {
       
        TiposEquipos tiposEquipos = new TiposEquipos();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = tiposEquipos.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }
        }

        string Filtro = "1=1";
        string Campos = "IdEquipo,Descripcion";


        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and Descripcion like '%" + BuscarText.Text + "'";

            }
          


            ConsultaGridView.DataSource = tiposEquipos.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();
        }
    }
}