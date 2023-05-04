using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class PessoaModelView
    {
        [Required] //É uma requisição, caso contrário, haverá uma exceção.
        public string Name { get; set; }

        public string LastName { get; set; }

        public string EndName { get; set; }
    }
}
