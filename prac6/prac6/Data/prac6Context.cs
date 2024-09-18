using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prac6.Model;

namespace prac6.Data
{
    public class prac6Context : DbContext
    {
        public prac6Context (DbContextOptions<prac6Context> options)
            : base(options)
        {
        }

        public DbSet<prac6.Model.User> User { get; set; } = default!;
    }
}
