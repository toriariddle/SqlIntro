﻿using System;
using System.Configuration;

namespace SqlIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
            var repo = new ProductRepository(connectionString);

            Product product = null;

            foreach (var prod in repo.GetProducts())
            {
                if (product == null)
                {
                    product = prod;
                }

                Console.WriteLine("Product Name:" + prod.Name);
            }

            repo.DeleteProduct(3);

            if (product != null)
            {
                product.Name = "Cody's Lame Product";
                repo.UpdateProduct(product);
            }


            Console.ReadLine();
        }


    }
}
