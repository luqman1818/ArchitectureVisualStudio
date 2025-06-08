using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo123
{
    internal class Order
    {
        public int id_ord { get; set; }           // Clé primaire personnalisée
        public DateTime date_ord { get; set; }    // Date de la commande
        public int users_id_use { get; set; }
    }
}
