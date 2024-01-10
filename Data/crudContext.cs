using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crud.Model;

namespace crud.Data
{
    public class crudContext : DbContext
    {
        public crudContext (DbContextOptions<crudContext> options)
            : base(options)
        {
        }

        public DbSet<crud.Model.User> User { get; set; } = default!;
    }
}
