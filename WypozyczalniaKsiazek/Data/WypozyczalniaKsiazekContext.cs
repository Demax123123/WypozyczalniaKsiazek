using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WypozyczalniaKsiazek.Models;

namespace WypozyczalniaKsiazek.Data
{
    public class WypozyczalniaKsiazekContext : DbContext
    {
        public WypozyczalniaKsiazekContext (DbContextOptions<WypozyczalniaKsiazekContext> options)
            : base(options)
        {
        }

        public DbSet<WypozyczalniaKsiazek.Models.Book> Book { get; set; } = default!;
    }
}
