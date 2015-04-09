using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Compras
    {

        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public int IdSuplidor { get; set; }
        public double Monto { get; set; }

        public Compras(int IdUsuario, int IdSuplidor, DateTime Fecha, float Monto)
        {
            this.IdUsuario = IdUsuario;
            this.IdSuplidor = IdSuplidor;
            this.Monto = Monto;

        }

        public Compras()
        {
            this.Fecha = DateTime.Now;
            this.IdUsuario = 0;
            this.IdSuplidor = 0;
            this.Monto = 0;

        }

        

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert into Compras(Fecha, IdUsuario, IdSuplidor, Monto) Values ('" + this.Fecha.ToString("MM/dd/yyyy") + "', '" + this.IdUsuario + "', '" + this.IdSuplidor + "', '" + this.Monto + "')");

        }

       

        public bool ModificarTotal(double Total, int Id)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("update Compras  set Monto = Monto + ' " + Monto + "' where IdCompra ='" + Id.ToString() + "'");
        }


        public bool Eliminar(int IdCompra)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from Compras where IdCompra = " + IdCompra.ToString());
        }

        public bool Buscar(int IdCompra)
        {
            Conexion conexiondb = new Conexion();
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *From Compras where IdCompra =" + IdCompra);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;


                this.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                this.IdSuplidor = (int)dt.Rows[0]["IdSuplidor"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.Monto = (double)dt.Rows[0]["Monto"];

            }
            return mensaje;

        }

      
      

        public  DataTable Lista(String Campos, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Compras where " + Filtro);

        }


    }
}
