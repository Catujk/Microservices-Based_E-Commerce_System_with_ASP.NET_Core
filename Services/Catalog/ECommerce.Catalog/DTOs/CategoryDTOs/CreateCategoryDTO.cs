using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ECommerce.Catalog.DTOs.CategoryDTOs
{
    public class CreateCategoryDTO
    {
        public string CategoryName { get; set; }
    }
    
}
