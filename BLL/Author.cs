using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome."), Column(Order = 1)]
        [MinLength(3, ErrorMessage = "O tamanho mínimo do nome são 3 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [DisplayName("Nome")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Digite o nome do autor."), Column(Order = 2)]
        [MinLength(3, ErrorMessage = "O tamanho mínimo do sobrenome são 3 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [DisplayName("Sobrenome")]
        public String Surname { get; set; }

        [Required(ErrorMessage = "Digite seu e-mail"), Column(Order = 3)]
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Digite a data de nascimento"), Column(Order = 4)]
        [DisplayName("Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        
        public virtual ICollection<Book> Books { get; set; }
    }
}
