using GerenciadorBiblioteca.API.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace GerenciadorBiblioteca.API.Persistence
{
    public class GerenciadorBibliotecaDbContext : DbContext
    {
        public GerenciadorBibliotecaDbContext(DbContextOptions<GerenciadorBibliotecaDbContext> options) : base(options)
        {
                        
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>(b =>
            {
                b.HasKey(b => b.Id);


            });

            builder.Entity<Loan>(l =>
            {
                l.HasKey(l => l.Id);


                l.HasOne(l => l.Usuario)
                 .WithMany() 
                 .HasForeignKey(l => l.IdUsuario)
                 .IsRequired();

                l.HasOne(l => l.Livro)
                 .WithMany()
                 .HasForeignKey(l => l.IdLivro)
                 .IsRequired();
            });

            builder.Entity<User>(u =>
            {
                u.HasKey(u => u.Id);

            });

            base.OnModelCreating(builder); 
        }
    }
}
