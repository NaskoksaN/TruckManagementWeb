using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckManagementWeb.Data;

namespace TruckManagementWeb.Infrastructure.Data.Common
{ 
    public class Repository : IRepository
    {
        private readonly DbContext context;
        public Repository(TruckDbContext _context)
        {
            context = _context;
        }

        public Task AddAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> All<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
