using SupermarketExcercise.Domain.Models;
using SupermarketExcercise.Domain.Respositories;
using SupermarketExcercise.Domain.Services;
using SupermarketExcercise.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketExcercise.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await categoryRepository.ListAsync();
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await categoryRepository.AddAsync(category);
                await unitOfWork.CompleteAsync();

                return new SaveCategoryResponse(category);
            } catch(Exception ex)
            {
                return new SaveCategoryResponse($"An error occured when saveing the category: {ex.Message}");
            }
        }
    }
}
