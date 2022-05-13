using System.ComponentModel.DataAnnotations;

namespace Mobembo.cd_Back_c____.Validation
{
    public class EmailExiste : ValidationAttribute
    {
        private Context _context =  new Context();
        public override bool IsValid(object objet)
        {
            string text = objet.ToString();
            if (text == "")
                return false;

            if (_context.personnes.FirstOrDefault(x => x.Email == text) != null)
            return false;

            return true;
        }
    }
}
