using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SiteMVC.Models
{
    public class PratoViewModel
    {
        public Int32 IdPrato { get; set; }

        [Required(ErrorMessage = "O nome do prato é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Prato")]
        public String NomePrato { get; set; }

        [Required(ErrorMessage = "Informe o preço do prato", AllowEmptyStrings = false)]
        [Display(Name = "Preço")]
        public Decimal Preco { get; set; }

        [Required(ErrorMessage = "Selecione um restaurante", AllowEmptyStrings = false)]
        [Display(Name = "Restaurante")]
     
        public Int32 IdRestaurante { get; set; }

    }
}