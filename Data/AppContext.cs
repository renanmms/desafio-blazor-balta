using desafio.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio.Data;

public class AppContext : DbContext
{
   public AppContext(DbContextOptions<AppContext> opt): base(opt)
   {
       
   }

    public DbSet<IBGE> IBGE { get; set; }

}