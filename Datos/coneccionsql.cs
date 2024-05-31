using examen_final_prog1.Datos.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_final_prog1.Datos
{
    internal class coneccionsql
    {

        string conparsql = "server=localhost;database=examenprog1;user=root;password=mdi9382";

        private MySqlConnection connection;

        public coneccionsql() 
        {
        connection = new MySqlConnection(conparsql);
        }
        public void insertar(producto prd)
        {
            try 
            {
                string cuerito = "INSERT INTO tienda (producto, precio, existencias, en_tienda, categoria, marca) VALUES(@producto, @precio, @existencias, @en_tienda, @categoria, @marca)";
                MySqlCommand cmd = new MySqlCommand(cuerito, connection);
                cmd.Parameters.AddWithValue("@producto", prd.nombre);
                cmd.Parameters.AddWithValue("@precio", prd.precio);
                cmd.Parameters.AddWithValue("@existencias", prd.existencias);
                cmd.Parameters.AddWithValue("@en_tienda", prd.en_tienda);
                cmd.Parameters.AddWithValue("@categoria", prd.categoria);
                cmd.Parameters.AddWithValue("@marca", prd.marca);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch  (Exception x)
            {
                MessageBox.Show("ha ocurrido un error al tratar de insertar los parametros");
            } 
            finally 
            {
            connection.Close();
            }
            
        }

    }
}
