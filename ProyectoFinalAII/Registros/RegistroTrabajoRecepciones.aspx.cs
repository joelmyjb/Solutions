using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroTrabajoRecepciones : System.Web.UI.Page
    {
        Usuarios usuarios = new Usuarios();
        Recepciones recepciones = new Recepciones();
        Articulos articulos = new Articulos();
        Tecnicos tecnicos = new Tecnicos();

        protected void Page_Load(object sender, EventArgs e)
        {

            this.IdRecepcionDropDownList.DataSource = recepciones.Lista("IdRecepciones,IdRecepciones", "1=1");
            this.IdRecepcionDropDownList.DataValueField = "IdRecepciones";
            this.IdRecepcionDropDownList.DataTextField = "IdRecepciones";
            this.IdRecepcionDropDownList.DataBind();

            this.IdArticuloDropDownList.DataSource = articulos.Lista("IdArticulo,Descripcion", "1=1");
            this.IdArticuloDropDownList.DataValueField = "IdArticulo";
            this.IdArticuloDropDownList.DataTextField = "Descripcion";
            this.IdArticuloDropDownList.DataBind();

            this.IdTecnicoDropDownList.DataSource = tecnicos.Lista("IdTecnicos,Nombres", "1=1");
            this.IdTecnicoDropDownList.DataValueField = "IdTecnicos";
            this.IdTecnicoDropDownList.DataTextField = "Nombres";
            this.IdTecnicoDropDownList.DataBind();

            this.UsuarioDropDownList.DataSource = usuarios.Lista("IdUsuario, Nombre", "1=1");
            this.UsuarioDropDownList.DataValueField = "IdUsuario";
            this.UsuarioDropDownList.DataTextField = "Nombre";
            this.UsuarioDropDownList.DataBind();

            
        }

        public void LLenarClase(TrabajoRecepciones tr)
        {

            tr.IdRecepcion = Convert.ToInt32(IdRecepcionDropDownList.Text);
            tr.IdArticulo = Convert.ToInt32(IdArticuloDropDownList.Text);
            tr.IdTecnico = Convert.ToInt32(IdTecnicoDropDownList.Text);
            tr.IdUsuario = Convert.ToInt32(UsuarioDropDownList.Text);
            tr.Precio = Convert.ToInt32(PrecioTextBox.Text.ToString());
            tr.Costo = Convert.ToInt32(CostoTextBox.Text.ToString());
           

        }

        private void LlenarCampos(TrabajoRecepciones tr)
        {
            IdRecepcionTextBox.Text = tr.IdRecepcion.ToString();
            IdArticuloDropDownList.Text = tr.IdArticulo.ToString();
            IdTecnicoDropDownList.Text = tr.IdTecnico.ToString();
            UsuarioDropDownList.Text = tr.IdUsuario.ToString();
            PrecioTextBox.Text = tr.Precio.ToString();
            CostoTextBox.Text = tr.Costo.ToString();
            esPago.Checked = tr.esPago;

        }

        public void LimpiarCampos()
        {
            this.IdArticuloDropDownList.Text = "";
            this.IdRecepcionDropDownList.Text = "";
            this.IdTecnicoDropDownList.Text = "";
            this.UsuarioDropDownList.Text = "";
            this.PrecioTextBox.Text = "";
            this.CostoTextBox.Text = "";
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            TrabajoRecepciones trabajorecepciones = new TrabajoRecepciones();
            if (trabajorecepciones.Eliminar(Convert.ToInt32(IdRecepcionTextBox.Text.Trim())))
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Se elimino el trabajo recepcion.";
                LimpiarCampos();
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            TrabajoRecepciones trabajorecepciones = new TrabajoRecepciones();
            this.LLenarClase(trabajorecepciones);
           if( trabajorecepciones.Insertar())
           {

               MensajeLabel.ForeColor = System.Drawing.Color.Green;
               MensajeLabel.Text = "Realizado con exito..";
               LimpiarCampos();

           }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}