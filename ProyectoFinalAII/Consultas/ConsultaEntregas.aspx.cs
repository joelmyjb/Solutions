using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaEntregas : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = entregas.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }

        }

        Entregas entregas = new Entregas();
        string Filtro = "1=1";
        string Campos = "IdEntrega, Fecha, Monto";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and IdEntrega like '%" + BuscarText.Text + "'";

            }
           

            ConsultaGridView.DataSource = entregas.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();
        }
    }
}