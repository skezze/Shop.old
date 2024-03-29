﻿using Microsoft.EntityFrameworkCore;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.AdminProducts
{
    public class DeleteProduct
    {
        private ApplicationDbContext _context;

        public DeleteProduct(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Do(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

    }
}
