using Microsoft.EntityFrameworkCore;
using Aldemiti.Dominio;

namespace Aldemiti.Persistencia
{
     public class AppContext : DbContext
     {
         public DbSet<inventario> Inventario {get; set;}
         

     }
}