using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipApi.Models
{
    public class EquipContext : DbContext
    {
        public EquipContext(DbContextOptions<EquipContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
