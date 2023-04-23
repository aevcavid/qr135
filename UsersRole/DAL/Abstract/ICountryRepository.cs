using UsersRole.Model;

namespace UsersRole.DAL.Abstract
{
    public interface ICountryRepository
    {
        List<Country> Get();
        void Add(Country country);
    }
}
