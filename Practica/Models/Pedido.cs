using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Models
{
    public class Pedido
    {
        public string codPedido { get; set; }
        public string codCliente { get; set; }
        public string fechaEntrega { get; set; }
        public string formaEnvio { get; set; }
        public int importe { get; set; }
    }
}
