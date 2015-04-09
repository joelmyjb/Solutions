using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaSuplidor : System.Web.UI.Page
    {
        Suplidor suplidor = new Suplidor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = suplidor.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }
        }

        string Filtro = "1=1";
        string Campos = "IdSuplidor,Nombres ";
        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and IdSuplidor like '%" + BuscarText.Text + "'";

            }
            else
                if (BuscarDropDownList.SelectedIndex == 1)
                {
                    Filtro += " and Nombres like '%" + BuscarText.Text + "%'";
                }


            ConsultaGridView.DataSource = suplidor.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();

        }
    }
}