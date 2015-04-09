using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Consultas
{
    public partial class ConsultaRecepciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                ConsultaGridView.DataSource = recepciones.Lista(Campos, Filtro);
                ConsultaGridView.DataBind();
            }
        }
        Recepciones recepciones = new Recepciones();
        string Filtro = "1=1";
        string Campos = "IdRecepciones,Fecha, Serial ";

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro += "and IdRecepciones like '%" + BuscarText.Text + "'";

            }
           


            ConsultaGridView.DataSource = recepciones.Lista(Campos, Filtro);
            ConsultaGridView.DataBind();

        }
        }
    }
