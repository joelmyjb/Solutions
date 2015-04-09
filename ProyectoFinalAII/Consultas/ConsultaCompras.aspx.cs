using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = compras.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();

                ConsultaGridView.DataSource = comprasDetalle.Lista(Campo, FiltroWhere);
                ConsultaGridView.DataBind();
            }

        }

        Compras compras = new Compras();
       
        string Filtro = "1=1";
        string Campos = " IdUsuario,  Monto";

        ComprasDetalle comprasDetalle = new ComprasDetalle();
        string FiltroWhere = "1=1";
        string Campo = "IdArticulo, Cantidad, Costo";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
                if (BuscarDropDownList.SelectedIndex == 0)
                {
                    Filtro += " and IdUsuario like '%" + BuscarText.Text + "%'";
                }


            ConsultaGridView.DataSource = compras.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();

            //ConsultaGridView.DataSource = comprasDetalle.Lista(Campo, FiltroWhere);
            //ConsultaGridView.DataBind();
        }
    }
}