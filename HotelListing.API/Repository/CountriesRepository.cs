using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace HotelListing.API.Repository
{
    public class CountriesRepository: GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListeningDbContext _context;

        public CountriesRepository(HotelListeningDbContext context): base(context)
        {
            _context = context;
        }

        public async Task<Country> GetDetails(int? id)
        {
            return await _context.Countries
                .Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
