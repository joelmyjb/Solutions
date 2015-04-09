using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaPagoTecnico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = pagoTecnico.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }
        }

        PagoTecnico pagoTecnico = new PagoTecnico();
        string Filtro = "1=1";
        string Campos = "IdPagoTecnico, IdTecnico, IdUsuario ";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and IdPagoTecnico like '%" + BuscarText.Text + "'";

            }
            else
                if (BuscarDropDownList.SelectedIndex == 1)
                {
                    Filtro += " and IdTecnico like '%" + BuscarText.Text + "%'";
                }


            ConsultaGridView.DataSource = pagoTecnico.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();
        }
    }
}