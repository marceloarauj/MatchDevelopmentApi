using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MatchDevelopment.Validations
{
    public class EmailValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validation){

            string email = (string) value;
            string regex = @"^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)$";

            if(!Regex.IsMatch(email,regex))
                return new ValidationResult("Formato de email inválido");

            return ValidationResult.Success;
        }
    }
}