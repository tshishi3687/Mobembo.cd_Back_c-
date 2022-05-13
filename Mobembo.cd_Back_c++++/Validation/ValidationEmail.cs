using System.ComponentModel.DataAnnotations;

namespace Mobembo.cd_Back_c____.Validation
{
    public class ValidationEmail : ValidationAttribute
    {
        public override bool IsValid(object objet)
        {
            string text = objet.ToString();
            if (text == null)
                return false;

            if (new EmailAddressAttribute().IsValid(text))
                return true;

            return false;
        }
    }
}
