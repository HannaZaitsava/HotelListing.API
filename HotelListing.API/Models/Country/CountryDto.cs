using HotelListing.API.Data;
using HotelListing.API.Models.Hotel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Country
{
    public class CountryDto: BaseCountryDto
    {
        public int Id { get; set; }       
        public List<HotelDto> Hotels { get; set; }
    }

    
}
