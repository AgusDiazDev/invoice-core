using FacturacionApp.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FacturacionApp.Api.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
  protected readonly DbContext _context;

  protected readonly DbSet<TEntity> _dbSet;

  public BaseRepository(FacturacionDbContext context)
  {
    _context = context;
    _dbSet = context.Set<TEntity>();
  }

  public async Task<IReadOnlyList<TEntity>> GetAllAsync(){
    return await _dbSet.ToListAsync();
  }

  public async Task<TEntity> GetByIdAsync(int id) {
    return await _dbSet.FindAsync(id);
  }

  public async Task AddAsync(TEntity entity){
      await _dbSet.AddAsync(entity);
      await _context.SaveChangesAsync();
      Console.WriteLine("Creado con exito");
  }

  public async Task UpdateAsync(TEntity entity){
      _dbSet.Update(entity);
      await _context.SaveChangesAsync();
      Console.WriteLine("Actualizado con exito")
  }

  public async Task DeleteAsync(int id){
    
      var entity = await _dbSet.FindAsync(id);

     if(entity != null){
      _dbSet.Remove(entity);
      await _context.SaveChangesAsync();
      Console.WriteLine("Eliminado con exito");
     }else{
      Console.WriteLine("Entidad no encontrada");
     }
  }
}