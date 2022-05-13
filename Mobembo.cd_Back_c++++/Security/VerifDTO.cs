using System.ComponentModel.DataAnnotations;

namespace Mobembo.cd_Back_c____.Security
{
    public class VerifDTO : ValidationAttribute
    {

        private Context Context = new Context();

        public bool VerifDate(DateTime date)
        {
            if ((DateTime.Now.Year - date.Year) >= 18)
                return true;

            return false;
        }

        public bool IsValidEmail(string email)
        {
            if (email == null)
                return false;

            if (new EmailAddressAttribute().IsValid(email))
                return true;

            return false;
        }

        public bool EmailExiste(string email)
        {
            if (Context.personnes.FirstOrDefault(x => x.Email == email) != null)
                return false;

            return true;
        }
    }
}
