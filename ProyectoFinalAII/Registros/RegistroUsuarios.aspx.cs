using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LLenarClase(Usuarios usuarios)
        {

            usuarios.Nombre = NombreTextBox.Text;
            usuarios.Clave = ClaveTextBox.Text;
            usuarios.ConfirmarClave = ConfirmarClaveTextBox.Text;

        }

        private void LlenarCampos(Usuarios usuarios)
        {

            IdUsuarioTextBox.Text = usuarios.IdUsuario.ToString();
            NombreTextBox.Text = usuarios.Nombre;
            ClaveTextBox.Text = usuarios.Clave;
            ConfirmarClaveTextBox.Text = usuarios.ConfirmarClave;

        }


        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            if (usuarios.Eliminar(Convert.ToInt32(IdUsuarioTextBox.Text.Trim())))
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "El usuario se elimino..";
                LimpiarCampos();
            }

            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            this.NombreTextBox.Text = "";
            this.ClaveTextBox.Text = "";
            this.ConfirmarClaveTextBox.Text = "";
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            this.LLenarClase(usuarios);
            if (usuarios.Insertar())
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

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios Buscar = new Usuarios();
            bool mensaje = false;
            int Numero;
            int.TryParse(IdUsuarioTextBox.Text, out Numero);
            mensaje = Buscar.Buscar(Numero);
            if (mensaje == true)
            {

                NombreTextBox.Text = Buscar.Nombre;
                ClaveTextBox.Text = Buscar.Clave.ToString();
                ConfirmarClaveTextBox.Text = Buscar.ConfirmarClave.ToString();
             
            }
        }
    }
}