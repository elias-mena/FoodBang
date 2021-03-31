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
        // DataTable a = new DataTable();
        //Conexión a base de datos Postgresql
        //Retorna el acceso a la Base de tados
        public static NpgsqlConnection Conexion()
        {
            NpgsqlConnection conecta = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = homero420; Database = FoodBang;");
            return conecta;

        }

        //Ejemplo select
        public static DataTable Consultar()
        {
            //string query = "select * from \"Comida\"";
            //string query = "select b.nombre,c.nombre from comida as b , categoria_comida as c where c.id = 1";
            NpgsqlConnection conn = Conexion();
            string query = "select distinct * from usuario where passw = '1234'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);


            IEnumerable<DataRow> dat = tabla.AsEnumerable();

            foreach (var row in dat)
            {
                if (row.ToString() == "tipo")
                {
                    MessageBox.Show("Nepe");
                }
            }

            return tabla;
        }

        public static DataTable ConsultarUsuario(String user)
        {

            NpgsqlConnection conn = Conexion();
            string query = "select  * from usuario where \"user\" = '"+user+"'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public static Boolean ConsultarClave(String user, String password)
        {

            NpgsqlConnection conn = Conexion();
            string query = "select distinct * from usuario where \"user\" = '" + user + "' and passw = '" + password + "';";

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
        //Ejemplo Insert
        public static void Insert()
        {
            String nombre = "Banano";
            int catego = 4;
            //este query no sirve porque ya inserté ese dato
            //string query = "INSERT INTO \"Comida\" (nombre, categoria) VALUES('"+ nombre +"'," + catego +");";
            //Se abre la conexion
            // conx.Open();
            //Se insertan los datos mediante un query
            //La sintaxis de in insert postgres es INSERT INTO tabla(valor1, valor2) VALUES(1, 2);
            //NpgsqlCommand cmd = new NpgsqlCommand(query,conx);
            //Se ejecuta el query
            // cmd.ExecuteNonQuery();
            MessageBox.Show("Insertado");
            //conx.Close();

        }
        public static void EliminarUser(string user)
        {
            NpgsqlConnection conx = Conexion();
            //este query no sirve porque ya inserté ese dato
            string query = "DELETE FROM \"usuario\" WHERE \"user\"  = '" + user + "'";
            // Se abre la conexion
            conx.Open();
           // Se insertan los datos mediante un query
           // La sintaxis de in insert postgres es INSERT INTO tabla(valor1, valor2) VALUES(1, 2);
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
           // Se ejecuta el query
             cmd.ExecuteNonQuery();
            MessageBox.Show("Insertado");
            conx.Close();

        }
    }
}
