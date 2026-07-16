using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistance
{
    public static class DreamStreamDbContextFactory<TContext> where TContext : DbContext, new()
    {
        public static TContext CreateDbContext()
        {
            return new TContext();
        }
    }
}
