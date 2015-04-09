using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaUsuarios : System.Web.UI.Page
    {
       
        Usuarios usuarios = new Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = usuarios.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }
        }

        string Filtro = "1=1";
        string Campos = "IdUsuario,Nombre, Clave";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and Nombre like '%" + BuscarText.Text + "'";

            }


            ConsultaGridView.DataSource = usuarios.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();
        }
    }
}