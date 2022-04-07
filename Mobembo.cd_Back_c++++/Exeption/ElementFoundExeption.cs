namespace Mobembo.cd_Back_c____.Exeption
{
    public class ElementFoundExeption<TEntity> : Exception
    {
        private Object Id;

        public ElementFoundExeption(Object Id) : base($"l'élément que vous chercheez n'existe pas" +
                $"\n\t-class: {typeof(TEntity).Name} ;" +
               $"\n\t-id:.{Id}")
        {
            this.Id = Id;

        }
    }
}
