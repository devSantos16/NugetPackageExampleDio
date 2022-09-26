using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Venda
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public double Preco { get; set; }

        public Venda(int id, string produto, double preco)
        {
            this.Id = id;
            this.Produto = produto;
            this.Preco = preco;
        }
    }
}