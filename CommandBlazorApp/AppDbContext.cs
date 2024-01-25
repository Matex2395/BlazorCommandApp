using CommandBlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace CommandBlazorApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>().HasData(

                new Libro
                {
                    Id = 1,
                    Titulo = "Misery",
                    Autor = "Stephen King",
                },

                new Libro
                {
                    Id = 2,
                    Titulo = "The Maze Runner",
                    Autor = "Dan Wells"
                }


                ) ; ;
            ;
        }
    }
}
