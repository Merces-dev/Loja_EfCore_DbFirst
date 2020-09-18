using System;
using System.Collections.Generic;

namespace Senai.EfCore.DbFirst.Domains
{
    public partial class Produtos
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
    }
}
