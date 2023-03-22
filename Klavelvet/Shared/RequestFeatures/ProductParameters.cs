namespace Klavelvet.Shared.RequestFeatures
{
    public class ProductParameters
    {
        const int MAX_PAGE_SIZE = 30;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 4;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > MAX_PAGE_SIZE) ? MAX_PAGE_SIZE : value;
            }
        }

    }
}
