﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
               new Product { Id = 1, Name = "Kalem 1", CategoryId = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now },
               new Product { Id = 2, Name = "Kalem 2", CategoryId = 1, Price = 200, Stock = 24, CreatedDate = DateTime.Now },
               new Product { Id = 3, Name = "Kalem 3", CategoryId = 1, Price = 30, Stock = 30, CreatedDate = DateTime.Now },
               new Product { Id = 4, Name = "Kitap 1", CategoryId = 2, Price = 100, Stock = 20, CreatedDate = DateTime.Now },
               new Product { Id = 5, Name = "Kitap 2", CategoryId = 2, Price = 200, Stock = 24, CreatedDate = DateTime.Now },
               new Product { Id = 6, Name = "Kitap 3", CategoryId = 2, Price = 30, Stock = 30, CreatedDate = DateTime.Now },
               new Product { Id = 7, Name = "Defter 1", CategoryId = 3, Price = 30, Stock = 30, CreatedDate = DateTime.Now });


        }
    }

}
