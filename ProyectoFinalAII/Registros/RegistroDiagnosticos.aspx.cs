using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroDiagnosticos : System.Web.UI.Page
    {
        Diagnosticos diagnosticos = new Diagnosticos();
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                if (Request.QueryString["IdDiagnostico"] != null)
                {
                    EliminarButton.Visible = true;
                    diagnosticos.IdDiagnostico = int.Parse(Request.QueryString["IdDiagnostico"]);
                    if (diagnosticos.Buscar())
                    {
                        DescripcionTextBox.Text = diagnosticos.Descripcion;
                   
                        

                    }

                }

        }
        }
            

        public void LLenarClase(Diagnosticos diagnosticos)
        {

            diagnosticos.Descripcion = DescripcionTextBox.Text;        

        }

        private void LlenarCampos(Diagnosticos diagnosticos)
        {

            IdDiagnosticoTextBox.Text = diagnosticos.IdDiagnostico.ToString();
            DescripcionTextBox.Text = diagnosticos.Descripcion;

        }

        public void LimpiarCampos()
        {
            this.DescripcionTextBox.Text = "";
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Diagnosticos diagnosticos = new Diagnosticos();
            if(diagnosticos.Eliminar(Convert.ToInt32(IdDiagnosticoTextBox.Text.Trim())))

            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
               MensajeLabel.Text = "Se elimino el diagnostico.";
               LimpiarCampos();
            }
            
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Diagnosticos diagnosticos = new Diagnosticos();
            this.LLenarClase(diagnosticos);

            if (Request.QueryString["IdDiagnostico"] != null)
            {
                diagnosticos.IdDiagnostico = int.Parse(Request.QueryString["IdDiagnostico"]);
                if (diagnosticos.Modificar())
                {
                    Response.Write("Se ha modificado!!");
                    LimpiarCampos();
                }

            }
            else 
            if (diagnosticos.Insertar())
            {

                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Diagnostico realizado con exito..";
                LimpiarCampos();
            }
        }
    }
}