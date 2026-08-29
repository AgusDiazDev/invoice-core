using FacturacionApp.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace FacturacionApp.Api.Repositories;


public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetByIdAsync(int id);
    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
}