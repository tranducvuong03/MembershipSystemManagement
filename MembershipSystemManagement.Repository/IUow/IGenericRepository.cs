using MembershipSystemManagement.Common.Pagination;

namespace MembershipSystemManagement.Repository.IUow
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Entities { get; } // Dùng cái này thay cho getall vì nó không load tất cả dữ liệu ra
        Task<BasePaginatedList<T>> GetPagedAsync(int pageIndex, int pageSize);
        Task<T?> GetByIdAsync(Guid id);
        Task<T> AddAsync(T obj);
        Task<T> UpdateAsync(T obj);
        Task<bool> DeleteAsync(Guid id);
        Task SaveAsync();
    }
}
