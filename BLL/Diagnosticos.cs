using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Diagnosticos
    {
        public int IdDiagnostico { get; set; }
        public string Descripcion { get; set; }

        public Diagnosticos(int IdDiagnostico, string Descripcion)
        {
            this.IdDiagnostico = IdDiagnostico;
            this.Descripcion = Descripcion;
        }

        public Diagnosticos()
        {
            this.IdDiagnostico = 0;
            this.Descripcion = "";

        }

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into Diagnosticos( Descripcion) Values('"  + this.Descripcion+ "')");
   
        }

        public bool Eliminar(int IdDiagnostico)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from Diagnosticos where IdDiagnostico = " + IdDiagnostico.ToString());

        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update Diagnosticos set Descripcion = '" + Descripcion + "' where IdDiagnostico = " + IdDiagnostico);
        }

        public bool Buscar()
        {
            Conexion conexiondb = new Conexion();
            bool retorno = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *from Diagnosticos where IdDiagnostico = " + IdDiagnostico);

            if (dt.Rows.Count > 0)
            {
                retorno = true;
                IdDiagnostico = (int)dt.Rows[0]["IdDiagnostico"];
                Descripcion = (string)dt.Rows[0]["Descripcion"];
               
            }

            return retorno;

        }

        public  DataTable Lista(String Campos, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Diagnosticos where " + Filtro);

        }


    }
}
