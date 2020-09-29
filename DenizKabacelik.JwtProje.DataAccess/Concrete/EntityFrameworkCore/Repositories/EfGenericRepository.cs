using DenizKabacelik.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using DenizKabacelik.JwtProje.DataAccess.Interfaces;
using DenizKabacelik.JwtProje.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DenizKabacelik.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task Add(TEntity entity)
        {
            using var context = new DenizJwtContext();
            context.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            using var context = new DenizJwtContext();
             return await context.Set<TEntity>().ToListAsync();
        }

        public async  Task<List<TEntity>> GetAllByFilter(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new DenizJwtContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync(); 
        }

        public  async Task<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {

            using var context = new DenizJwtContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetById(int id)
        {
            using var context = new DenizJwtContext();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task Remove(TEntity entity)
        {
            using var context = new DenizJwtContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            using var context = new DenizJwtContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
