using UsersRole.DAL.Abstract;
using UsersRole.Model;

namespace UsersRole.DAL.Concrete
{
    public class CountryRepository : ICountryRepository
    {
        private readonly MyContext _ctx;
        public CountryRepository(MyContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(Country country)
        {
            _ctx.Countries.Add(country);
            _ctx.SaveChanges();
        }

        public List<Country> Get()
        {
            return _ctx.Countries.ToList();
        }
    }
}
