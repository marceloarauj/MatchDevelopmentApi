using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatchDevelopment.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        public long id_usuario { get; set; }

        public string nome_usuario { get; set; }
        public string email_usuario { get; set; }
        public long avaliacao_usuario { get; set; }
        public string login_usuario { get; set; }
        public string senha_usuario { get; set; }
    }
}
