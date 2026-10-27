using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(150, ErrorMessage = "O nome é Obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        [StringLength(150, ErrorMessage = "O emaail deve ter no maximo 150 caracteres.")]
        public string Email { get; set; } = string.Empty;

        public string SenhaHash { get; set; } = string.Empty;

        [Required(ErrorMessage ="O campo data é obrigatório.")]
        [DataType(DataType.Date)]
        [Display(Name = "Daata de nascimento")]
        public DateTime DataNascimento { get; set; }

        public bool Ativo { get; set; } = true;

        [Display(Name = "Daata de cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
