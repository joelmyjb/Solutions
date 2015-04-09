using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Entregas
    {
        public int IdEntrega { get; set; }
        public DateTime Fecha { get; set; }
        public int IdRecepcion { get; set; }
        public int IdUsuario {get;set;}
        public string Observaciones { get; set; }
        public double Monto { get; set; }
        public double Descuento { get; set; }

        public Entregas(DateTime Fecha,  int IdRecepcion, int IdUsuario, string Observaciones, double Monto, double Descuento)
        {
            this.IdRecepcion = IdRecepcion;
            this.IdUsuario = IdUsuario;
            this.Observaciones = Observaciones;
            this.Monto = Monto;
            this.Descuento = Descuento;
           

        }

        public Entregas()
        {
            this.Fecha = DateTime.Now;
            this.IdRecepcion = 0;
            this.IdUsuario = 0;
            this.Monto = 0;
            this.Descuento = 0;

        }

        public bool Insertar()
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into Entregas(Fecha, IdRecepcion, IdUsuario, Observaciones, Monto, Descuento)Values('" + this.Fecha.ToString("MM/dd/yyyy HH:mm:ss")  +
                "','" + this.IdRecepcion + "','" + this.IdUsuario + "','" + this.Observaciones+ "', '" + this.Monto + "', '" + this.Descuento + "')");
        }

        public bool Eliminar(int IdEntrega)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from Entregas where IdEntrega = " + IdEntrega.ToString());
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update from Entregas set Fecha = '" + Fecha + "', IdRecepcion ='" + IdRecepcion + "', IdUsuario ='" + IdUsuario + "', Monto = '" + Monto + "', Descuento = '" + Descuento + "' where Entregas = " + IdEntrega);
        }

        public bool Buscar()
        {
            Conexion conexiondb = new Conexion();
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *From Entregas where IdEntrega =" + IdEntrega);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.IdRecepcion = (int)dt.Rows[0]["IdRecepcion"];
                this.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                this.Observaciones = (string)dt.Rows[0]["Observaciones"];
                this.Monto = (double)dt.Rows[0]["Monto"];
                this.Descuento = (double)dt.Rows[0]["Descuento"];

            }
            return mensaje;
        }

        public DataTable Lista(String Campos, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Entregas where" + Filtro);

        }
    }
}
