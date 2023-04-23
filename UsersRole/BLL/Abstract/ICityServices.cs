using UsersRole.DTOs.CityDTOs;
using UsersRole.DTOs.CountryDTOs;

namespace UsersRole.BLL.Abstract
{
    public interface Service
    {
        void Add(CityToAddDto dto);
        List<CityToListDto> Get();
    }
}
