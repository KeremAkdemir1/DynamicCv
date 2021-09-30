using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DymamicCard.Models.Data
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-8PLNS1VS;database=dynamiccard;integrated security=true");
        }
        public DbSet<PersonInfo> personInfos { get; set; }
    }
}
