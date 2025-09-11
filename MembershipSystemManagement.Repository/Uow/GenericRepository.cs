using MembershipSystemManagement.Common.Pagination;
using MembershipSystemManagement.Repository.IUow;
using Microsoft.EntityFrameworkCore;

namespace MembershipSystemManagement.Repository.Uow
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MembershipDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(MembershipDbContext context) 
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> Entities => _dbSet;

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<BasePaginatedList<T>> GetPagedAsync(int pageIndex, int pageSize)
        {
            var query = _dbSet.AsNoTracking(); // AsNoTracking để tăng hiệu suất khi chỉ đọc dữ liệu

            int count = await query.CountAsync();

            // Lấy dữ liệu cho trang hiện tại
            IReadOnlyCollection<T> items = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new BasePaginatedList<T>(items, count, pageIndex, pageSize);
        }

        public async Task<T> AddAsync(T obj)
        {
            await _dbSet.AddAsync(obj);
            return obj;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            T entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            return true;
        }

        public Task<T> UpdateAsync(T obj)
        {
            _dbSet.Update(obj);
            return Task.FromResult(obj);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
