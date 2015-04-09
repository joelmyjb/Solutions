using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroEntregas : System.Web.UI.Page
    {
        Usuarios usuarios = new Usuarios();
        Recepciones recepciones = new Recepciones();
        Entregas entregas = new Entregas();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    if (Request.QueryString["IdEntrega"] != null)
            //    {
            //        EliminarButton.Visible = true;
            //        entregas.IdEntrega = int.Parse(Request.QueryString["IdEntrega"]);
            //        if (entregas.Buscar())
            //        {
            //            //FechaTextBox.Text = entregas.Fecha;
            //            IdRecepcionDropDownList.Text = entregas.IdRecepcion.ToString();
            //            IdUsuarioDropDownList.Text = entregas.IdUsuario.ToString();
            //            ObservacionesTextBox.Text = entregas.Observaciones;
            //            MontoTextBox.Text = entregas.Monto.ToString();
            //            DescuentoTextBox.Text = entregas.Descuento.ToString();


            //        }

            //    }
            //}

            this.IdUsuarioDropDownList.DataSource = usuarios.Lista("IdUsuario,Nombre", "1=1");
            this.IdUsuarioDropDownList.DataValueField = "IdUsuario";
            this.IdUsuarioDropDownList.DataTextField = "Nombre";
            this.IdUsuarioDropDownList.DataBind();

            this.IdRecepcionDropDownList.DataSource = recepciones.Lista("IdRecepciones,IdRecepciones", "1=1");
            this.IdRecepcionDropDownList.DataValueField = "IdRecepciones";
            this.IdRecepcionDropDownList.DataTextField = "IdRecepciones";
            this.IdRecepcionDropDownList.DataBind();

           
        }

        public void LLenarClase(Entregas entregas)
        {
            entregas.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            entregas.IdRecepcion = Convert.ToInt32(IdRecepcionDropDownList.Text);
            entregas.Observaciones = ObservacionesTextBox.Text;
            entregas.IdUsuario = Convert.ToInt32(IdUsuarioDropDownList.Text);
            entregas.Monto = Convert.ToInt32(MontoTextBox.Text.ToString());
            entregas.Descuento = Convert.ToInt32(DescuentoTextBox.Text.ToString());


        }

        private void LlenarCampos(Entregas entregas)
        {
            IdEntregaTextBox.Text = entregas.IdEntrega.ToString();
            FechaTextBox.Text = entregas.Fecha.ToString("yyyy/MM/dd");
            IdRecepcionDropDownList.Text = entregas.IdRecepcion.ToString();
            IdUsuarioDropDownList.Text = entregas.IdUsuario.ToString();
            ObservacionesTextBox.Text = entregas.Observaciones;
            MontoTextBox.Text = entregas.Monto.ToString();
            DescuentoTextBox.Text = entregas.Descuento.ToString();

        }

        public void LimpiarCampos()
        {
            this.FechaTextBox.Text = "";
            this.ObservacionesTextBox.Text = "";
            this.MontoTextBox.Text = "";
            this.DescuentoTextBox.Text = "";

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Entregas entregas = new Entregas();
         
            if (entregas.Eliminar(Convert.ToInt32(IdEntregaTextBox.Text.Trim())))
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Se elimino la entrega.";
                LimpiarCampos();
            }
            
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Entregas entregas = new Entregas();
            this.LLenarClase(entregas);

            if (Request.QueryString["IdEntrega"] != null)
            {
                entregas.IdEntrega = int.Parse(Request.QueryString["IdEntrega"]);
                if (entregas.Modificar())
                {
                    Response.Write("Se ha modificado!!");
                    LimpiarCampos();
                }

            }
            else

            if( entregas.Insertar())
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Entrega realizada con exito..";
                LimpiarCampos();
            }

           
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}