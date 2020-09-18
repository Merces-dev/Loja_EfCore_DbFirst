using System;
using System.Collections.Generic;

namespace Senai.EfCore.DbFirst.Domains
{
    public partial class PedidosItens
    {
        public Guid Id { get; set; }
        public Guid IdPedido { get; set; }
        public int Quantidade { get; set; }

        public virtual Pedidos IdPedidoNavigation { get; set; }
    }
}
