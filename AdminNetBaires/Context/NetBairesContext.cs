using AdminNetBaires.Entities;
using AdminNetBaires.Services;
using Microsoft.EntityFrameworkCore;

namespace AdminNetBaires.Context
{
    //TODO : Paso 2 - Creo mi contexto
    public class NetBairesContext: DbContext
    {
        private readonly IConfigService _configService;
        //TODO : Paso 3 - Agrego nuevas entidades y genero relaciones
        public DbSet<Event> Events { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<Member> Members { get; set; }

  
        public NetBairesContext(IConfigService configService)
        {
            _configService = configService;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO : Paso 8 - Agrego la configuracion database al appsettings.json
            optionsBuilder.UseSqlite(_configService.GetDbConnectionString());
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
