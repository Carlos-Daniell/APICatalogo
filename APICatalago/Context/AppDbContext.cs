using APICatalago.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace APICatalago.Context;

public class AppDbContext : DbContext {

    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

    }

}

