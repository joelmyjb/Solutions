using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaClientes : System.Web.UI.Page
    {
       
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = clientes.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }
           
        }
        
        Clientes clientes = new Clientes();
        string Filtro = "1=1";
        string Campos = "IdCliente,Nombres, Telefono ";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {


            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and IdCliente like '%" + BuscarText.Text + "'";

            }
            else
                if (BuscarDropDownList.SelectedIndex == 1)
                {
                    Filtro += " and Nombres like '%" + BuscarText.Text + "%'";
                }
             

            ConsultaGridView.DataSource = clientes.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();
        }

        protected void ConsultaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BuscarDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}