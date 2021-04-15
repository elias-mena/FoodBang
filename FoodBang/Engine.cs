using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using FoodBang.Forms;

namespace FoodBang
{
    class Engine
    {
        public static bool entrar = false;
   
        //Retorna la conexión a la base de datos (se debe usar en todas las operaciones)
        public static NpgsqlConnection Conexion()
        {
            NpgsqlConnection conecta = 
            new NpgsqlConnection("Server = localhost; User Id= postgres; Password = homero420; Database = FoodBang;");
            return conecta;

        }

        //Login
        public static bool Login(String user, String passw)
        {
            NpgsqlConnection conn = Conexion();
            string query = "SELECT COUNT(*) FROM usuario WHERE usuario = '" + user + "' AND passw = '" + passw + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            //Creo un datarow para poder manipular los datos
            DataRow row = tabla.Rows[0];
            //MessageBox.Show(row[0].ToString());

            if (row[0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Gestionar Usuarios 
        public static DataTable ConsultarUsuario(String user)
        {

            NpgsqlConnection conn = Conexion();
            string query = "SELECT nombre, edad, tipo, usuario FROM usuario WHERE usuario = '" + user+"';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public static DataTable ConsultarUsuarios()
        {

            NpgsqlConnection conn = Conexion();
            string query = "SELECT nombre, edad, tipo, usuario FROM usuario;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public static void EliminarUser(string user)
        {
            NpgsqlConnection conx = Conexion();
            string query = "DELETE FROM usuario WHERE usuario  = '" + user + "'";
            // Se abre la conexion
            conx.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
             cmd.ExecuteNonQuery();
            MessageBox.Show("Usuario Eliminado");
            conx.Close();

        }

        public static void InsertarUser(string nombre, string edad, string tipo, string user, string passw)
        {
            NpgsqlConnection conx = Conexion();
            string query = "INSERT INTO usuario (nombre, edad, tipo, usuario, passw)" +
                " VALUES ('" + nombre + "', " + edad + ", '" + tipo + "', '" + user + "', '" + passw + "');"; 
            // Se abre la conexion
            conx.Open();
            // Se insertan los datos mediante el query            
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
            // Se ejecuta el query
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertado");
            conx.Close();

        }

        //Gestionar Comidas
        public static DataTable ConsultarComidas()
        {

            NpgsqlConnection conn = Conexion();
            string query = "SELECT a.nombre,b.nombre FROM comida AS a , categoria_comida AS b " +
                            "WHERE a.categoria = b.id ORDER BY categoria; ";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public static DataTable ConsultarComidasID()
        {

            NpgsqlConnection conn = Conexion();
            string query = "SELECT nombre, id FROM comida ORDER BY id; ";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public static DataTable ConsultarComidasCategoria(int categoria)
        {

            NpgsqlConnection conn = Conexion();

            string query = "SELECT a.nombre,b.nombre FROM comida AS a , categoria_comida AS b " +
                            "WHERE a.categoria = b.id  AND a.categoria = " + categoria + " ORDER BY categoria; ";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public static List<string> Categorias()
        {
            
            NpgsqlConnection conn = Conexion();
            //consultamos las categorías a la base de datos
            string query = "SELECT nombre FROM categoria_comida;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            List<string> categ = new List<string>();
            //Creo un datarow para poder manipular los datos
            DataRow row;
            //cuento las filas de la tabla
            int filas = tabla.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                //llenamos la lista con las categorías
                row = tabla.Rows[i];
                categ.Add(row[0].ToString());
            }

            return categ;
        }

        public static void InsertarComida(string nombre, int categoria)
        {
            NpgsqlConnection conx = Conexion();
            string query = "INSERT INTO comida (nombre, categoria)" +
                " VALUES ('" + nombre + "', "+ categoria + ");";
            // Se abre la conexion
            conx.Open();
            // Se insertan los datos mediante el query            
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
            // Se ejecuta el query
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertada");
            conx.Close();

        }
    }
}
