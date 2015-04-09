using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TrabajoRecepciones
    {
        public int IdTrabajoRecepciones { set; get; }
        public int IdRecepcion { set; get; }
        public int IdArticulo { set; get; }
        public int IdTecnico { set; get; }
        public int IdUsuario { set; get; }
        public double Precio { set; get; }
        public double Costo { set; get; }
        public bool esPago { set; get; }

        Conexion conexiondb = new Conexion();
        DataTable dt = new DataTable();

        public TrabajoRecepciones(int IdTrabajoRecepciones, int IdRecepcion, int IdArticulo, int IdTecnico, int IdUsuario, double Precio, double Costo, bool esPago)
        {

            this.Precio = Precio;
            this.Costo = Costo;

        }

        public TrabajoRecepciones()
        {
            this.IdTrabajoRecepciones = 0;
            this.IdRecepcion = 0;
            this.IdArticulo = 0;
            this.IdTecnico = 0;
            this.IdUsuario = 0;
            this.Costo = 0;
            this.Precio = 0;

        }

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into TrabajoRecepciones(IdRecepcion, IdArticulo, IdTecnico, IdUsuario, Precio, Costo, esPago)Values('" + this.IdRecepcion +
                "','" + this.IdArticulo + "','" + this.IdTecnico + "','" + this.IdUsuario + "', '" + this.Precio + "','" + this.Costo + "', '" + this.esPago + "')");

        }
        public bool Eliminar(int IdTrabajoRecepciones)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from TrabajoRecepciones where IdTrabajoRececpciones =" + IdTrabajoRecepciones);
        }
        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update TrabajoRecepciones set IdRecepcion= '" + IdRecepcion + "', IdArticulo= '" + IdArticulo + "', IdTecnico= '" + IdTecnico + "', IdUsuario= '" + IdUsuario + "', Precio= '" + Precio + "', Costo= '" + Costo + "' where IdTrabajoRecepciones = " + IdTrabajoRecepciones);
        }
        public bool Buscar()
        {
            bool retorno = false;
            dt = conexiondb.BuscarDb("Select * from TrabajoRecepciones where IdTrabajoRecepciones = " + IdTrabajoRecepciones);
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                IdRecepcion = (int)dt.Rows[0]["IdRecepcion"];
                IdArticulo = (int)dt.Rows[0]["IdArticulo"];
                IdTecnico = (int)dt.Rows[0]["IdTecnico"];
                IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                Precio = (double)dt.Rows[0]["Precio"];
                Costo = (double)dt.Rows[0]["Costo"];
                esPago = (bool)dt.Rows[0]["esPago"];
            }
            return retorno;
        }
        public DataTable Lista(string Campos, string Filtro)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from TrabajoRecepciones where  " + Filtro);
        }
    }
}
