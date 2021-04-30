using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using FoodBang.Forms;
using FoodBang.Forms.Admin;
using FoodBang.Forms.User;

namespace FoodBang
{
    //En esta clase se encuentra toda la lógica del programa
    class Engine
    {
        public static bool entrar = false;
        public static bool entrarA = false;
        public static bool entrarU = false;
        public static bool logO = false;
        public static string tipoUsuario = "";
        public static int totalPedido = 0;
        public static List<string> infoPedido = new List<string>();

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
                string tipoU = TipoUs(user);
                if (tipoU == "A")
                {
                    entrarA = true;
                }
                if(tipoU == "U")
                {
                    entrarU = true;
                }
                return true;
            }
            else
            {
                return false;
                
            }
        }
        public static string TipoUs(string user)
        {
            NpgsqlConnection conn = Conexion();
            string query = "SELECT tipo FROM usuario WHERE usuario = '" + user + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
           
            DataRow row = tabla.Rows[0];

            if (row[0].ToString() == "A")
            {
                return "A";
            }
            if (row[0].ToString() == "U")
            {
                return "U";

            }
            return "";

        }

        public static void Logout() 
        {
         entrar = false;
         entrarA = false;
         entrarU = false;
         tipoUsuario = "";
         totalPedido = 0;
            logO = true;

            infoPedido = new List<string>();
            
        }

        public static void UserMenu()
        {
            if (Engine.entrarA)
            {
                logO = false;
                MenuAdmin f1 = new MenuAdmin();
                f1.ShowDialog();
            }
            if (Engine.entrarU)
            {
                logO = false;
                FrmMenuUser f1 = new FrmMenuUser();
                f1.ShowDialog();
            }
        }
        //Crear cuenta
        public static void InsertarUser(string nombre, string edad, string user, string passw)
        {
            NpgsqlConnection conx = Conexion();
            string query = "INSERT INTO usuario (nombre, edad, tipo, usuario, passw)" +
                " VALUES ('" + nombre + "', " + edad + ", '" + 'U' + "', '" + user + "', '" + passw + "');";
            // Se abre la conexion
            conx.Open();
            // Se insertan los datos mediante el query            
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
            // Se ejecuta el query
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuario Creado");
            conx.Close();

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
        public static void EliminarComida(int comida)
        {
            NpgsqlConnection conx = Conexion();
            string query = "DELETE FROM comida WHERE comida  = '" + comida + "'";
            // Se abre la conexion
            conx.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Comida Eliminada");
            conx.Close();

        }

        //Gestionar Menú User
        public static DataTable ConsultarMenu(int rest)
        {

            NpgsqlConnection conn = Conexion();
            string query = "SELECT c.nombre,m.precio, m.comida as id " +
                "FROM comida as c, menu as m " +
                "WHERE m.comida = c.id AND m.restaurant = "+rest+" ;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public static List<string> Restaurantes()
        {

            NpgsqlConnection conn = Conexion();
            //consultamos las categorías a la base de datos
            string query = "SELECT nombre FROM restaurant;";
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
                //llenamos la lista con los restaurantes
                row = tabla.Rows[i];
                categ.Add(row[0].ToString());
            }

            return categ;
        }
        public static void InsertarComidaM(int rest, int comida, int precio)
        {
            NpgsqlConnection conx = Conexion();
            string query = "INSERT INTO menu(restaurant, comida, precio)" +
                " VALUES ('" + rest + "', " + comida + "," + precio + ");";
            // Se abre la conexion
            conx.Open();
            // Se insertan los datos mediante el query            
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
            // Se ejecuta el query
            cmd.ExecuteNonQuery();
            MessageBox.Show("Comida Agregada");
            conx.Close();

        }
        public static void EliminarComidaM(int rest, int comida)
        {
            NpgsqlConnection conx = Conexion();
            string query = "DELETE FROM menu WHERE restaurant = '"+rest+"' AND comida  = '" + comida + "'";
            // Se abre la conexion
            conx.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Comida Eliminada del menú");
            conx.Close();

        }
        public static DataTable ConsultarComidasDisponibles(int rest)
        {

            NpgsqlConnection conn = Conexion();
            string query =  "SELECT a.id,a.nombre,b.nombre as categoria " +
                             "FROM comida as a, categoria_comida as b, menu as c" +
                             " WHERE a.categoria = b.id " +
                             " AND a.id NOT IN ( SELECT comida FROM menu WHERE restaurant = " + rest + ");";

            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        public static void InfoComida(int comida)
        {

            NpgsqlConnection conn = Conexion();
            string query = "SELECT c.nombre, m.precio " +
                "FROM comida c, menu m " +
                "WHERE m.comida = c.id AND m.comida = '" + comida + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            //Creo un datarow para poder manipular los datos
            DataRow row = tabla.Rows[0];
            string info = row[0].ToString() + ": " + row[1].ToString();
            totalPedido += int.Parse(row[1].ToString());
            infoPedido.Add(info);
            MessageBox.Show("Comida Agregada!");
        }
        public static List<string> ComidasMenu()
        {
            NpgsqlConnection conn = Conexion();
            //consultamos las categorías a la base de datos
            string query = "SELECT comida FROM menu;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            List<string> comidas = new List<string>();
            //Creo un datarow para poder manipular los datos
            DataRow row;
            //cuento las filas de la tabla
            int filas = tabla.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                //llenamos la lista con los restaurantes
                row = tabla.Rows[i];
                comidas.Add(row[0].ToString());
            }

            return comidas;
        }
    }
}
