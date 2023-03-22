using Klavelvet.Shared.RequestFeatures;

namespace Klavelvet.Client.Features
{
    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; }
        public Metadata Metadata { get; set; }
    }
}
