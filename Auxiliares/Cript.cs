using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace MatchDevelopment.Auxiliares
{
    public class Cript
    {
        public static string obterSenhaCriptografada(string senha)
        {

            SHA256 ObjetoDeEncrypt = SHA256.Create();

            var ArrayPass = Encoding.ASCII.GetBytes(senha);

            byte[] SenhaCriptografada = ObjetoDeEncrypt.ComputeHash(ArrayPass);

            senha = Convert.ToBase64String(SenhaCriptografada);

            return senha;
        }
    }
}
