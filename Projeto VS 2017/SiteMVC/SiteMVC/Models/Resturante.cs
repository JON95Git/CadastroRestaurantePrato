using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SiteMVC.Models
{
    [Table("tblRestaurante")]
    public class Restaurante
    {
        [Key]
        public int IdRestaurante { get; set; }

        [Display(Name = "Nome do Restaurante")]
        [Required(ErrorMessage = "O nome do restaurante é obrigatório", AllowEmptyStrings = false)]
        public string NomeRestaurante { get; set; }

        public List<Prato> Pratos { get; set; }
    }
}