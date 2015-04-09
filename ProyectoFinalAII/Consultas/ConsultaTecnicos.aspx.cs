using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaTecnicos : System.Web.UI.Page
    {

        Tecnicos tecnicos = new Tecnicos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = tecnicos.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }

        }

        string Filtro = "1=1";
        string Campos = "IdTecnicos,Nombres, Telefono ";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            string Filtro = "1 = 1";
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and IdTecnicos like '%" + BuscarText.Text + "'";

            }
            else
                if (BuscarDropDownList.SelectedIndex == 1)
                {
                    Filtro += " and Nombres like '%" + BuscarText.Text + "%'";
                }


            ConsultaGridView.DataSource = tecnicos.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();
        }
    }
}