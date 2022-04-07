
using System.ComponentModel.DataAnnotations;

namespace ModelProjectDDD.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Display(Name = "Disponível?")]
        public bool Available { get; set; }

        [Display(Name = "Cliente")]
        public int ClientId { get; set; }
        public virtual ClientViewModel Client { get; set; }
    }
}