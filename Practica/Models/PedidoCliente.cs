using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Models
{
    public class PedidoCliente
    {
       public Cliente clientes {  get; set; }
       public List<Pedido> pedidos { get; set; }
        
    }
}
