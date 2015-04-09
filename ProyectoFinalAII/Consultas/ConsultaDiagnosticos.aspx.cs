using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaDiagnosticos : System.Web.UI.Page
    {
       
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = diagnosticos.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }

        }

        Diagnosticos diagnosticos = new Diagnosticos();
        string Filtro = "1=1";
        string Campos = "IdDiagnostico,Descripcion ";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and Descripcion like '%" + BuscarText.Text + "'";

            }
          

            ConsultaGridView.DataSource = diagnosticos.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();
        }

        protected void BuscarDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}