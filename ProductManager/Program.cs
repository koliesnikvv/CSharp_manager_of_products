using System;
using System.Linq;
using System.Text;
using StorageClasses;
using CalculationClasses;
using ServicesClasses;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set encoding to UTF8 for proper character rendering
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Inventory Management System v1.0";
            IStorageInit storageInit = new StarterStorage(); 
            IDataService dataService = new ProcessingStorage(storageInit);
            var depositaries = dataService.GetDepositaryStorages();
            var allProducts = dataService.GetProducts();

            PrintHeader(depositaries.Count);
          
            // 1. Linking Logic: Assigning products to their respective storages in memory
            // This populates the Products list inside each DepositaryStorage object
            foreach (var storage in depositaries)
            {
                // Filter products where DepositaryId matches current storage Id
                var relatedProducts = dataService.GetProductsByDepositaryId(storage.Id);
                storage.Products = relatedProducts;
            }

            // 2. Data Visualization
            if (!depositaries.Any())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" [!] Error: No storage data found in the system.");
                Console.ResetColor();
            }

            foreach (var storage in depositaries)
            {
                var depCalc = new DepositaryCalculations(storage);

                // Displaying Storage Location Header
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(depCalc.GetStorageHeader());
                Console.ResetColor();

                // Table Header
                Console.WriteLine(new string('═', 85));
                Console.WriteLine($" {"ID",-4} | {"Product Name",-30} | {"Category",-12} | {"Price",-10} | {"Qty",-5}");
                Console.WriteLine(new string('─', 85));

                if (!storage.Products.Any())
                {
                    Console.WriteLine("    No products assigned to this location.");
                }
                else
                {
                    foreach (var product in storage.Products)
                    {
                        // Formatted row output with padding for alignment
                        Console.WriteLine($" {product.Id,-4} | {product.Name,-30} | {product.Category,-12} | {product.Price,10:N2} | {product.Amount,-5}");
                    }
                }

                Console.WriteLine(new string('═', 85));

                // Inventory Summary for current storage
                Console.ForegroundColor = ConsoleColor.Yellow;
                decimal total = depCalc.CalculateTotalStockValue();
                Console.WriteLine($" TOTAL INVENTORY VALUE: {total,58:N2} USD");
                Console.ResetColor();
                Console.WriteLine();
            }

            PrintFooter();
        }

        /// Prints the application visual header

        static void PrintHeader(int depositaryCount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
  ╔══════════════════════════════════════════════════════════════════════════╗
  ║                WAREHOUSE INVENTORY CONTROL SYSTEM                        ║
  ╚══════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine($" Date: {DateTime.Now:dd.MM.yyyy HH:mm} | Active Units: {depositaryCount}\n");
        }

        /// Prints the application visual footer and waits for user input
        
        static void PrintFooter()
        {
            Console.WriteLine("\n" + new string('·', 85));
            Console.WriteLine(" Execution finished. Press any key to exit the system...");
            Console.ReadKey();
        }
    }
}