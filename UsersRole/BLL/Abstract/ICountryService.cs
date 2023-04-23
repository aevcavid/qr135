using UsersRole.DTOs.CountryDTOs;

namespace UsersRole.BLL.Abstract
{
    public interface ICountryService
    {
        void Add(CountryToAddDto dto);
        List<CountryToListDto> Get();
    }
}
