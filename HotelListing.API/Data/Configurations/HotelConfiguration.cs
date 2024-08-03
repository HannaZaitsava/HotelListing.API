using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
              new Hotel { Id = 1, Name = "Sandals Resort and Spa", Address = "Negrit", CountryId = 1, Rating = 4.5 },
              new Hotel { Id = 2, Name = "Comfort Suites", Address = "George Town", CountryId = 3, Rating = 4.3 },
              new Hotel { Id = 3, Name = "Grand Palladium", Address = "Nassau", CountryId = 2, Rating = 4 }
          );
        }
    }
}
