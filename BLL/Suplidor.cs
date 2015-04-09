using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Suplidor
    {
        public int IdSuplidor { get; set; }
        public string Nombres { get; set; }

        public Suplidor(int IdSuplidor, string Nombres)
        {
            this.IdSuplidor = IdSuplidor;
            this.Nombres = Nombres;

        }

        public Suplidor()
        {
            IdSuplidor = 0;
            Nombres = "";
        }


        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into Suplidor(Nombres) Values('"  + this.Nombres + "')");
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update Suplidor set Nombres = '" + Nombres + "' where IdSuplidor= " + IdSuplidor);
        }
        public bool Eliminar(int IdSuplidor)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from Suplidor where IdSuplidor= " + IdSuplidor.ToString());
        }

        public bool Buscar()
        {
            bool mensaje = false;
            Conexion conexiondb = new Conexion();
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *From Suplidor where IdSuplidor =" + IdSuplidor);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                //this.IdSuplidor = (int)dt.Rows[0]["IdSuplidor"];
                this.Nombres = (string)dt.Rows[0]["Nombres"];

            }
            return mensaje;
        }

        public  DataTable Lista(String Campos, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Suplidor where " + Filtro);

        }
    }
}
