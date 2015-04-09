using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroArticulos : System.Web.UI.Page
    {
        Articulos articulos = new Articulos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Articulos articulos = new Articulos();
                    if (Request.QueryString["IdArticulo"] != null)
                    {
                        articulos.IdArticulo = int.Parse(Request.QueryString["IdArticulo"]);
                        if (articulos.Buscar())
                        {
                            DescripcionTextBox.Text = articulos.Descripcion;
                            TipoDropDown.Text = articulos.Tipo;
                            ExistenciaTextBox.Text = articulos.Existencia.ToString();
                            CostoTextBox.Text = articulos.Costo.ToString();
                            PrecioTextBox.Text = articulos.Precio.ToString();
                            this.LLenarClase(articulos);
                        }


                    }
                }
            }
        }

        public void LLenarClase(Articulos articulos)
        {

            articulos.Descripcion = DescripcionTextBox.Text;
            articulos.Tipo = TipoDropDown.Text;
            articulos.Existencia = Convert.ToInt32(ExistenciaTextBox.Text.ToString());
            articulos.Costo = Convert.ToInt32(CostoTextBox.Text.ToString());
            articulos.Precio = articulos.Existencia * articulos.Costo;

        }

        private void LlenarCampos(Articulos articulos)
        {

            IdArticuloTextBox.Text = articulos.IdArticulo.ToString();
            DescripcionTextBox.Text = articulos.Descripcion;
            TipoDropDown.Text = articulos.Tipo.ToString();
            ExistenciaTextBox.Text = articulos.Existencia.ToString();
            CostoTextBox.Text = articulos.Costo.ToString();
            //PrecioTextBox.Text = 

        }

       
        public void LimpiarCampos()
        {
            this.IdArticuloTextBox.Text = "";
            this.DescripcionTextBox.Text = "";
            this.TipoDropDown.Text = "";
            this.ExistenciaTextBox.Text = "";
            this.CostoTextBox.Text = "";
            this.PrecioTextBox.Text = "";

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();


            if (articulos.Eliminar(Convert.ToInt32(IdArticuloTextBox.Text.Trim())))
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "El articulo se elimino..";
                LimpiarCampos();
            }


        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            this.LLenarClase(articulos);

            if (Request.QueryString["IdArticulo"] != null)
            {
                articulos.IdArticulo = int.Parse(Request.QueryString["IdArticulo"]);
                articulos.Modificar();
                MensajeLabel.Text = "El registro se ha Modificado Correctamente";
            }
            
            else
                if (articulos.Insertar())
                {
                    MensajeLabel.ForeColor = System.Drawing.Color.Green;
                    MensajeLabel.Text = "Registro realizado con exito";
                    LimpiarCampos();
                }

            LimpiarCampos();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {

        }
    }
}