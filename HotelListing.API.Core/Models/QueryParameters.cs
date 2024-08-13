namespace HotelListing.API.Core.Models
{
    public class QueryParameters
    {
        private int _pageSise = 15;
        public int StartIndex { get; set; }
        public int PageNumber { get; set; }
        public int PageSize
        {
            get { return _pageSise; }
            set { _pageSise = value; }
        }
    }
}
