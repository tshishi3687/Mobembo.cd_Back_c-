namespace Mobembo.cd_Back_c____.Exeption
{
    public class ElementNullExeption : Exception
    {
        public ElementNullExeption() : base($"l'élément que vous voulez transformer est vide !")
        {
        }
    }
}
