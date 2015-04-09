using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroTiposEquipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TiposEquipos tiposequipos = new TiposEquipos();
            if (!IsPostBack)
            {
                if (Request.QueryString["IdEquipo"] != null)
                {
                    EliminarButton.Visible = true;
                    tiposequipos.IdEquipo = int.Parse(Request.QueryString["IdEquipo"]);
                    if (tiposequipos.Buscar())
                    {
                        DescripcionTextBox.Text = tiposequipos.Descripcion;



                    }

                }

            }
        }

        public void LLenarClase(TiposEquipos tiposequipos)
        {

            tiposequipos.Descripcion = DescripcionTextBox.Text;

        }

        private void LlenarCampos(TiposEquipos tiposequipos)
        {

            IdEquipoTextBox.Text = tiposequipos.IdEquipo.ToString();
            DescripcionTextBox.Text = tiposequipos.Descripcion;

        }

        public void LimpiarCampos()
        {
            this.DescripcionTextBox.Text = "";
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            TiposEquipos tiposequipos = new TiposEquipos();
           if( tiposequipos.Eliminar(Convert.ToInt32(IdEquipoTextBox.Text.Trim())))
           {
               MensajeLabel.ForeColor = System.Drawing.Color.Green;
               MensajeLabel.Text = "Se elimino...";
               LimpiarCampos();
           }

            LimpiarCampos();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            TiposEquipos tiposequipos = new TiposEquipos();
            this.LLenarClase(tiposequipos);
            if (Request.QueryString["IdEquipo"] != null)
            {
                tiposequipos.IdEquipo = int.Parse(Request.QueryString["IdEquipo"]);
                if (tiposequipos.Modificar())
                {
                    Response.Write("Se ha modificado!!");
                    LimpiarCampos();
                }

            }
            else 
            if(tiposequipos.Insertar())
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Realizado con exito..";
                LimpiarCampos();
            }

            
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}