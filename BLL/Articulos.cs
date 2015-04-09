using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Articulos
    {
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int Existencia { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }

        public Articulos(string Descripcion, string Tipo, int Existencia, double Costo, double Precio)
        {
            this.Descripcion = Descripcion;
            this.Tipo = Tipo;
            this.Existencia = Existencia;
            this.Precio = Precio;
            this.Costo = Costo;

        }

        public Articulos()
        {
            this.Descripcion = "";
            this.Tipo ="";
            this.Existencia = 0;
            this.Costo = 0;
            this.Precio = 0;

        }

        public bool Insertar()
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into Articulos(Descripcion,Tipo, Existencia, Costo, Precio)Values('" + this.Descripcion +
                "','" + this.Tipo + "','" + this.Existencia + "','" + this.Costo + "', '" + this.Precio + "')");
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update Articulos set Descripcion = '" + Descripcion + "', Tipo ='" + Tipo + "', Existencia ='" + Existencia + "', Costo ='" + Costo + "' , Precio ='" + Precio + "' where IdArticulo= " + IdArticulo);
        }

        public bool Eliminar(int IdArticulo)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete from Articulos where IdArticulo = " + IdArticulo.ToString());
        }

        public bool Buscar()
        {
            Conexion conexiondb = new Conexion();
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *From Articulos where IdArticulo =" + IdArticulo);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                this.Descripcion = (string)dt.Rows[0]["Descripcion"];
                this.Tipo = (string)dt.Rows[0]["Tipo"];
                this.Existencia = (int)dt.Rows[0]["Existencia"];
                this.Costo = (double)dt.Rows[0]["Costo"];
                this.Precio = (double)dt.Rows[0]["Precio"];

            }
            return mensaje;

        }

        public  DataTable Lista(String Campos, String Filtro)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Articulos  where  " + Filtro);
        }
    }
}
