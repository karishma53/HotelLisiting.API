using HotelLisiting.API.Data;

namespace HotelLisiting.API.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
