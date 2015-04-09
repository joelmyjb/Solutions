using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroRecepciones : System.Web.UI.Page
    {
        Clientes clientes = new Clientes();
        TiposEquipos tiposEquipos = new TiposEquipos();
        Diagnosticos diagnosticos = new Diagnosticos();
        Estados estados = new Estados();
        Usuarios usuarios = new Usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {

            this.IdClienteDropDownList.DataSource = clientes.Lista("IdCliente, Nombres", "1=1");
            this.IdClienteDropDownList.DataValueField = "IdCliente";
            this.IdClienteDropDownList.DataTextField = "Nombres";
            this.IdClienteDropDownList.DataBind();

            this.IdEquipoDropDownList.DataSource = tiposEquipos.Lista("IdEquipo,IdEquipo", "1=1");
            this.IdEquipoDropDownList.DataValueField = "IdEquipo";
            this.IdEquipoDropDownList.DataTextField = "IdEquipo";
            this.IdEquipoDropDownList.DataBind();

            this.IdDiagnosticoDropDownList.DataSource = diagnosticos.Lista("IdDiagnostico,IdDiagnostico", "1=1");
            this.IdDiagnosticoDropDownList.DataValueField = "IdDiagnostico";
            this.IdDiagnosticoDropDownList.DataTextField = "IdDiagnostico";
            this.IdDiagnosticoDropDownList.DataBind();

            this.IdEstadoDropDownList.DataSource = estados.Lista("IdEstado,IdEstado", "1=1");
            this.IdEstadoDropDownList.DataValueField = "IdEstado";
            this.IdEstadoDropDownList.DataTextField = "IdEstado";
            this.IdEstadoDropDownList.DataBind();

            this.IdUsuarioDropDownList.DataSource = usuarios.Lista("IdUsuario,Nombre", "1=1");
            this.IdUsuarioDropDownList.DataValueField = "IdUsuario";
            this.IdUsuarioDropDownList.DataTextField = "Nombre";
            this.IdUsuarioDropDownList.DataBind();


        }

        public void LLenarClase(Recepciones recepciones)
        {
            recepciones.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            recepciones.IdCliente = Convert.ToInt32(IdClienteDropDownList.Text);
            recepciones.IdEquipo = Convert.ToInt32(IdEquipoDropDownList.Text);
            recepciones.IdDiagnostico = Convert.ToInt32(IdDiagnosticoDropDownList.Text);
            recepciones.IdEstado = Convert.ToInt32(IdEstadoDropDownList.Text);
            recepciones.Observaciones = ObservacionesTextBox.Text;
            recepciones.IdUsuario = Convert.ToInt32(IdUsuarioDropDownList.Text);
            recepciones.Serial = SerialTextBox.Text;
 

        }

        private void LlenarCampos(Recepciones recepciones)
        {
            IdRecepcionTextBox.Text = recepciones.IdRecepciones.ToString();
            FechaTextBox.Text = recepciones.Fecha.ToString("yyyy/MM/dd");
            IdClienteDropDownList.Text = recepciones.IdCliente.ToString();
            IdUsuarioDropDownList.Text = recepciones.IdUsuario.ToString();
            IdEquipoDropDownList.Text = recepciones.IdEquipo.ToString();
            IdDiagnosticoDropDownList.Text = recepciones.IdDiagnostico.ToString();
            IdEstadoDropDownList.Text = recepciones.IdEstado.ToString();
            ObservacionesTextBox.Text = recepciones.Observaciones;
            SerialTextBox.Text = recepciones.Serial;
          

        }

        public void LimpiarCampos()
        {
            this.FechaTextBox.Text = "";
            this.ObservacionesTextBox.Text = "";
            this.SerialTextBox.Text = "";
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Recepciones recepciones = new Recepciones();
           if( recepciones.Eliminar(Convert.ToInt32(IdRecepcionTextBox.Text.Trim())))
           {
               MensajeLabel.ForeColor = System.Drawing.Color.Green;
               MensajeLabel.Text = "Se elimino la recepcion.";
               LimpiarCampos();
           }

            LimpiarCampos();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Recepciones recepciones = new Recepciones();
            this.LLenarClase(recepciones);
            if(recepciones.Insertar())
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Realizado con exito..";
                LimpiarCampos();
            }

            LimpiarCampos();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}