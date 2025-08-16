using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//ProductTest();

//CategoryTest();

//ProductDetailsTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
    foreach (var product in productManager.GetByUnitPrice(50,100).Data) 
    {
        Console.WriteLine(product.ProductName + " | " + product.UnitPrice);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}

static void ProductDetailsTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
    foreach (var product in productManager.GetProductDetails().Data)
    {
        Console.WriteLine(product.ProductName + " | " + product.CategoryName);
    }
}