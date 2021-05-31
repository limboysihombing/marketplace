using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupermarketExcercise.Domain.Models;
using SupermarketExcercise.Domain.Services;
using SupermarketExcercise.Resources;
using System;
using System.Collections.Generic;
using SupermarketExcercise.Extensions;
using System.Threading.Tasks;

namespace SupermarketExcercise.Controllers
{

    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResources>> GetAllAsync()
        {
            var categories = await categoryService.ListAsync();
            var resources = mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResources>>(categories);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var category = mapper.Map<SaveCategoryResource, Category>(resource);
            var result = await categoryService.SaveAsync(category);
            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = mapper.Map<Category, CategoryResources>(result.Category);
            return Ok(categoryResource);
        }

    }
}
