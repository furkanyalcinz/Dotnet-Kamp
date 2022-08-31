// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductTest();


//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    var result = productManager.GetProductDetails();
    if (result.Success)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.ProductName + "  /  " + item.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
    
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var item in categoryManager.GetAll())
    {
        Console.WriteLine(item.CategoryName);
    }
}