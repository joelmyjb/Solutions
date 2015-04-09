using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class PagoTecnico
    {

         public int IdPagoTecnico { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTecnico { get; set; }
        public int IdUsuario {get;set;}
        public DateTime FechaCorte { get; set; }
        public double Monto { get; set; }
       

        public PagoTecnico(DateTime Fecha,  int IdTecnico, int IdUsuario, DateTime FechaCorte, double Monto)
        {
            this.IdTecnico = IdTecnico;
            this.IdUsuario = IdUsuario;
            this.FechaCorte = FechaCorte;
            this.Monto = Monto;
                  
        }

        public PagoTecnico()
        {
            this.Fecha = DateTime.Now;
            this.IdTecnico = 0;
            this.IdUsuario = 0;
            this.FechaCorte = DateTime.Now;
            this.Monto = 0;
            
        }

        public bool Insertar()
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into PagoTecnico(Fecha, IdTecnico, IdUsuario, FechaCorte, Monto)Values('" + this.Fecha.ToString("MM/dd/yyyy HH:mm:ss") +
                "','" + this.IdTecnico + "','" + this.IdUsuario + "','" + this.FechaCorte.ToString("MM/dd/yyyy HH:mm:ss") + "', '" + this.Monto + "')");
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update PagoTecnico set Fecha = '" + Fecha + "', IdTecnico = '" + IdTecnico +"', IdUsuario = '" + IdUsuario + "', FechaCorte = '" + FechaCorte + "', Monto = '" + Monto + "' where IdPagoTecnico = " + IdPagoTecnico);
        }

        public bool Eliminar(int IdPagoTecnico)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from PagoTecnico where IdPagoTecnico = " + IdPagoTecnico.ToString());
        }

        public bool Buscar()
        {
            Conexion conexiondb = new Conexion();
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *From PagoTecnico where IdPagoTecnico =" + IdPagoTecnico);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.IdTecnico = (int)dt.Rows[0]["IdTecnico"];
                this.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                this.FechaCorte = (DateTime)dt.Rows[0]["FechaCorte"];
                this.Monto = (double)dt.Rows[0]["Monto"];
               

            }
            return mensaje;
        }

        public  DataTable Lista(String Campos, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from PagoTecnico where " + Filtro);

        }
    }
}
