using AutoMapper;
using UsersRole.BLL.Abstract;
using UsersRole.DAL.Abstract;
using UsersRole.DAL.Concrete;
using UsersRole.DTOs.CityDTOs;
using UsersRole.Model;

namespace UsersRole.BLL.Concrete
{
    public class CityService : Service
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;
        public CityService(IMapper mapper, ICityRepository cityRepository)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
        }

        public void Add(CityToAddDto dto)
        {
            City city=_mapper.Map<City>(dto);
            _cityRepository.Add(city);
        }

        public List<CityToListDto> Get()
        {
            List<City> citylist=_cityRepository.Get();
            List<CityToListDto> dtos=_mapper.Map<List<CityToListDto>>(citylist);    
            return dtos;
        }
    }
}
