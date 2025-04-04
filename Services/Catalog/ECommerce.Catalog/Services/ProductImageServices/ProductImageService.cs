using AutoMapper;
using ECommerce.Catalog.DTOs.ProductImageDTOs;
using ECommerce.Catalog.Entities;
using ECommerce.Catalog.Settings;
using MongoDB.Driver;

namespace ECommerce.Catalog.Services.ProductImageServices
{
    public class ProductImageService : IProductImageService
    {
        private readonly IMongoCollection<ProductImage> _productImageCollection;
        private readonly IMapper _mapper;

        public ProductImageService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var mongoClient = new MongoClient(_databaseSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(_databaseSettings.DatabaseName);
            _productImageCollection = mongoDatabase.GetCollection<ProductImage>(_databaseSettings.ProductImageCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductImageAsync(CreateProductImageDTO createProductImageDTO)
        {
            var productImage = _mapper.Map<ProductImage>(createProductImageDTO);
            await _productImageCollection.InsertOneAsync(productImage);
        }

        public async Task DeleteProductImageAsync(string id)
        {
            await _productImageCollection.DeleteOneAsync(c => c.ProductImageID == id);
        }

        public async Task<List<ResultProductImageDTO>> GetAllProductImagesAsync()
        {
            var productImages = await _productImageCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductImageDTO>>(productImages);
        }

        public async Task<GetByIdProductImageDTO> GetByIdProductImageAsync(string id)
        {
            var productImage = await _productImageCollection.Find(c => c.ProductImageID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductImageDTO>(productImage);
        }

        public async Task UpdateProductImageAsync(UpdateProductImageDTO updateProductImageDTO)
        {
            var values = _mapper.Map<ProductImage>(updateProductImageDTO);
            await _productImageCollection.FindOneAndReplaceAsync(c => c.ProductImageID == updateProductImageDTO.ProductImageID, values);
        }
    }
}
