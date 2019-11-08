using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;


namespace Cook_Share.Models
{
    public class DataContext : DbContext
    {
       public DbSet<User> Users { get; set;}

        public DbSet<Subscribers> Subscribers  { get; set;}

        public DbSet<Subscriptions> Subscriptions{ get; set;}

        public DbSet<Publication> Publications{ get; set;}

        public DbSet<Favourites> Favourites { get; set;}

        public DbSet<Dish> Dishes{ get; set;}

        public DbSet<Comment> Comments{ get; set;}

        public DbSet<Category> Categories{ get; set;}

        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

            Database.EnsureCreated();
            
        }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.SetNull;
            }
        }
}

 

}

