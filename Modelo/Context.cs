using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Seguridad;
namespace Modelo
{
    public class Context:DbContext
    {
        private static Context instancia;
        public static Context Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Context();
                    return instancia;
            }
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<PermisoGrupo> PermisoGrupos { get; set; }
        //public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<CarritoDeCompra> CarritoDeCompras { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<EstadoPedido> EstadoPedidos { get; set; }
        public DbSet<MetodoDePago> MetodoDePagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgroGestion;
             Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;
             Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermisoComponent>()
                        .HasDiscriminator<string>("TipoPermiso")
                        .HasValue<Permiso>("Permiso")
                        .HasValue<PermisoGrupo>("PermisoGrupo");

            base.OnModelCreating(modelBuilder);
        }

    }
}
