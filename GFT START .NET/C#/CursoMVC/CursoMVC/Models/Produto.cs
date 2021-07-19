using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatório")]

        public int quantidade { get; set; }
        [Range(1,50)]
        public int CategoriaID { get; set; }

        public Categoria Categoria { get; set; }

    }

}
