using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Estados
    {
         public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public Estados(int IdEstado, string Descripcion)
        {
            this.IdEstado = IdEstado;
            this.Descripcion = Descripcion;
        }

        public Estados()
        {
            this.IdEstado = 0;
            this.Descripcion = "";

        }

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into Estados( Descripcion) Values('" + this.Descripcion + "')");
   
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update Estados set Descripcion = '" + Descripcion + "' where IdEstado = " + IdEstado);
        }

        public bool Eliminar(int IdEstado)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from Estados where IdEstado = " + IdEstado.ToString());

        }


        public bool Buscar()
        {
            Conexion conexiondb = new Conexion();
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *from Estados where IdEstado = " + IdEstado);

            if (dt.Rows.Count > 0)
            {
                retorno = true;
                IdEstado = (int)dt.Rows[0]["IdEstado"];
                Descripcion = (string)dt.Rows[0]["Descripcion"];

            }

            return retorno;

        }

        public  DataTable Lista(String Campos, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Estados where " + Filtro);

        }


    }
}
