using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ComprasDetalle
    {

        public int IdCompraDetalle { get; set; }
        public int IdCompra { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public int IdArticulo { get; set; }
     
        
         public ComprasDetalle(int IdCompraDetalle, int IdCompra, int Cantidad,  int Costo, int IdArticulo)
        {
            this.IdCompraDetalle = IdCompraDetalle;
            this.IdCompra = IdCompra;
            this.Cantidad = Cantidad;
            this.Costo = Costo;
            this.IdArticulo = IdArticulo;
  
      
        }

         public ComprasDetalle()
         {
       
             this.IdCompra = 0;
             this.Cantidad = 0;
             this.Costo = 0;
             this.IdArticulo = 0;
         }


         public bool Insertar()
         {
             Conexion conexiondb = new Conexion();
             return conexiondb.EjecutarDB("Insert Into ComprasDetalle (IdCompra, IdArticulo, Cantidad, Costo) Values('" + this.IdCompra +
                 "','" + this.IdArticulo + "','" + this.Cantidad + "', '" + this.Costo + "')");
         }

         public bool Eliminar(int IdCompraDetalle)
         {
             Conexion conexiondb = new Conexion();
             return conexiondb.EjecutarDB("Delete from ComprasDetalle where IdCompraDetalle = " + IdCompraDetalle.ToString());
         }

         public bool Buscar(int IdCompraDetalle)
         {
             Conexion conexiondb = new Conexion();
             bool mensaje = false;
             DataTable dt = new DataTable();
             dt = conexiondb.BuscarDb("Select *From ComprasDetalle where IdCompraDetalle =" + IdCompraDetalle);
             if (dt.Rows.Count > 0)
             {
                 mensaje = true;

                 this.IdCompraDetalle = (int)dt.Rows[0]["IdCompraDetalle"];
                 this.IdCompra = (int)dt.Rows[0]["IdCompra"];
                 this.IdArticulo = (int)dt.Rows[0]["IdArticulo"];
                 this.Cantidad = (int)dt.Rows[0]["Cantidad"];
                 this.Costo = (double)dt.Rows[0]["Costo"];
                
             }
             return mensaje;

         }

         public  DataTable Lista(String Campo, String FiltroWhere)
         {

             Conexion conexiondb = new Conexion();
             return conexiondb.BuscarDb("Select " + Campo + " from ComprasDetalle where " + FiltroWhere);

         }

    }
}
