using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurkiyeBilgi.Models
{
    public class TurkiyeContext : DbContext
    {
        public TurkiyeContext(DbContextOptions<TurkiyeContext> options) : base(options)
        {

        }

        public DbSet<Bolge> Bolgeler { get; set; }

        public DbSet<Sehir> Sehirler { get; set; }
    }
}
