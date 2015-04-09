using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Usuarios
    {

        public int IdUsuario { set; get; }
        public string Nombre { set; get; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }

         public Usuarios(int IdUsuario, string Nombre, string Clave, string ConfirmarClave)
        {
            this.IdUsuario = IdUsuario;
            this.Nombre = Nombre;
            this.Clave = Clave;
            this.ConfirmarClave = ConfirmarClave;

        }

        public Usuarios()
        {
            IdUsuario = 0;
            Nombre = "";
            Clave = "";
            ConfirmarClave = "";
        }

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            bool accion = false;
            accion = conexiondb.EjecutarDB("Insert into Usuarios( Nombre, Clave, ConfirmarClave)values('"+ this.Nombre + "','" + this.Clave +"', '" + this.ConfirmarClave + "')");
            return accion;
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update Usuarios set Nombre= '" + Nombre + "', Clave= '" + Clave + "', ConfirmarClave= '" + ConfirmarClave + "' where IdUsuario = " + IdUsuario);
        }

        public bool Eliminar(int IdUsuario)
        {
            Conexion conexiondb = new Conexion();
            bool accion = false;
            accion = conexiondb.EjecutarDB("Delete from Usuarios where IdUsuario = " + IdUsuario.ToString());
            return accion;
        }

        public bool Buscar()
        {
            bool Retorno = false;
            DataTable Datos = new DataTable();
            Conexion conexiondb = new Conexion();
            Datos = conexiondb.BuscarDb("Select * from Usuarios Where IdUsuario = " + IdUsuario);
            if (Datos.Rows.Count > 0)
            {
                Retorno = true;
                this.IdUsuario = (int)Datos.Rows[0]["IdUsuario"];
                this.Nombre = (string)Datos.Rows[0]["Nombre"];
                this.Clave = (string)Datos.Rows[0]["Clave"];
                this.ConfirmarClave = (string)Datos.Rows[0]["ConfirmarClave"];
             
            }
          
            return Retorno;
        }

        public Boolean Autenticar(string Nombre, string Clave)
        {
            Conexion conexiondb = new Conexion();
            Boolean retorno = false;
            object IdUsuario = conexiondb.ObtenerValorDb("select IdUsuario from Usuarios Where Nombre = '" + Nombre + "' And Clave = '" + Clave + "'");

            if (IdUsuario != null)
            {
                retorno = this.Buscar();
            }

            return retorno;
        }

        public bool BuscarId(string Nombre)
        {
            Conexion conexiondb = new Conexion();
            Boolean paso = false;
            DataTable Datos = new DataTable();
            Datos = conexiondb.BuscarDb("Select * from Usuarios where Nombre = '" + Nombre + "'");

            if (Datos.Rows.Count > 0)
            {
                this.IdUsuario = (int)Datos.Rows[0]["IdUsuario"];
                paso = true;
            }

            return paso;
        }

        public  DataTable Lista(String Campos, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Usuarios where " + Filtro);

        }
    }
}
