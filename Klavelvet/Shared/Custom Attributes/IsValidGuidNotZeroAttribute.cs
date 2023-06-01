using System.ComponentModel.DataAnnotations;

namespace Klavelvet.Shared.Custom_Attributes
{
    public class IsValidGuidNotZeroAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Check if the value is null.
            if (value == null)
            {
                return null;
            }

            // Check if the value is a string.
            if (!(value is Guid))
            {

                return new ValidationResult("The value must be a GUID.");
            }

            // Check if the GUID is valid.
            if (!IsValidGuidNotZero(value.ToString()))
            {
                return new ValidationResult("The GUID is not valid.");
            }

            // The GUID is valid.
            return null;
        }

        public static bool IsValidGuidNotZero(string guid)
        {
            // Check if the guid is 36 characters long.
            if (guid.Length != 36)
            {
                return false;
            }

            // Check if the guid contains any non-zero values.
            foreach (char c in guid)
            {
                if (c != '0')
                {
                    return true;
                }
            }

            // If all of the values in the guid are zero, then it is a default guid.
            return false;
        }        
    }
}