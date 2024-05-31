using examen_final_prog1.Datos.Modelos;
using MySql.Data.MySqlClient;
using System; 
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using examen_final_prog1;


namespace examen_final_prog1.Datos
{
    internal class coneccionsql
    {

        string strconectsql = "server=localhost;database=examenprog1;user=root;password=mdi9382";

        private MySqlConnection connection;

        public coneccionsql() 
        {
        connection = new MySqlConnection(strconectsql);
        }

        //funcion para poder insertar los datos introducidos en el objeto producto en nuestra base de datos
        public void insertar(producto prd)
        {
            try 
            {
                string cuerito = "INSERT INTO tienda (producto, precio, existencias, en_tienda, categoria, marca) VALUES(@producto, @precio, @existencias, @en_tienda, @categoria, @marca)";
                MySqlCommand cmd = new MySqlCommand(cuerito, connection);
                cmd.Parameters.AddWithValue("@producto", prd.Nombre);
                cmd.Parameters.AddWithValue("@precio", prd.Precio);
                cmd.Parameters.AddWithValue("@existencias", prd.Existencias);
                cmd.Parameters.AddWithValue("@en_tienda", prd.En_tienda);
                cmd.Parameters.AddWithValue("@categoria", prd.Categoria);
                cmd.Parameters.AddWithValue("@marca", prd.Marca);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch  (Exception ex)
            {
                MessageBox.Show("ha ocurrido un error al tratar de insertar los parametros");
            } 
            finally 
            {
            connection.Close();
            }

            
        }
        

        //funcion para buscar datos
        public List<producto> buscar(decimal id)
        {
            string cuerito = "SELECT * FROM tienda where id=@par";
            List<producto> productos = new List<producto>();

            using (MySqlConnection con = new MySqlConnection(strconectsql))

                try
                {
                MySqlCommand cmd = new MySqlCommand(cuerito, connection);
                    cmd.Parameters.AddWithValue("@par",id);
                connection.Open();
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    {
                    producto prod = new producto(
                        id: reader.GetDecimal("ID"),
                        nombre: reader.GetString("producto"),
                        precio: reader.GetDecimal("precio"),
                        existencias: reader.GetDecimal("existencias"),
                        en_tienda: reader.GetDecimal("en_tienda"),
                        categoria: reader.GetString("categoria"),
                        marca: reader.GetString("marca")
                        );
                    productos.Add(prod);
                    }
                reader.Close();

                }
                catch (Exception ex)
                {
                //MessageBox.Show("error al tratar de buscar");
                    MessageBox.Show(cuerito);
                }
                finally 
                { 
                connection.Close();
                }
            return productos;
        }
       

        //funcion para actualizar lo datos 

        public void actualizar(producto prd)
        {
            try
            {
                string cuerito = "UPDATE tienda SET producto=@producto, precio=@precio, existencias=@existencias, en_tienda=@en_tienda, categoria=@categoria, marca=@marca WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(cuerito, connection);
                cmd.Parameters.AddWithValue("@producto", prd.Nombre);
                cmd.Parameters.AddWithValue("@precio", prd.Precio);
                cmd.Parameters.AddWithValue("@existencias", prd.Existencias);
                cmd.Parameters.AddWithValue("@en_tienda", prd.En_tienda);
                cmd.Parameters.AddWithValue("@categoria", prd.Categoria);
                cmd.Parameters.AddWithValue("@marca", prd.Marca);
                cmd.Parameters.AddWithValue("@id",prd.Id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ha ocurrido un error al tratar de insertar los parametros");
            }
            finally
            {
                connection.Close();
            }
        }

        public void borrar(decimal id)
        {
            try
            {

                string cuerito = "DELETE FROM tienda WHERE id=@par";

                MySqlCommand cmd = new MySqlCommand(cuerito, connection);
                cmd.Parameters.AddWithValue("@par", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error al tratar de borrar los datos");
            }
            finally 
            { 
                connection.Close();
            }
        }

        //funcion para llenar la tabla mostrada al usuario usando los datos almacenados en nuestra DB
        public List<producto> obtenertabla ()
        {
            List<producto> productos = new List<producto>();

            using (MySqlConnection con = new MySqlConnection(strconectsql)) 
            {
                try
                {
                    string cuerito = "SELECT * FROM tienda";
                    MySqlCommand cmd = new MySqlCommand(cuerito, connection);
                    
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        producto prod = new producto(
                            id: reader.GetDecimal("ID"),
                            nombre: reader.GetString("producto"),
                            precio: reader.GetDecimal("precio"),
                            existencias: reader.GetDecimal("existencias"),
                            en_tienda: reader.GetDecimal("en_tienda"),
                            categoria: reader.GetString("categoria"),
                            marca: reader.GetString("marca")
                            ) ;
                        productos.Add( prod );
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ha ocurrido un error al tratar de recuperar los datos de la base de datos");
                }
                finally
                {
                    connection.Close();
                }
                return productos;

            }
        }

    }
}
