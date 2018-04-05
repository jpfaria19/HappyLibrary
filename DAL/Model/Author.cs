using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do produto.")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [DisplayName("Nome")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Digite o nome do autor.")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [DisplayName("Sobrenome")]
        public String Surname { get; set; }

        [Required(ErrorMessage = "Digite seu e-mail")]
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Digite a data de nascimento")]
        [DisplayName("Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }
        
        public virtual ICollection<Book> Books { get; set; }
    }
}
