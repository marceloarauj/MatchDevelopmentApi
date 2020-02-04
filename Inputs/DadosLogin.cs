using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchDevelopment.Validations;

namespace MatchDevelopment.Inputs
{
    public class DadosLogin
    {
        [LoginValidation]
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
