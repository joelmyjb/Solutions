using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public Clientes(string Nombres, string Telefono, string Celular, string Direccion, string Email)
        {
            this.IdCliente = IdCliente;
            this.Nombres = Nombres;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.Direccion = Direccion;
            this.Email = Email;

        }

        public Clientes()
        {
            this.Nombres = "";
            this.Telefono = "";
            this.Celular = "";
            this.Direccion = "";
            this.Email = "";

        }

        public bool Insertar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Insert Into Clientes(Nombres,Telefono, Celular, Direccion, Email)Values('" + this.Nombres +
                "','" + this.Telefono + "','" + this.Celular + "','" + this.Direccion + "','" + this.Email + "')");
        }

        public bool Eliminar(int IdCliente)
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Delete From Clientes Where IdCliente = " + IdCliente);
        }

        public bool Modificar()
        {
            Conexion conexiondb = new Conexion();
            return conexiondb.EjecutarDB("Update Clientes set Nombres = '" + Nombres + "', Telefono ='" + Telefono + "', Celular ='" + Celular + "', Direccion ='" + Direccion + "' , Email ='" + Email + "' where IdCliente= " + IdCliente);
        }

        public bool Buscar()
        {
            Conexion conexiondb = new Conexion();
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *From Clientes where IdCliente =" + IdCliente);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.Nombres = (string)dt.Rows[0]["Nombres"];
                this.Telefono = (string)dt.Rows[0]["Telefono"];
                this.Celular = (string)dt.Rows[0]["Celular"];
                this.Direccion = (string)dt.Rows[0]["Direccion"];
                this.Email = (string)dt.Rows[0]["Email"];

            }
            return mensaje;
        }

        public  DataTable Lista(String Campos, String Filtro)
        {

            Conexion conexiondb = new Conexion();
            return conexiondb.BuscarDb("Select " + Campos + " from Clientes where " + Filtro);

        }

    }
}
