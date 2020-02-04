using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MatchDevelopment.Validations
{
    public class LettersValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validation){
            
            string letras = (string) value;
            string regex = @"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]+$";

            if(Regex.IsMatch(letras,regex))
                return new ValidationResult("possui caracteres não permitidos");
                
            return ValidationResult.Success;
        } 
    }
}