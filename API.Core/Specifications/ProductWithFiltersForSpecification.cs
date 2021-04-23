using API.Core.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Core.Specifications
{
    public class ProductWithFiltersForSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForSpecification(ProductSpecParams productSpecParams)
          : base(x =>
                        (string.IsNullOrWhiteSpace(productSpecParams.Search) || x.Name.ToLower().Contains(productSpecParams.Search))
                        &&
                         (!productSpecParams.BrandId.HasValue || x.ProductBrandID == productSpecParams.BrandId)
                         &&
                         (!productSpecParams.TypeId.HasValue || x.ProductTypeID == productSpecParams.TypeId)
                        )
        {

        }
    }
}
