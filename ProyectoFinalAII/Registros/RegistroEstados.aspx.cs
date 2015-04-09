using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroEstados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["IdEstado"] != null)
                {
                    Estados estados = new Estados();
                    EliminarButton.Visible = true;
                    estados.IdEstado = int.Parse(Request.QueryString["IdEstado"]);
                    if (estados.Buscar())
                    {
                        IdEstadoTextBox.Text = estados.IdEstado.ToString();
                        DescripcionTextBox.Text = estados.Descripcion;



                    }

                }

            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Estados estados = new Estados();
            this.LLenarClase(estados);
            if (Request.QueryString["IdEstado"] != null)
            {
                estados.IdEstado = int.Parse(Request.QueryString["IdEstado"]);
                estados.Modificar();
                MensajeLabel.Text = "El estado se ha Modificado Correctamente";
            }
            else
            if(estados.Insertar())
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Realizado con exito..";
                LimpiarCampos();
            }

           
        }

        public void LLenarClase(Estados estados)
        {

            estados.Descripcion = DescripcionTextBox.Text;

        }

        private void LlenarCampos(Estados estados)
        {

            IdEstadoTextBox.Text = estados.IdEstado.ToString();
            DescripcionTextBox.Text = estados.Descripcion;

        }

        public void LimpiarCampos()
        {
            this.DescripcionTextBox.Text = "";
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Estados estados = new Estados();
            if(estados.Eliminar(Convert.ToInt32(IdEstadoTextBox.Text.Trim())))
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Se elimino el estado..";
                LimpiarCampos();
            }

         
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}