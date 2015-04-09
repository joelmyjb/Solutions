using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroTecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Tecnicos tecnicos = new Tecnicos();
            if (!IsPostBack)
            {
                if (Request.QueryString["IdTecnicos"] != null)
                {
                    EliminarButton.Visible = true;
                    tecnicos.IdTecnicos = int.Parse(Request.QueryString["IdTecnicos"]);
                    if (tecnicos.Buscar())
                    {
                        IdClienteTextBox.Text = tecnicos.IdTecnicos.ToString();
                        NombresTextBox.Text = tecnicos.Nombres;
                        DireccionTextBox.Text = tecnicos.Direccion;
                        PctComisionTextBox.Text = tecnicos.PctComision.ToString();
                        EmailTextBox.Text = tecnicos.Email;
                        TelefonoTextBox.Text = tecnicos.Telefono;


                    }

                }

            }
        }

        public void LLenarClase(Tecnicos tecnicos)
        {
            //estudiantes.IdRegistro = Convert.ToInt32(IdRegistroTextBox.Text.ToString());
            tecnicos.Nombres = NombresTextBox.Text;
            tecnicos.Telefono = TelefonoTextBox.Text;
            tecnicos.Direccion = DireccionTextBox.Text;
            tecnicos.Email = EmailTextBox.Text;
            tecnicos.PctComision = Convert.ToInt32(PctComisionTextBox.Text.ToString());
        }

        private void LlenarCampos(Tecnicos tecnicos)
        {

            IdClienteTextBox.Text = tecnicos.IdTecnicos.ToString();
            NombresTextBox.Text = tecnicos.Nombres;
            TelefonoTextBox.Text = tecnicos.Telefono;
            DireccionTextBox.Text = tecnicos.Direccion;
            EmailTextBox.Text = tecnicos.Email;
            PctComisionTextBox.Text = tecnicos.PctComision.ToString();

        }

        public void LimpiarCampos()
        {
            this.IdClienteTextBox.Text = "";
            this.NombresTextBox.Text = "";
            this.TelefonoTextBox.Text = "";
            this.DireccionTextBox.Text = "";
            this.EmailTextBox.Text = "";
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Tecnicos tecnicos = new Tecnicos();
            if (tecnicos.Eliminar(Convert.ToInt32(IdClienteTextBox.Text.Trim())))
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Se elimino el tecnico.";
                LimpiarCampos();
            }

            LimpiarCampos();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Tecnicos tecnicos = new Tecnicos();
            this.LLenarClase(tecnicos);

            if (Request.QueryString["IdTecnicos"] != null)
            {
                tecnicos.IdTecnicos = int.Parse(Request.QueryString["IdTecnicos"]);
                tecnicos.Modificar();
                MensajeLabel.Text = "El tecnico se ha Modificado Correctamente";
            }
            else
            if(tecnicos.Insertar())
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