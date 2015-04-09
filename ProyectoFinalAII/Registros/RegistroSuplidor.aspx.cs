using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroSuplidor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["IdSuplidor"] != null)
                {
                    Suplidor suplidor = new Suplidor();
                    EliminarButton.Visible = true;
                    suplidor.IdSuplidor = int.Parse(Request.QueryString["IdSuplidor"]);
                    if (suplidor.Buscar())
                    {
                        NombresTextBox.Text = suplidor.Nombres;
                     

                    }

                }
            }

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Suplidor suplidor = new Suplidor();
            this.LLenarClase(suplidor);

            if (Request.QueryString["IdSuplidor"] != null)
            {
                suplidor.IdSuplidor = int.Parse(Request.QueryString["IdSuplidor"]);
                if (suplidor.Modificar())
                {
                    Response.Write("Se ha modificado!!");
                    LimpiarCampos();
                }

            }
            else
            if(suplidor.Insertar())
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Realizado con exito..";
                LimpiarCampos();
            }

          
        }

        public void LLenarClase(Suplidor suplidor)
        {

            suplidor.Nombres = NombresTextBox.Text;

        }

        private void LlenarCampos(Suplidor suplidor)
        {

            IdSuplidorTextBox.Text = suplidor.IdSuplidor.ToString();
            NombresTextBox.Text = suplidor.Nombres;

        }

        public void LimpiarCampos()
        {
            this.NombresTextBox.Text = "";
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Suplidor suplidor = new Suplidor();
            if(suplidor.Eliminar(Convert.ToInt32(IdSuplidorTextBox.Text.Trim())))
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Se elimino el suplidor..";
                LimpiarCampos();
            }

            
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}