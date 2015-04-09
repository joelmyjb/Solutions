using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaEstados : System.Web.UI.Page
    {
       
        Estados estados = new Estados();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = estados.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }
        }
        string Filtro = "1=1";
        string Campos = "IdEstado,Descripcion ";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and Descripcion like '%" + BuscarText.Text + "'";

            }


            ConsultaGridView.DataSource = estados.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();
        }
    }
}