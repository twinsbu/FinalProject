// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//DTOs (Data Transformation Object) -> taşıyacağımız objeler
ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());


    var result = productManager.GetProductDetails();

    //başarıylıysa, bunu foreach ile gez Result'ın datasını gez yani.
    if (result.Success)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    //başarılı değilse,
    else 
    {
        Console.WriteLine(result.Message);
    }
    
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}
//DTO 
