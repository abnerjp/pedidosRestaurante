using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercicioCruds.Models
{
    public class Produto
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }

        [Display(Name = "Preço:")]
        public double Preco { get; set; }

    }
}
