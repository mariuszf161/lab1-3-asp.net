﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetApp.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly AppDbContext ctx;
        public EFProductRepository(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IQueryable<Product> Products => ctx.Products;

        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                ctx.Products.Add(product);
            }
            else
            {
                Product dbEntry = ctx.Products
                    .FirstOrDefault(product => product.ProductID == product.ProductID);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            ctx.SaveChanges();
        }
        public Product DelateProduct(int productID)
        {
            Product dbEntry = ctx.Products
                .FirstOrDefault(p => p.ProductID == productID);
            if (dbEntry != null)
            {
                ctx.Products.Remove(dbEntry);
                ctx.SaveChanges();
            }
            return dbEntry;
        }
    }

}
