using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Ordering.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Infrastructure
{
    public class AppDbContextFactory: IDesignTimeDbContextFactory<OrderContext>
    {
        OrderContext IDesignTimeDbContextFactory<OrderContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OrderContext>();
            optionsBuilder.UseSqlServer("Server=192.168.3.155;Database=OrderDb;User Id=sa;Password=P@ssw0rd;");

            return new OrderContext(optionsBuilder.Options);
        }
    }
}
