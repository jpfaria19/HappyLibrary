using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do livro."), Column(Order = 1)]
        [MinLength(3, ErrorMessage = "O tamanho mínimo do nome são 3 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [DisplayName("Título")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Digite o número ISBN do livro."), Column(Order = 2)]
        [MinLength(10, ErrorMessage = "O tamanho mínimo do nome são 10 caracteres.")]
        [StringLength(17, ErrorMessage = "O tamanho máximo são 13 caracteres.")]
        [DisplayName("ISBN")]
        public String Isbn { get; set; }

        [Required(ErrorMessage = "Digite a data de lançamento do livro"), Column(Order = 3)]
        [DisplayName("Data de lançamento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Release { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
