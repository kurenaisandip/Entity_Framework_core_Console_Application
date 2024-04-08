// See https://aka.ms/new-console-template for more information

using Entity_Framework_core_Console_Application.Model;

/// <summary>
    /// The main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            // Perform CRUD operations
            insertProduct();
            readProduct();
            updateProduct();
            deleteProduct();
        }

        /// <summary>
        /// Inserts sample products into the database.
        /// </summary>
        static void insertProduct()
        {
            using (var db = new EFContext())
            {
                Product product = new Product();
                product.Name = "Monitor";
                db.Add(product);

                product = new Product();
                product.Name = "Keyboard";
                db.Add(product);

                db.SaveChanges();
            }
        }

        /// <summary>
        /// Reads and displays all products from the database.
        /// </summary>
        static void readProduct()
        {
            using (var db = new EFContext())
            {
                List<Product> products = db.Products.ToList();
                foreach (var p in products)
                {
                    Console.WriteLine("{0} {1}", p.Id, p.Name);
                }
            }
        }

        /// <summary>
        /// Updates a product in the database.
        /// </summary>
        static void updateProduct()
        {
            using (var db = new EFContext())
            {
                Product product = db.Products.Find(1); // Assuming the product with ID 1 exists
                product.Name = "Mouse";
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes a product from the database.
        /// </summary>
        static void deleteProduct()
        {
            using (var db = new EFContext())
            {
                Product product = db.Products.Find(1); // Assuming the product with ID 1 exists
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
    }
}