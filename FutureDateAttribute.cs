using System.ComponentModel.DataAnnotations;
using System; 
namespace date_validator
{
    public class FutureDateAttribute : ValidationAttribute
    {
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
		// You first may want to unbox "value" here and cast to to a DateTime variable!
        DateTime CurrentTime = DateTime.Now;
        if ((DateTime)value > CurrentTime)
        {
            return new ValidationResult("No future dates are allowed!");
        }
        return ValidationResult.Success;
		}
    }
}