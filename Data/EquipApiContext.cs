using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EquipApi.Models;

namespace EquipApi.Data
{
    public class EquipApiContext : DbContext
    {
        public EquipApiContext (DbContextOptions<EquipApiContext> options)
            : base(options)
        {
        }
        public DbSet<EquipApi.Models.User> User { get; set; }
    }
}
