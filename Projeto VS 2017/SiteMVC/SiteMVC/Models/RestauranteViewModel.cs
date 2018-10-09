using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SiteMVC.Models
{
    public class RestauranteViewModel
    {
        public Int32 IdRestaurante { get; set; }
        [Required(ErrorMessage = "O nome do restaurante é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Restaurante")]
        public String NomeRestaurante { get; set; }
    }
}