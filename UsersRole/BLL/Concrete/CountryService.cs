using AutoMapper;
using UsersRole.BLL.Abstract;
using UsersRole.DAL.Abstract;
using UsersRole.DTOs.CountryDTOs;
using UsersRole.Model;

namespace UsersRole.BLL.Concrete
{
    public class CountryService : ICountryService
    {
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;
        public CountryService(IMapper mapper, ICountryRepository countryRepository)
        {
                _mapper = mapper;
            _countryRepository = countryRepository;
        }
        public void Add(CountryToAddDto dto)
        {
            Country country=_mapper.Map<Country>(dto);
            _countryRepository.Add(country);
        }

        public List<CountryToListDto> Get()
        {
            List<Country> countryList = _countryRepository.Get();
            List<CountryToListDto> dtos = _mapper.Map<List<CountryToListDto>>(countryList);
            return dtos;
        }
    }
}
