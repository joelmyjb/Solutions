using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroClientes : System.Web.UI.Page
    {
        Clientes cliente = new Clientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["IdCliente"] != null)
                {
                    EliminarButton.Visible = true;
                    cliente.IdCliente = int.Parse(Request.QueryString["IdCliente"]);
                    if (cliente.Buscar())
                    {
                        NombresTextBox.Text = cliente.Nombres;
                        DireccionTextBox.Text = cliente.Direccion;      
                        CelularTextBox.Text = cliente.Celular;
                        EmailTextBox.Text = cliente.Email;
                        TelefonoTextBox.Text = cliente.Telefono;
                        

                    }

                }

            }

        }

        public void LLenarClase(Clientes clientes)
        {
            
            clientes.Nombres = NombresTextBox.Text;
            clientes.Telefono = TelefonoTextBox.Text;
            clientes.Celular = CelularTextBox.Text;
            clientes.Direccion = DireccionTextBox.Text;
            clientes.Email = EmailTextBox.Text;
        }

        private void LlenarCampos(Clientes clientes)
        {

            IdClienteTextBox.Text = clientes.IdCliente.ToString();
            NombresTextBox.Text = clientes.Nombres;
            TelefonoTextBox.Text = clientes.Telefono;
            CelularTextBox.Text = clientes.Celular;
            DireccionTextBox.Text = clientes.Direccion;
            EmailTextBox.Text = clientes.Email;

        }

        public void LimpiarCampos()
        {
            this.IdClienteTextBox.Text = "";
            this.NombresTextBox.Text = "";
            this.TelefonoTextBox.Text = "";
            this.CelularTextBox.Text = "";
            this.DireccionTextBox.Text = "";
            this.EmailTextBox.Text = "";
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
           if( clientes.Eliminar(Convert.ToInt32(IdClienteTextBox.Text.Trim())))
           {
               MensajeLabel.ForeColor = System.Drawing.Color.Green;
               MensajeLabel.Text = "El cliente se elimino..";
               LimpiarCampos();
                  
           }
            
            LimpiarCampos();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.LLenarClase(clientes);
            

            if (Request.QueryString["IdCliente"] != null)
            {
                clientes.IdCliente = int.Parse(Request.QueryString["IdCliente"]);
                if (clientes.Modificar())
                {
                    Response.Write("Se ha modificado!!");
                    LimpiarCampos();
                }

            }
            else

                if (clientes.Insertar())
                {
                    MensajeLabel.ForeColor = System.Drawing.Color.Green;
                    MensajeLabel.Text = "Cliente guardado con exito.";
                    LimpiarCampos();
                  
                }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}