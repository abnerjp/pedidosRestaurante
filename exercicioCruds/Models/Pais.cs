using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercicioCruds.Models
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Display(Name = "Sigla:")]
        public string Sigla { get; set; }
    }
}
