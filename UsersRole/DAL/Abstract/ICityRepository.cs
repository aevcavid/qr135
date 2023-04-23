using UsersRole.Model;

namespace UsersRole.DAL.Abstract
{
    public interface ICityRepository
    {
        List<City> Get();
        void Add(City city);
    }
}
