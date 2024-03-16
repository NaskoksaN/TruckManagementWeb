using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagementWeb.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> AllAsync<T>() where T : class;
        IQueryable<T> AllReadOnlyAsync<T>() where T : class;

        Task AddAsync<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
        Task<T> GetByIdAsync<T>(object id) where T : class;
        Task DeleteAsync<T>(object id) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(IEnumerable<T> entities) where T : class;
    }
}
