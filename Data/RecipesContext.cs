using Microsoft.EntityFrameworkCore;
using RecipesAPI.Models;

namespace RecipesAPI.Data
{
    public class RecipesContext: DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Recipe>? Recipes { get; set; }

        //TODO: Conexion con la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
        }

    }

}