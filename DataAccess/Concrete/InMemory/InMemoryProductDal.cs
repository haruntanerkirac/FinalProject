﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Database
            _products = new List<Product> { 
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductId = 2, CategoryId = 2, ProductName = "Kılıf", UnitPrice = 50, UnitsInStock = 5},
                new Product{ProductId = 3, CategoryId = 3, ProductName = "Telefon", UnitPrice = 6050, UnitsInStock = 10},
                new Product{ProductId = 4, CategoryId = 3, ProductName = "Kamera", UnitPrice = 10050, UnitsInStock = 10},
                new Product{ProductId = 5, CategoryId = 3, ProductName = "Kulaklık", UnitPrice = 1550, UnitsInStock = 20},
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
