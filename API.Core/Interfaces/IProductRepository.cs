using API.Core.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// Get a product
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Product> GetProductByIDAsync(int Id);
        /// <summary>
        /// Get products list
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<Product>> GetProductAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();



    }
}
