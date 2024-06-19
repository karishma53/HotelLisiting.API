using HotelLisiting.API.Contracts;
using HotelLisiting.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelLisiting.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelLisitingDbContext _context;

        public CountriesRepository(HotelLisitingDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}