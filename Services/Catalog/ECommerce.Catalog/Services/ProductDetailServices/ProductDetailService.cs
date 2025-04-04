using AutoMapper;
using ECommerce.Catalog.DTOs.ProductDetailDTOs;
using ECommerce.Catalog.Entities;
using ECommerce.Catalog.Settings;
using MongoDB.Driver;

namespace ECommerce.Catalog.Services.ProductDetailServices
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IMongoCollection<ProductDetail> _productDetailCollection;
        private readonly IMapper _mapper;

        public ProductDetailService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var mongoClient = new MongoClient(_databaseSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(_databaseSettings.DatabaseName);
            _productDetailCollection = mongoDatabase.GetCollection<ProductDetail>(_databaseSettings.ProductDetailCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductDetailAsync(CreateProductDetailDTO createProductDetailDTO)
        {
            var productDetail = _mapper.Map<ProductDetail>(createProductDetailDTO);
            await _productDetailCollection.InsertOneAsync(productDetail);
        }

        public async Task DeleteProductDetailAsync(string id)
        {
            await _productDetailCollection.DeleteOneAsync(c => c.ProductDetailID == id);
        }

        public async Task<List<ResultProductDetailDTO>> GetAllProductDetailsAsync()
        {
            var productDetails = await _productDetailCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDetailDTO>>(productDetails);
        }

        public async Task<GetByIdProductDetailDTO> GetByIdProductDetailAsync(string id)
        {
            var productDetail = await _productDetailCollection.Find(c => c.ProductDetailID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDetailDTO>(productDetail);
        }

        public async Task UpdateProductDetailAsync(UpdateProductDetailDTO updateProductDetailDTO)
        {
            var values = _mapper.Map<ProductDetail>(updateProductDetailDTO);
            await _productDetailCollection.FindOneAndReplaceAsync(c => c.ProductDetailID == updateProductDetailDTO.ProductDetailID, values);
        }
    }
}
