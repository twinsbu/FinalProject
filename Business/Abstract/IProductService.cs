using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        //Aynı zamanda mesajı ve işlem sonucunu döndür.
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult <List<ProductDetailDto>> GetProductDetails();

        // IDataResult <Product> GetById(int productId); 
        //GetById de Product datamızın kendisi List değil!
        IDataResult<Product> GetById(int productId);//Tek başına ürün döndürüyor.

        IResult Add(Product product);//void olduğu için bir şey döndürmüyor.
        //Voidi IResult olarak değiştirdik!
    }
}
