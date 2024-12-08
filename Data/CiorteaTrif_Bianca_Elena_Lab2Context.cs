using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CiorteaTrif_Bianca_Elena_Lab2.Models;

namespace CiorteaTrif_Bianca_Elena_Lab2.Data
{
    public class CiorteaTrif_Bianca_Elena_Lab2Context : DbContext
    {
        public CiorteaTrif_Bianca_Elena_Lab2Context (DbContextOptions<CiorteaTrif_Bianca_Elena_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<CiorteaTrif_Bianca_Elena_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<CiorteaTrif_Bianca_Elena_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<CiorteaTrif_Bianca_Elena_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<CiorteaTrif_Bianca_Elena_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
