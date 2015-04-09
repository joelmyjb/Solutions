using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroPagoTecnico : System.Web.UI.Page
    {

        Tecnicos tecnicos = new Tecnicos();
        Usuarios usuarios = new Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.IdTecnicoDropDownList.DataSource = tecnicos.Lista("IdTecnicos, IdTecnicos", "1=1");
            this.IdTecnicoDropDownList.DataValueField = "IdTecnicos";
            this.IdTecnicoDropDownList.DataTextField = "IdTecnicos";
            this.IdTecnicoDropDownList.DataBind();

            this.IdUsuarioDropDownList.DataSource = usuarios.Lista("IdUsuario,Nombre", "1=1");
            this.IdUsuarioDropDownList.DataValueField = "IdUsuario";
            this.IdUsuarioDropDownList.DataTextField = "Nombre";
            this.IdUsuarioDropDownList.DataBind();
        }

        public void LLenarClase(PagoTecnico pagotecnico)
        {
            pagotecnico.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            pagotecnico.IdTecnico = Convert.ToInt32(IdTecnicoDropDownList.Text);
            pagotecnico.IdUsuario = Convert.ToInt32(IdUsuarioDropDownList.Text);
            pagotecnico.FechaCorte = Convert.ToDateTime(FechaCorteTextBox.Text);
            pagotecnico.Monto = Convert.ToInt32(MontoTextBox.Text.ToString());
        

        }

        private void LlenarCampos(PagoTecnico pagotecnico)
        {
            IdPagoTecnicoTextBox.Text = pagotecnico.IdPagoTecnico.ToString();
            FechaTextBox.Text = pagotecnico.Fecha.ToString("yyyy/MM/dd");
            IdTecnicoDropDownList.Text = pagotecnico.IdTecnico.ToString();
            IdUsuarioDropDownList.Text = pagotecnico.IdUsuario.ToString();
            MontoTextBox.Text = pagotecnico.Monto.ToString();
            FechaTextBox.Text = pagotecnico.Fecha.ToString("yyyy/MM/dd");

        }

        public void LimpiarCampos()
        {
            this.FechaTextBox.Text = "";
            this.FechaCorteTextBox.Text = "";
            this.MontoTextBox.Text = "";

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            PagoTecnico pagotecnico = new PagoTecnico();
            if(pagotecnico.Eliminar(Convert.ToInt32(IdPagoTecnicoTextBox.Text.Trim())))
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Se elimino el pago..";
                LimpiarCampos();
            }

            LimpiarCampos();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            PagoTecnico pagotecnico = new PagoTecnico();
            this.LLenarClase(pagotecnico);
            if(pagotecnico.Insertar())
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