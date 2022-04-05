using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelProjectDDD.MVC.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage ="Preencha o campo nome")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage ="Mínimo {0} caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Preencha o campo e-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegistration { get; set; }
        public bool Active { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}