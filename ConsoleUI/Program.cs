// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;

Console.WriteLine("Hello, World!");

ProductManager productManager = new ProductManager(new EfProductDal());
var result = productManager.GetProductDetails();
if (result.Success)
{
    foreach (var product in result.Data)
    {
        Console.WriteLine(product.ProductName + "---" + product.CategoryName);
    }
}
else
{
    Console.WriteLine(result.Message);
}



//OrderManager orderManager=new OrderManager(new EfOrderDal());
//foreach (var order in orderManager.GetAll())
//{
//    Console.WriteLine(order.ShipCity);
//}
