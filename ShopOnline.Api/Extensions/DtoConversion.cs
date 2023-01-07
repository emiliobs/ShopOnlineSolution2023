using ShopOnline.Api.Entities;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Extensions
{
    public static class DtoConversion
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> productCategories)
        {
            return (from product in products
                    join productCatogory in productCategories
                    on product.CategoryId equals productCatogory.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Descripcion = product.Description,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Qty = product.Qty,
                        CategoryId = product.CategoryId,
                        CategoryName = productCatogory.Name

                    }).ToList();
        }
    }
}
