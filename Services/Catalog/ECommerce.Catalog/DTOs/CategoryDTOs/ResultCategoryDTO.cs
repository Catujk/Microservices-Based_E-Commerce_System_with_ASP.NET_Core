using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ECommerce.Catalog.DTOs.CategoryDTOs
{
    public class ResultCategoryDTO
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
