using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
//Code refactoring : kodun iyilestirilmesi
namespace DataAccess.Abstract
{

    public interface IProductDal: IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetailDtos();
    }
}
