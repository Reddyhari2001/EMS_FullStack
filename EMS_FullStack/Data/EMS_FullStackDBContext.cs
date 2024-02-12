using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS_FullStack.Models;

namespace EMS_FullStack.Data
{
    public class EMS_FullStackDBContext : DbContext
    {
        public EMS_FullStackDBContext (DbContextOptions<EMS_FullStackDBContext> options)
            : base(options)
        {
        }

        public DbSet<EMS_FullStack.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
