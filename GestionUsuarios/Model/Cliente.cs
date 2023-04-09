using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.Model
{
    internal class Cliente
    {
        private string id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string creditCard;

        public string ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string CreditCard { get; set; }

        public string NombreCommpleto
        {
            get { return ID + " " + Nombre + " " + Apellido + " " + Telefono + " " + CreditCard; }
        }

        public override string ToString()
        {
            return NombreCommpleto;
        }
    }
}
