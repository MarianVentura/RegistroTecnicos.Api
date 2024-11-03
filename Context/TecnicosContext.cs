using Microsoft.EntityFrameworkCore;
using RegistroTecnicos.Api.Models;
using System.Collections.Generic;

namespace RegistroTecnicos.Api.Context;

public class TecnicosContext : DbContext
{
    public TecnicosContext(DbContextOptions<TecnicosContext> options) : base(options) { }
    public DbSet<Clientes> Clientes { get; set; }
}
