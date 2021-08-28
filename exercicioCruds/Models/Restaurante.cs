using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercicioCruds.Models
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Display(Name = "CEP:")]
        public string Cep { get; set; }

        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }

        [Display(Name = "Rua:")]
        public string Logradouro { get; set; }

        [Display(Name = "Número:")]
        public string Numero { get; set; }

        [Display(Name = "Especialidade/Cozinha:")]
        public int CozinhaId { get; set; }

        [Display(Name = "Cidade:")]
        public int CidadeId { get; set; }

        public virtual Cozinha Cozinha { get; set; }

        public virtual Cidade Cidade { get; set; }

    }
}
