﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Seguridad;
using Entidades.EntidadesClientes;
using Entidades.EntidadesVenta;
using Entidades.EntidadesVendedores;
using Entidades.Seguridad2;
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
    

       
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<CarritoDeCompra> CarritoDeCompras { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<MetodoDePago> MetodoDePagos { get; set; }

        //Seguridad
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Accion> Acciones { get; set; }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<EstadoUsuario> EstadosUsuario { get; set; }
        public DbSet<EstadoGrupo> EstadosGrupo { get; set; }

        //Auditorias
        public DbSet<AuditoriaProducto> AuditoriasProductos { get; set; }
        public DbSet<AuditoriaSesion> AuditoriasSesiones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgroGestion;
             Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;
             Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        

            // Relación Publicacion -> Producto
            modelBuilder.Entity<Publicacion>()
                .HasOne(p => p.Producto)
                .WithMany()
                .HasForeignKey(p=> p.IdProducto)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Publicacion -> Vendedor
            modelBuilder.Entity<Publicacion>()
                .HasOne(p => p.Vendedor)
                .WithMany()
                .HasForeignKey(p => p.idVendedor)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Producto -> Vendedor
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Vendedor)
                .WithMany()
                .HasForeignKey(p => p.idVendedor)
                .OnDelete(DeleteBehavior.Restrict);
            // Relación Pedido -> Cliente
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.idCliente)
                .OnDelete(DeleteBehavior.Restrict); 

            // Relación Pedido -> Vendedor
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Vendedor)
                .WithMany()
                .HasForeignKey(p => p.idVendedor)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación Pedido -> CarritoDeCompra
            /*modelBuilder.Entity<Pedido>()
                .HasOne(p => p.CarritoDeCompra)
                .WithMany()
                .HasForeignKey(p => p.idCliente)
                .OnDelete(DeleteBehavior.Restrict);*/

         
            // Configuración adicional para Pago
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Pago)
                .WithOne(p => p.Pedido)
                .HasForeignKey<Pago>(p => p.PedidoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Grupo>().HasMany(g => g.Componentes).WithMany(c => c.Grupos).UsingEntity<Dictionary<string, object>>(
                "ComponenteGrupo",
                j => j
                    .HasOne<Componente>()
                    .WithMany()
                    .HasForeignKey("ComponentesId")
                    .OnDelete(DeleteBehavior.Restrict),
                j => j
                    .HasOne<Grupo>()
                    .WithMany()
                    .HasForeignKey("GruposId")
                    .OnDelete(DeleteBehavior.Restrict));
        }

    }
}
