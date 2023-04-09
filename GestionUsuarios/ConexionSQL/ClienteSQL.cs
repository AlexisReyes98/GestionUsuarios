using GestionUsuarios.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.ConexionSQL
{
    internal class ClienteSQL
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "GARVbases20";
            string dataBase = "gestion_usuarios";

            string cadenaConexion = "Database=" + dataBase + "; Data Source=" 
                + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();

            return conexionDb;
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            string consulta = "SELECT *FROM clientes";

            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Cliente cliente = new Cliente();
                cliente.ID = lectura.GetString("id");
                cliente.Nombre = lectura.GetString("nombre");
                cliente.Apellido = lectura.GetString("apellido");
                cliente.Telefono = lectura.GetString("telefono");
                cliente.CreditCard = lectura.GetString("credit_card");
                lista.Add(cliente);
            }
            comando.Connection.Close();

            return lista;
        }

        public void GuardarClientes(Cliente cliente)
        {
            if (cliente.ID == null)
            {
                Insert(cliente);
            }
            else
            {
                Update(cliente);
            }
        }

        private void Insert(Cliente cliente)
        {
            string consulta = "INSERT INTO clientes(id, nombre, apellido, telefono, credit_card) VALUES (NULL, '"
                + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Telefono + "', '" + cliente.CreditCard + "');";
            
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        private void Update(Cliente cliente)
        {
            string consulta = "UPDATE clientes SET nombre = '" + cliente.Nombre + "', apellido = '" + cliente.Apellido + "', telefono = '"
                + cliente.Telefono + "', credit_card = '" + cliente.CreditCard
                + "' WHERE clientes.id = '" + cliente.ID + "';";

            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Delete(Cliente cliente)
        {
            string consulta = "DELETE FROM clientes WHERE clientes.id = '" + cliente.ID + "';";
            
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
    }
}
