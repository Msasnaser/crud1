using crud.Context;
using crud.model;

namespace crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            /* Order order = new Order()
                {

                    Address = "Tulkarm",
                    CreatedAt = DateTime.Now,
                };


              Product product = new Product()
                {
                    Name = "Product 3",
                    Price = 99.99M
                };

               dbContext.orders.Add(order);
                dbContext.products.Add(product);
            //dbContext.SaveChanges();
    */
            // Get all products
            /*  var products = dbContext.products.ToList();
               foreach (var product in products)
               {
                   Console.WriteLine($"Product ID: {product.Id}, ProductName: {product.Name}, Price: {product.Price}");
               }

               // Get all orders
               var orders = dbContext.orders.ToList();
               foreach (var order in orders)
               {
                   Console.WriteLine($"Order ID: {order.Id}, Address: {order.Address}, Created At: {order.CreatedAt}");
               }
   */
            /* var product = dbContext.products.FirstOrDefault(prod => prod.Id == 1);
             if (product != null)
             {
                 product.Name = "Rice";
                 dbContext.SaveChanges();
             }*/

            /*  var orders = dbContext.orders.FirstOrDefault(order => order.Id == 1);

               if(orders is not null)
               {
                   orders.CreatedAt = DateTime.Now; 
                   dbContext.SaveChanges();
               }*/

         /*   var product = dbContext.products.FirstOrDefault(prod => prod.Id == 2);
            if (product != null)
            {
                dbContext.products.Remove(product);
                dbContext.SaveChanges();
            }
*/
            var orders = dbContext.orders.FirstOrDefault(order => order.Id == 3);

            if (orders is not null)
            {
                dbContext.orders.Remove(orders);
                dbContext.SaveChanges();
            }

        }
    }
}
