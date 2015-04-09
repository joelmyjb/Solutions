using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalAII.Registros
{
    public partial class RegistroCompras : System.Web.UI.Page
    {

        Articulos articulos = new Articulos();
        Usuarios usuarios = new Usuarios();
        Suplidor suplidor = new Suplidor();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ArticuloDropDownList.DataSource = articulos.Lista("IdArticulo,Descripcion", "1=1");
            this.ArticuloDropDownList.DataValueField = "IdArticulo";
            this.ArticuloDropDownList.DataTextField = "Descripcion";
            this.ArticuloDropDownList.DataBind();

            this.UsuarioDropDownList.DataSource = usuarios.Lista("IdUsuario, Nombre", "1=1");
            this.UsuarioDropDownList.DataValueField = "IdUsuario";
            this.UsuarioDropDownList.DataTextField = "Nombre";
            this.UsuarioDropDownList.DataBind();

            this.SuplidorDropDownList.DataSource = suplidor.Lista("IdSuplidor, Nombres", "1=1");
            this.SuplidorDropDownList.DataValueField = "IdSuplidor";
            this.SuplidorDropDownList.DataTextField = "Nombres";
            this.SuplidorDropDownList.DataBind();

           
        }

        private void CalcularTotal()
        {
            if (Session["datos"] != null)
            {
                DataTable datos = Session["datos"] as DataTable;
                double total = 0;

                foreach (DataRow row in datos.Rows)
                {
                    total += Convert.ToDouble(row["Total"]);
                }

                TotalTextBox.Text = total.ToString();
            }
        }

        public Compras comp = new Compras();
        public void LLenarClase(ComprasDetalle comprasDetalle)
        {
            Compras comp = new Compras();
            // comprasDetalle.IdCompra = Convert.ToInt32(IdCompraTextBox.Text);
            comprasDetalle.IdArticulo = Convert.ToInt32(ArticuloDropDownList.Text);
            comprasDetalle.Cantidad = Convert.ToInt32(CantidadTextBox.Text.ToString());
            comp.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            comprasDetalle.Costo = Convert.ToInt32(CostoTextBox.Text.ToString());
            comp.Monto = comprasDetalle.Cantidad * comprasDetalle.Costo;

        }

        private void LlenarCampos(ComprasDetalle comprasDetalle, Compras comp)
        {

            ArticuloDropDownList.Text = comprasDetalle.IdArticulo.ToString();
            IdCompraTextBox.Text = comprasDetalle.IdCompra.ToString();
            UsuarioDropDownList.Text = comp.IdUsuario.ToString();

            SuplidorDropDownList.Text = comp.IdSuplidor.ToString();
        }

        
        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            ComprasDetalle comprasDetalle = new ComprasDetalle();
            this.LLenarClase(comprasDetalle);
            comprasDetalle.Insertar();


            if (comprasDetalle.Insertar())
            {
                MensajeLabel.ForeColor = System.Drawing.Color.Green;
                MensajeLabel.Text = "Compra guardada con exito.";
                

            }
        }



        //protected void AgregarButton_Click(object sender, EventArgs e)
        //{

        //}

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void AgregarButton_Click1(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();

            if (Session["datos"] == null)
            {
                datos = new DataTable();
                datos.Columns.Add(new DataColumn("IdArticulo"));
                datos.Columns.Add(new DataColumn("Descripcion"));
                datos.Columns.Add(new DataColumn("Cantidad"));
                datos.Columns.Add(new DataColumn("Costo"));
                datos.Columns.Add(new DataColumn("Total"));
                CalcularTotal();
            }

            else
            {
                datos = Session["datos"] as DataTable;
            }

            DataRow row = datos.NewRow();
            row["IdArticulo"] = Request.QueryString["add"];
            row["Descripcion"] = articulos.Descripcion;
            row["Cantidad"] = CantidadTextBox.Text;
            row["Costo"] = CostoTextBox.Text;
            row["Total"] = (int.Parse(CantidadTextBox.Text) * int.Parse(CostoTextBox.Text));
            datos.Rows.Add(row);

            Session["datos"] = datos;
            GridView.DataSource = datos;
            GridView.DataBind();

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Compras compra = new Compras();
            compra.Eliminar(Convert.ToInt32(IdCompraTextBox.Text.Trim()));

        }

        protected void GenerarButton_Click(object sender, EventArgs e)
        {
            int IdCompra;
            int.TryParse(IdCompraTextBox.Text, out IdCompra);

            comp.IdUsuario = Convert.ToInt32(UsuarioDropDownList.Text);

            comp.IdSuplidor = Convert.ToInt32(SuplidorDropDownList.Text);
            comp.Monto = 0;


            if (comp.Insertar())
            {


            }
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();

            if (Session["datos"] == null)
            {
                datos = new DataTable();
                datos.Columns.Add(new DataColumn("IdArticulo"));
                datos.Columns.Add(new DataColumn("Descripcion"));
                datos.Columns.Add(new DataColumn("Cantidad"));
                datos.Columns.Add(new DataColumn("Costo"));
                datos.Columns.Add(new DataColumn("Total"));

            }

            else
            {
                datos = Session["datos"] as DataTable;
            }

            Articulos articulos = new Articulos();
            DataRow row = datos.NewRow();
            row["IdArticulo"] = ArticuloDropDownList.Text;
            row["Descripcion"] = articulos.Descripcion;
            row["Cantidad"] = CantidadTextBox.Text;
            row["Costo"] = CostoTextBox.Text;
            row["Total"] = (int.Parse(CantidadTextBox.Text) * int.Parse(CostoTextBox.Text));
            datos.Rows.Add(row);

            Session["datos"] = datos;
            GridView.DataSource = datos;
            GridView.DataBind();
            CalcularTotal();
        }


    }
}