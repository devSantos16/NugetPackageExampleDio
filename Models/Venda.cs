using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models.Venda
{
    public class Venda
    {

        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public double Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}