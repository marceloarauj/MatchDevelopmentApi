using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MatchDevelopment.Validations
{
    public class LoginValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validation){
            
            string login = (string) value;
            string regex = @"^[a-zA-Z]+[0-9a-zA-Z]+$";

            if(!login.Equals("admin") & (login.Length < 10 || login.Length > 20 ))
                return new ValidationResult("número inválido de caracteres no login");
            
            if(!Regex.IsMatch(login,regex))
                return new ValidationResult("login com formato inválido");

            return ValidationResult.Success;
        }

    }
}