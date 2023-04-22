using Klavelvet.Shared.RequestFeatures;

namespace Klavelvet.Server.Repository
{
    public class PagedList<T> : List<T>
    {
        public Metadata Metadata { get; set; }

        public PagedList(List<T> items, int count, int pageNumber, int pagesize)
        {
            Metadata = new Metadata
            {
                TotalCount = count,
                PageSize = pagesize,
                CurrentPage= pageNumber,
                TotalPages = (int)Math.Ceiling(count/ (double)pagesize)
            };

            AddRange(items);
        }

        public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedList<T>(items, count, pageNumber, pageSize);

        }
    }
}
