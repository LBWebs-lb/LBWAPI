using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLbWebs.Models;
using System.Threading;

namespace ApiLbWebs.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            var AddedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Added).ToList();

            AddedEntities.ForEach(E =>
            {
                E.Property("faltrto").CurrentValue = DateTime.Now;
                E.Property("hmod").CurrentValue = DateTime.Now.ToString("HH:mm");
                E.Property("fmod").CurrentValue = DateTime.Now.ToString("dd/M/yyyy");
            });

            var EditedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Modified).ToList();

            EditedEntities.ForEach(E =>
            {
                E.Property("hmod").CurrentValue = DateTime.Now.ToString("HH:mm");
                E.Property("fmod").CurrentValue = DateTime.Now.ToString("dd/M/yyyy");
            });

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public DbSet<LBAcces> LBAcces { get; set; }
        public DbSet<LBMail> LBMail { get; set; }
        public DbSet<clidev> clidev { get; set; }
        public DbSet<cliftp> cliftp { get; set; }
        public DbSet<clihos> clihos { get; set; }
        public DbSet<clilb> clilb { get; set; }
        public DbSet<prediscli> prediscli { get; set; }
        public DbSet<userslb> userslb { get; set; }
        public DbSet<userop> userop { get; set; }
        public DbSet<usermod> usermod { get; set; }
        public DbSet<userrol> userrol { get; set; }
        public DbSet<usrrolop> usrrolop { get; set; }
    }
}
