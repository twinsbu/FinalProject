using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                //magic string 
                return new ErrorResult(Messages.ProductNameInvalid);
            }

            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);

            //business kodları her şey geçerliyse ekle geçerli değilse ekleme gibi kodları yazacağız!
            //Biz bir istekte bulunan kişiye "İşlem başarısız oldu" şundan dolayı başarız oldu. Veya "İşlem başarılı oldu, eklendi",
            //diye bilgiler vereceğiz.
            
            //return new Result dediğimize göre demekki _productDal.Add'i geçmiş ve ekleme başarılı olmuş.
            //return new Result(true,"Ürün eklendi.");//bunu yapabilmemizin yöntemi Concsractor ekleyebilmemizdir.
                                                    //Result ampüle tıkla conctractor resul (with field) tıkla otomatik Result cs'ye constroctor oluşturuluyor!

            // return new Result(true,"Ürün eklendi."); kodun amacı,
            //sadece get yazdık neden set yazmadık?
            //amacımız kurumsal olsun ve set koyarsak programcı kafasına göre kod yazmasın onu sınırlandırıyoruz!
            //kodların okunurluğu standart olsun!
        }

        public IDataResult <List<Product>> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?

            //Saat 22 olduğunda sistemi kapatıp, ürünlerin gözükmesini istemiyorsak aşağıdaki kodu yazarız,
            //MaintenanceTime bakımda demek, sistem bakımda demenin kodu,
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p=>p.CategoryId==id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product> (_productDal.Get(p=>p.ProductId==productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>> (_productDal.GetProductDetails());
        }
    }
}
