using Microsoft.EntityFrameworkCore;
using Aldemiti.Dominio;

namespace Aldemiti.Persistencia
{
     public class AppContext : DbContext
     {
         public DbSet<inventario> Inventario {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=Hospital2207208; Data Source=HOMELUNA; Integrated Security=true");
                            //.UseSqlServer("Data Source = (localdb)\\HOMELUNA; Initial Catalog =Hospital2207208");  
                            //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =Hospital2207208");
          
                        /*
                        initial catalog: nombre de la base de datos
                        data source: nombre del servidor de la base de datos
                        integrated security: seguridad con la misma configuracion del inicio de sesion
                        */
            }
        }
     }
}