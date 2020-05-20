using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLbWebs.Models;

namespace ApiLbWebs.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<LBAcces> LBAcces { get; set; }
        public DbSet<LBMail> LBMail { get; set; }
        public DbSet<clidev> clidev { get; set; }
        public DbSet<cliftp> cliftp { get; set; }
        public DbSet<clihos> clihos { get; set; }
        public DbSet<clilb> clilb { get; set; }
        public DbSet<prediscli> prediscli { get; set; }
    }
}
