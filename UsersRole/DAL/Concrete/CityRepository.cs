using UsersRole.DAL.Abstract;
using UsersRole.Model;

namespace UsersRole.DAL.Concrete
{
    public class CityRepository : ICityRepository
    {
        private readonly MyContext _ctx;
        public CityRepository(MyContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(City city)
        {
            _ctx.Cities.Add(city);
            _ctx.SaveChanges();
        }

        public List<City> Get()
        {
            return _ctx.Cities.ToList();
        }
    }
}
