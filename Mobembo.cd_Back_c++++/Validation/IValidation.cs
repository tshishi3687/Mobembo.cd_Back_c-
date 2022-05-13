namespace Mobembo.cd_Back_c____.Validation
{
    public interface IValidation<T>
    {
        bool IsValid(T objet);
    }
}
