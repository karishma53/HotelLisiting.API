using HotelLisiting.API.Contracts;
using HotelLisiting.API.Data;

namespace HotelLisiting.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelLisitingDbContext context) : base(context)
        {

        }
    }
}
