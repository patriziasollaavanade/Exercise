using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    public class Storage
    {
        public int totalSpace { get; set; }
        public int spaceOccupied { get; set; }
        Dictionary<string, List<Product>> products = new Dictionary<string, List<Product>>();

        public Storage()
        {
            products = new Dictionary<string, List<Product>>();
            totalSpace = 1000;
            spaceOccupied = 0;
        }

        public void addProduct(Product product)
        {
            int finalProduct = product.size * product.quantity;

            if (finalProduct <= (totalSpace - spaceOccupied))
            {
                spaceOccupied += finalProduct;

                if (products.ContainsKey(product.name))
                {
                    products[product.name].Add(product);
                }
                else
                {
                    products[product.name] = new List<Product> { product };
                }

                Console.WriteLine(product.name + " added to storage!");
            }
            else
            {
                Console.WriteLine("Not enough space to add " + product.name);
            }
        }

        public void listProduct(string productName)
        {
            if (products.ContainsKey(productName))
            {
                List<Product> productList = products[productName];

                if (productList.Count == 0)
                {
                    Console.WriteLine("No products available for the name: " + productName);
                    return;
                }

                foreach (Product p in productList)
                {
                    Console.WriteLine("Name: " + p.name);
                    Console.WriteLine("Size: " + p.size + " mq");
                    Console.WriteLine("Quantity: " + p.quantity);
                    Console.WriteLine("----------------------");
                }
            }
            else
            {
                Console.WriteLine("No products found with the name: " + productName);
            }
        }

        public void listAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products in the storage.");
                return;
            }

            foreach (var entry in products)
            {
                string productName = entry.Key;
                List<Product> productList = entry.Value;

                foreach (Product p in productList)
                {
                    Console.WriteLine("Name: " + p.name);
                    Console.WriteLine("Size: " + p.size + " mq");
                    Console.WriteLine("Quantity: " + p.quantity);
                    Console.WriteLine("----------------------");
                }
            }
        }

        public void checkStorage()
        {
            Console.WriteLine("Total space of storage: " + totalSpace + " mq");
            Console.WriteLine("Space occupied: " + spaceOccupied + " mq");
            Console.WriteLine("Available space: " + (totalSpace - spaceOccupied) + " mq");
        }

        public void removeProduct(Product product)
        {
            
            if (products.ContainsKey(product.name))
            {
                List<Product> productList = products[product.name];

              
                if (productList.Contains(product))
                {
                    spaceOccupied -= product.size * product.quantity;
                    productList.Remove(product);

                   
                    if (productList.Count == 0)
                    {
                        products.Remove(product.name);
                    }

                    Console.WriteLine(product.name + " removed from storage!");
                }
                else
                {
                    Console.WriteLine("Product not found in storage.");
                }
            }
            else
            {
                Console.WriteLine("Product not found in storage.");
            }
        }
    }
    }
