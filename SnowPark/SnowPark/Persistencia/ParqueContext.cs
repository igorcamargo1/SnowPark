using Microsoft.EntityFrameworkCore;
using SnowPark.Models;

namespace SnowPark.Persistencia;

//Classe que gerencia as entidades
public class ParqueContext : DbContext
{
    public DbSet<Compra> Compras { get; set; }

    public ParqueContext(DbContextOptions op) : base(op) { }


}
