using System;
using System.Collections.Generic;
using System.Data.Entity;
using OnionApp.Domain.Core;

namespace OnionApp.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
