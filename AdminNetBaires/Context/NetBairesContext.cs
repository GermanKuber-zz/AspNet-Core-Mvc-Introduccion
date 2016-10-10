using AdminNetBaires.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminNetBaires.Context
{
    //TODO : Paso 2 - Creo mi contexto
    public class NetBairesContext: DbContext
    {
        //TODO : Paso 3 - Agrego nuevas entidades y genero relaciones
        //public DbSet<Event> Events { get; set; }
        //public DbSet<Talk> Talks { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=OdeToFood");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Member>()
            //.HasMany(p => p.Events);

            //builder.Entity<Member>()
            //.HasMany(p => p.Talks);

           // builder.Entity<Event>()
           //.HasMany(p => p.Organizers);

           // builder.Entity<Talk>()
           // .HasMany(p => p.Speakers);
        }
    }
}
