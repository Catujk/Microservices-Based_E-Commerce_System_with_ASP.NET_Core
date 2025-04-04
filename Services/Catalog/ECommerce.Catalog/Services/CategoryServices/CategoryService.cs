using AutoMapper;
using ECommerce.Catalog.DTOs.CategoryDTOs;
using ECommerce.Catalog.Entities;
using ECommerce.Catalog.Settings;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ECommerce.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var mongoClient = new MongoClient(_databaseSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(_databaseSettings.DatabaseName);
            _categoryCollection = mongoDatabase.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO)
        {
            var category = _mapper.Map<Category>(createCategoryDTO);
            await _categoryCollection.InsertOneAsync(category);
        }

        public async Task DeleteCategoryAsync(string id)
        {
            await _categoryCollection.DeleteOneAsync(c => c.CategoryID == id);
        }

        public async Task<List<ResultCategoryDTO>> GetAllCategoriesAsync()
        {
            var categories = await _categoryCollection.Find(x=>true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDTO>>(categories);
        }

        public async Task<GetByIdCategoryDTO> GetByIdCategoryAsync(string id)
        {
            var category = await _categoryCollection.Find(c => c.CategoryID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdCategoryDTO>(category);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO)
        {
            var values = _mapper.Map<Category>(updateCategoryDTO);  
            await _categoryCollection.FindOneAndReplaceAsync(c => c.CategoryID == updateCategoryDTO.CategoryID, values);
        }
    }
}
