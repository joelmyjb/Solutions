using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Recepciones
    {
        public int IdRecepciones { set; get; }
        public DateTime Fecha { set; get; }
        public int IdCliente { set; get; }
        public int IdEquipo { set; get; }
        public int IdDiagnostico { set; get; }
        public int IdEstado { set; get; }
        public int IdUsuario { set; get; }
        public string Serial { set; get; }
        public string Observaciones { set; get; }

        Conexion conexiondb = new Conexion();
        DataTable dt = new DataTable();

        public Recepciones(int IdRecepciones, DateTime Fecha, int IdCliente, int IdEquipo, int IdDiagnostico, int IdEstado, int IdUsuario, string Serial, string Observaciones)
        {
            this.IdRecepciones = IdRecepciones;
            this.IdCliente = IdCliente;
            this.IdEstado = IdEstado;
            this.IdEquipo = IdEquipo;
            this.IdDiagnostico = IdDiagnostico;
            this.IdUsuario = IdUsuario;
            this.Serial = Serial;
            this.Observaciones = Observaciones;
        }

        public Recepciones()
        {
            this.IdRecepciones = 0;
            this.Fecha = DateTime.Now;
            this.IdCliente = 0;
            this.IdEquipo = 0;
            this.IdDiagnostico = 0;
            this.IdEstado = 0;
            this.IdUsuario = 0;
            this.Serial = "";
            this.Observaciones = "";
        }

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert into Recepciones (Fecha, IdCliente, IdEquipo, IdDiagnostico, IdEstado, IdUsuario, Serial, Observaciones) Values ('" + Fecha.ToString("MM/dd/yyyy") + "', '" + IdCliente + "', '" + IdEquipo + "', '" + IdDiagnostico + "', '" + IdEstado + "', '" + IdUsuario + "', '" + Serial + "', '" + Observaciones + "')");

        }

        public bool Eliminar(int IdRecepciones)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete From Recepciones Where IdRecepciones = " + IdRecepciones);
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update Recepciones set IdCliente ='" + IdCliente + "', IdEquipo ='" + IdEquipo + "', IdDiagnostico ='" + IdDiagnostico + "', IdEstado ='" + IdEstado + "', IdUsuario ='" + IdUsuario + "', Serial ='" + Serial + "', Observaciones ='" + Observaciones + " where IdRecepciones =" + IdRecepciones);
        }

        public bool Buscar()
        {
            bool retorno = false;
            dt = conexiondb.BuscarDb("Select * from Recepciones where IdRecepciones =" + IdRecepciones);
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                Fecha = (DateTime)dt.Rows[0]["Fecha"];
                IdCliente = (int)dt.Rows[0]["IdCliente"];
                IdEquipo = (int)dt.Rows[0]["IdEquipo"];
                IdDiagnostico = (int)dt.Rows[0]["IdDiagnostico"];
                IdEstado = (int)dt.Rows[0]["IdEstado"];
                IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                Serial = (string)dt.Rows[0]["Serial"];
                Observaciones = (string)dt.Rows[0]["Observaciones"];
            }
            return retorno;
        }

        public  DataTable Lista(string Campos, string Filtro)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Recepciones where " + Filtro);
        }

    }
}
