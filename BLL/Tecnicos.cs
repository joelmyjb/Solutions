using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Tecnicos
    {
        public int IdTecnicos { set; get; }
        public string Nombres { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public string Email { set; get; }
        public double PctComision { set; get; }

        Conexion conexiondb = new Conexion();
        DataTable dt = new DataTable();

        public Tecnicos(int IdTecnicos, string Nombres, string Direccion, string Telefono, string Email, double PctComision)
        {
            
            this.Nombres = Nombres;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Email = Email;
            this.PctComision = PctComision;
        }

        public Tecnicos()
        {
            
            this.Nombres = "";
            this.Direccion = "";
            this.Telefono = "";
            this.Email = "";
            this.PctComision = 0;
        }

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into Tecnicos(Nombres,Direccion, Telefono, Email, PctComision)Values('" + this.Nombres +
                "','" + this.Direccion + "','" + this.Telefono + "','" + this.Email + "','" + this.PctComision + "')");

        }

        public bool Eliminar(int IdTecnicos)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete From Tecnicos Where IdTecnicos = " + IdTecnicos);
        }


        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update Tecnicos set Nombres = '" + Nombres + "', Direccion ='" + Direccion + "', Telefono ='" + Telefono + "', Email ='" + Email + "' , PctComision ='" + PctComision+ "' where IdTecnicos= " + IdTecnicos);
        }

        public bool Buscar()
        {
            bool retorno = false;
            dt = conexiondb.BuscarDb("Select * from Tecnicos where IdTecnicos =" + IdTecnicos);
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                Nombres = (string)dt.Rows[0]["Nombres"];
                Direccion = (string)dt.Rows[0]["Direccion"];
                Telefono = (string)dt.Rows[0]["Telefono"];
                Email = (string)dt.Rows[0]["Email"];
                PctComision = (double)dt.Rows[0]["PctComision"];
            }
            return retorno;
        }

        public DataTable Lista(string Campos, string Filtro)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Tecnicos where " + Filtro);
        }

    }
}
