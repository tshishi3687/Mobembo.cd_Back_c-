using System.ComponentModel.DataAnnotations;

namespace Mobembo.cd_Back_c____.Validation
{
    public class Date18 : ValidationAttribute
    {
        public override bool IsValid(Object objet)
        {
            DateTime date = (DateTime)objet;
            if ((DateTime.Now.Year - date.Year) >= 18)
                return true;

            return false;
        }
    }
}
