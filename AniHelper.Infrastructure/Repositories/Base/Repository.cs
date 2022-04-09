using AniHelper.Core.Repositories.Base;
using AniHelper.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniHelper.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AnimeContext _animeContext;
        public Repository(AnimeContext animeContext)
        {
            _animeContext = animeContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _animeContext.Set<T>().AddAsync(entity);
            await _animeContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _animeContext.Set<T>().Remove(entity);
            await _animeContext.SaveChangesAsync();
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _animeContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _animeContext.Set<T>().FindAsync(id);
        }
        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
