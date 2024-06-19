using HotelLisiting.API.Models.Hostel;

namespace HotelLisiting.API.Models.Country
{
    public class CountryDto:BaseCountryDto
    {
        public int Id { get; set; }
      

        public List<HotelDto> Hotels { get; set; }
    }
}
