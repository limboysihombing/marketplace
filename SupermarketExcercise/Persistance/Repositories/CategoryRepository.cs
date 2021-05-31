using Microsoft.EntityFrameworkCore;
using SupermarketExcercise.Domain.Models;
using SupermarketExcercise.Domain.Respositories;
using SupermarketExcercise.Persistance.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketExcercise.Persistance.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }

        public async Task AddAsync(Category category)
        {
            await context.Categories.AddAsync(category);
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await context.Categories.ToListAsync();
        }

        
    }
}
