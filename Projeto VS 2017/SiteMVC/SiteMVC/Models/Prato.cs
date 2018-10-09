using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMVC.Models
{
    [Table("tblPrato")]
    public class Prato
    {
            [Key]
            public int IdPrato { get; set; }

            [Display(Name = "Nome do Prato")]
            [Required(ErrorMessage = "O nome do prato é obrigatório", AllowEmptyStrings = false)]
            public string NomePrato { get; set; }

            [Display(Name = "Preço do Prato")]
            [Required(ErrorMessage = "Informe o preço do prato", AllowEmptyStrings = false)]
            [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
            public decimal PrecoPrato { get; set; }

            [Display(Name = "Identificação do restaurante")]
            public int IdRestaurante { get; set; }
            public virtual Restaurante Restaurantes { get; set; }

            //public List<Restaurante> Restaurantess { get; set; }


    }
}