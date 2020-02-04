using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchDevelopment.Validations;

namespace MatchDevelopment.Inputs
{
    public class DadosRegistrar
    {
        [LettersValidation]
        public string NomeUsuario { get; set; }
        [EmailValidation]
        public string Email { get; set; }
        public string Senha { get; set; }
        [LoginValidation]
        public string Login { get; set; }

    }
}
