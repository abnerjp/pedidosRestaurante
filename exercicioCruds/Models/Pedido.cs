using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercicioCruds.Models
{
    public class Pedido
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Data do pedido")]
        public DateTime DataPedido { get; set; }

        [Display(Name = "Desconto(R$)")]
        public double Desconto { get; set; }

        [Display(Name = "Valor do frete(R$)")]
        public double TaxaFrete { get; set; }

        [Display(Name = "Valor Total(R$)")]
        public double ValorTotal { get; set; }

        [Display(Name = "Restaurante")]
        public int RestauranteId { get; set; }

        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        public virtual Restaurante Restaurante { get; set; }

        public virtual Produto Produto { get; set; }

    }
}
