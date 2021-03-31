using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace FoodBang
{
    class Engine
    {

        public static bool AccesoAutorizado,
           Salir,
           Retiros,
           Reportes,
           Depositos,
           Consultas;
   
        //Retorna la conexión a la base de datos (se debe usar en todas las operaciones)
        public static NpgsqlConnection Conexion()
        {
            NpgsqlConnection conecta = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = homero420; Database = FoodBang;");
            return conecta;

        }

        public static DataTable ConsultarUsuario(String user)
        {

            NpgsqlConnection conn = Conexion();
            string query = "select  * from usuario where usuario = '" + user+"'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public static Boolean ConsultarClave(String user, String password)
        {

            NpgsqlConnection conn = Conexion();
            string query = "select distinct * from usuario where usuario = '" + user + "' and passw = '" + password + "';";

            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return true;

            //if (tabla.Rows.Count > 1)
            //{
            //    MessageBox.Show("Hola");
            //}

        }

        public static void EliminarUser(string user)
        {
            NpgsqlConnection conx = Conexion();
            string query = "DELETE FROM \"usuario\" WHERE usuario  = '" + user + "'";
            // Se abre la conexion
            conx.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
             cmd.ExecuteNonQuery();
            MessageBox.Show("Usuario Eliminado");
            conx.Close();

        }

        public static void insertarUser(string nombre, string edad, string tipo, string user, string passw)
        {
            NpgsqlConnection conx = Conexion();
            // La sintaxis de in insert postgres es INSERT INTO tabla(valor1, valor2) VALUES(1, 2);
            string query = "INSERT INTO \"usuario\" (nombre, edad, tipo, usuario, passw) VALUES ('" + nombre + "', " + edad + ", '" + tipo + "', '" + user + "', '" + passw + "');"; 
            // Se abre la conexion
            conx.Open();
            // Se insertan los datos mediante el query            
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
            // Se ejecuta el query
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertado");
            conx.Close();

        }
    }
}
