namespace MembershipSystemManagement.Common.Pagination
{
    public class BasePaginatedList<T> where T : class
    {
        public IReadOnlyCollection<T> Items { get; set; }
        // Không cho set ngoài class
        public int PageIndex { get; private set; } 
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalItems { get; private set; }
        public bool HasPreviousPage => PageIndex > 1;      // Kiểm tra nếu có trang trước đó
        public bool HasNextPage => PageIndex < TotalPages; // Kiểm tra nếu có trang kế tiếp

        public BasePaginatedList(IReadOnlyCollection<T> items, int count, int pageIndex, int pageSize)
        {
            Items = items;
            TotalItems = count;
            PageSize = pageSize;
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }
    }
}
