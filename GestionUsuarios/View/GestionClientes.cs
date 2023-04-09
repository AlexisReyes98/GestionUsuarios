using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionUsuarios.ConexionSQL;
using GestionUsuarios.Model;
using Org.BouncyCastle.Asn1.Ocsp;

namespace GestionUsuarios
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            ClienteSQL baseDeDatos = new ClienteSQL();
            List<Cliente> listaDb = baseDeDatos.ObtenerClientes();

            listClientes.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = textNombre.Text;
            cliente.Apellido = textApellido.Text;
            cliente.Telefono = textTelefono.Text;
            cliente.CreditCard = textCard.Text;

            if (label_ID.Text != "")
            {
                cliente.ID = label_ID.Text;
            }

            ClienteSQL baseDeDatos = new ClienteSQL();
            baseDeDatos.GuardarClientes(cliente);
            actualizarLista();
            limpiarInputs();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;

            ClienteSQL baseDeDatos = new ClienteSQL();
            baseDeDatos.Delete(cliente);
            actualizarLista();
            limpiarInputs();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            textNombre.Text = cliente.Nombre;
            textApellido.Text = cliente.Apellido;
            textTelefono.Text = cliente.Telefono;
            textCard.Text = cliente.CreditCard;
            label_ID.Text = cliente.ID;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarInputs();
        }

        private void limpiarInputs()
        {
            label_ID.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textTelefono.Text = "";
            textCard.Text = "";
        }
    }
}
