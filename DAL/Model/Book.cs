using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do livro.")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [DisplayName("Título")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Digite o número ISBN do livro.")]
        [MinLength(10, ErrorMessage = "O tamanho mínimo do nome são 10 caracteres.")]
        [StringLength(13, ErrorMessage = "O tamanho máximo são 13 caracteres.")]
        [DisplayName("ISBN")]
        public String Isbn { get; set; }

        [Required(ErrorMessage = "Digite a data de lançamento do livro")]
        [DisplayName("Data de lançamento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Release { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
