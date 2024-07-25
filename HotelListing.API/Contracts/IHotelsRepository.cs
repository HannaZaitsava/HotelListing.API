using HotelListing.API.Data;
using HotelListing.API.Repository;

namespace HotelListing.API.Contracts
{
    public interface IHotelsRepository: IGenericRepository<Hotel>
    {
    }
}
