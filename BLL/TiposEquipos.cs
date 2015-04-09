using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TiposEquipos
    {
        public int IdEquipo { get; set; }
        public string Descripcion { get; set; }

        public TiposEquipos()
        {
            this.Descripcion = "";
        }

        public TiposEquipos(int IdEquipo, string Descripcion)
        {
            this.Descripcion = Descripcion;
            this.IdEquipo = IdEquipo;
        }

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into TiposEquipos( Descripcion) Values('" + this.Descripcion + "')");
   
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update TiposEquipos set Descripcion = '" + Descripcion + "' where IdEquipo = " + IdEquipo);
        }

        public bool Eliminar(int IdEquipo)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from TiposEquipos where IdEquipo = " + IdEquipo.ToString());

        }

        public bool Buscar()
        {
            Conexion conexiondb = new Conexion();
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *from TiposEquipos where IdEquipo = " + IdEquipo);

            if (dt.Rows.Count > 0)
            {
                retorno = true;
                IdEquipo = (int)dt.Rows[0]["IdEquipo"];
                Descripcion = (string)dt.Rows[0]["Descripcion"];

            }

            return retorno;

        }

        public  DataTable Lista(String Campo, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campo + " from TiposEquipos where  " + Filtro);

        }
    }
}
