﻿using StoreDotNetCoreAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace StoreDotNetCoreAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Sony Ultra Headphones",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 400,
                    PictureUrl = "/images/products/headphones.png",
                    Brand = "Sony",
                    Type = "Headphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sony LE Pro Headphones",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 600,
                    PictureUrl = "/images/products/headphones.png",
                    Brand = "Sony",
                    Type = "Headphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Apple Pro Headphones",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 275,
                    PictureUrl = "/images/products/headphones.png",
                    Brand = "Apple",
                    Type = "Headphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Apple Max Headphones",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 650,
                    PictureUrl = "/images/products/headphones.png",
                    Brand = "Apple",
                    Type = "Headphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung HQ Headphones",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 125,
                    PictureUrl = "/images/products/headphones.png",
                    Brand = "Samsung",
                    Type = "Headphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Asus LB Headphones",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 65,
                    PictureUrl = "/images/products/headphones.png",
                    Brand = "Asus",
                    Type = "Headphones",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Apple Pro Laptop",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/laptop.png",
                    Brand = "Apple",
                    Type = "Laptop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Crystal Laptop",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 3000,
                    PictureUrl = "/images/products/laptop.png",
                    Brand = "Samsung",
                    Type = "Laptop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Ultra Laptop",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/laptop.png",
                    Brand = "Samsung",
                    Type = "Laptop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nvidia Shield Television",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2000,
                    PictureUrl = "/images/products/television.png",
                    Brand = "Nvidia",
                    Type = "Televisions",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nvidia Liquid Display Television",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/television.png",
                    Brand = "Nvidia",
                    Type = "Televisions",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung UW Television",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/television.png",
                    Brand = "Samsung",
                    Type = "Televisions",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Superbowl Edition Television",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 15000,
                    PictureUrl = "/images/products/television.png",
                    Brand = "Samsung",
                    Type = "Televisions",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "AMD RX 7000 Graphics Card",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 900,
                    PictureUrl = "/images/products/graphicscard.png",
                    Brand = "Amd",
                    Type = "Graphics Cards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nvidia RTX 4080 Graphics Card",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/graphicscard.png",
                    Brand = "Nvidia",
                    Type = "Graphics Cards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nvidia RTX 5080 Graphics Card",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 2000,
                    PictureUrl = "/images/products/graphicscard.png",
                    Brand = "Nvidia",
                    Type = "Graphics Cards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nvidia RTX 6080 Graphics Card",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 3500,
                    PictureUrl = "/images/products/graphicscard.png",
                    Brand = "Nvidia",
                    Type = "Graphics Cards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nvidia RTX 7090 Graphics Card",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 5000,
                    PictureUrl = "/images/products/graphicscard.png",
                    Brand = "Nvidia",
                    Type = "Graphics Cards",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
                context.Products.Add(product);

            context.SaveChanges();
        }
    }
}
