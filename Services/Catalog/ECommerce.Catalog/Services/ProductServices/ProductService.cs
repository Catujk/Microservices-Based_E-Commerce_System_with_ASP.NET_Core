using AutoMapper;
using ECommerce.Catalog.DTOs.ProductDTOs;
using ECommerce.Catalog.Entities;
using ECommerce.Catalog.Settings;
using MongoDB.Driver;

namespace ECommerce.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var mongoClient = new MongoClient(_databaseSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection = mongoDatabase.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductAsync(CreateProductDTO createProductDTO)
        {
            var product = _mapper.Map<Product>(createProductDTO);
            await _productCollection.InsertOneAsync(product);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(c => c.ProductID == id);
        }

        public async Task<List<ResultProductDTO>> GetAllProductsAsync()
        {
            var products = await _productCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDTO>>(products);
        }

        public async Task<GetByIdProductDTO> GetByIdProductAsync(string id)
        {
            var product = await _productCollection.Find(c => c.ProductID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDTO>(product);
        }

        public Task UpdateProductAsync(UpdateProductDTO updateProductDTO)
        {
            var values = _mapper.Map<Product>(updateProductDTO);
            return _productCollection.FindOneAndReplaceAsync(c => c.ProductID == updateProductDTO.ProductID, values);
        }
    }
}
