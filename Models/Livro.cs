using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Título é um campo obrigatório!")]
        [StringLength(150, MinimumLength = 0)]
        public required string Titulo { get; set; }

        [Required(ErrorMessage ="Ano publicação é Obrigatório!")]
        [Range(1450, 2026)]
        public int AnoPublicacao { get; set; }
        
        [Required(ErrorMessage ="Preço é uma campo obrigatório!")]
        [Column(TypeName = "decimal(10,2)")]
        public Decimal Preco { get; set; }
        
        public bool Disponivel { get; set; }
    }
}
