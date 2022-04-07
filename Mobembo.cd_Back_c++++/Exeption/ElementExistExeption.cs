namespace Mobembo.cd_Back_c____.Exeption
{
    public sealed class ElementExistExeption<TEntity> : Exception
    {
        private Object Id;

        public ElementExistExeption(Object Id) : base($"l'élément que vous voulez créer existe déjà" +
                $"\n\t-class: {typeof(TEntity).Name} ;" +
               $"\n\t-id:.{Id}")
        {
            this.Id = Id;

        }
    }
}
