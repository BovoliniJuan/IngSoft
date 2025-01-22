﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250122175221_cambio")]
    partial class cambio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ComponenteGrupo", b =>
                {
                    b.Property<int>("ComponentesId")
                        .HasColumnType("int");

                    b.Property<int>("GruposId")
                        .HasColumnType("int");

                    b.HasKey("ComponentesId", "GruposId");

                    b.HasIndex("GruposId");

                    b.ToTable("ComponenteGrupo");
                });

            modelBuilder.Entity("ComponenteUsuario", b =>
                {
                    b.Property<int>("ComponentesId")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("ComponentesId", "UsuariosIdUsuario");

                    b.HasIndex("UsuariosIdUsuario");

                    b.ToTable("ComponenteUsuario");
                });

            modelBuilder.Entity("Entidades.EntidadesClientes.CarritoDeCompra", b =>
                {
                    b.Property<int>("IdCarritoDeCompras")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarritoDeCompras"));

                    b.Property<int>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("IdCarritoDeCompras");

                    b.HasIndex("ClienteIdCliente");

                    b.ToTable("CarritoDeCompras");
                });

            modelBuilder.Entity("Entidades.EntidadesClientes.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefono")
                        .HasColumnType("bigint");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdCliente");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Entidades.EntidadesVendedores.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<int?>("VendedorIdVendedor")
                        .HasColumnType("int");

                    b.Property<int>("idVendedor")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.HasIndex("VendedorIdVendedor");

                    b.HasIndex("idVendedor");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Entidades.EntidadesVendedores.Publicacion", b =>
                {
                    b.Property<int>("IdPublicacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPublicacion"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("CarritoDeCompraIdCarritoDeCompras")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<bool>("Vendido")
                        .HasColumnType("bit");

                    b.Property<int>("idVendedor")
                        .HasColumnType("int");

                    b.HasKey("IdPublicacion");

                    b.HasIndex("CarritoDeCompraIdCarritoDeCompras");

                    b.HasIndex("IdProducto");

                    b.HasIndex("idVendedor");

                    b.ToTable("Publicaciones");
                });

            modelBuilder.Entity("Entidades.EntidadesVendedores.Vendedor", b =>
                {
                    b.Property<int>("IdVendedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVendedor"));

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TelefonoEmpresa")
                        .HasColumnType("bigint");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdVendedor");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Entidades.EntidadesVenta.MetodoDePago", b =>
                {
                    b.Property<int>("IdMetodoDePago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMetodoDePago"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMetodoDePago");

                    b.ToTable("MetodoDePagos");
                });

            modelBuilder.Entity("Entidades.EntidadesVenta.Pago", b =>
                {
                    b.Property<int>("IdPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPago"));

                    b.Property<int>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<bool>("EstadoPago")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<int>("MetodoDePagoIdMetodoDePago")
                        .HasColumnType("int");

                    b.Property<float>("Monto")
                        .HasColumnType("real");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ReferenciaTransaccion")
                        .HasColumnType("int");

                    b.HasKey("IdPago");

                    b.HasIndex("ClienteIdCliente");

                    b.HasIndex("MetodoDePagoIdMetodoDePago");

                    b.HasIndex("PedidoId")
                        .IsUnique();

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Entidades.EntidadesVenta.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("datetime2");

                    b.Property<int>("PublicacionIdPublicacion")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.Property<int>("idVendedor")
                        .HasColumnType("int");

                    b.HasKey("IdPedido");

                    b.HasIndex("PublicacionIdPublicacion");

                    b.HasIndex("idCliente");

                    b.HasIndex("idVendedor");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Entidades.Seguridad.EstadoUsuario", b =>
                {
                    b.Property<int>("EstadoUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoUsuarioId"));

                    b.Property<string>("EstadoUsuarioNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoUsuarioId");

                    b.ToTable("EstadosUsuario");
                });

            modelBuilder.Entity("Entidades.Seguridad2.Componente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Componente");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Componente");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Entidades.Seguridad2.EstadoGrupo", b =>
                {
                    b.Property<int>("EstadoGrupoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoGrupoId"));

                    b.Property<string>("EstadoGrupoNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoGrupoId");

                    b.ToTable("EstadosGrupo");
                });

            modelBuilder.Entity("Entidades.Seguridad2.Formulario", b =>
                {
                    b.Property<int>("FormularioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormularioId"));

                    b.Property<int>("ModuloId")
                        .HasColumnType("int");

                    b.Property<string>("NombreFormulario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormularioId");

                    b.HasIndex("ModuloId");

                    b.ToTable("Formularios");
                });

            modelBuilder.Entity("Entidades.Seguridad2.Modulo", b =>
                {
                    b.Property<int>("ModuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModuloId"));

                    b.Property<string>("NombreModulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuloId");

                    b.ToTable("Modulos");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("EstadoUsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Entidades.Grupo", b =>
                {
                    b.HasBaseType("Entidades.Seguridad2.Componente");

                    b.Property<int>("EstadoGrupoId")
                        .HasColumnType("int");

                    b.Property<int>("IdGrupo")
                        .HasColumnType("int");

                    b.HasIndex("EstadoGrupoId");

                    b.HasDiscriminator().HasValue("Grupo");
                });

            modelBuilder.Entity("Entidades.Seguridad2.Accion", b =>
                {
                    b.HasBaseType("Entidades.Seguridad2.Componente");

                    b.Property<int>("FormularioId")
                        .HasColumnType("int");

                    b.Property<int?>("GrupoId")
                        .HasColumnType("int");

                    b.HasIndex("FormularioId");

                    b.HasIndex("GrupoId");

                    b.HasDiscriminator().HasValue("Accion");
                });

            modelBuilder.Entity("ComponenteGrupo", b =>
                {
                    b.HasOne("Entidades.Seguridad2.Componente", null)
                        .WithMany()
                        .HasForeignKey("ComponentesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entidades.Grupo", null)
                        .WithMany()
                        .HasForeignKey("GruposId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponenteUsuario", b =>
                {
                    b.HasOne("Entidades.Seguridad2.Componente", null)
                        .WithMany()
                        .HasForeignKey("ComponentesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.EntidadesClientes.CarritoDeCompra", b =>
                {
                    b.HasOne("Entidades.EntidadesClientes.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteIdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Entidades.EntidadesClientes.Cliente", b =>
                {
                    b.HasOne("Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Entidades.EntidadesVendedores.Producto", b =>
                {
                    b.HasOne("Entidades.EntidadesVendedores.Vendedor", null)
                        .WithMany("Productos")
                        .HasForeignKey("VendedorIdVendedor");

                    b.HasOne("Entidades.EntidadesVendedores.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("idVendedor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Entidades.EntidadesVendedores.Publicacion", b =>
                {
                    b.HasOne("Entidades.EntidadesClientes.CarritoDeCompra", null)
                        .WithMany("Publicaciones")
                        .HasForeignKey("CarritoDeCompraIdCarritoDeCompras");

                    b.HasOne("Entidades.EntidadesVendedores.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entidades.EntidadesVendedores.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("idVendedor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Entidades.EntidadesVendedores.Vendedor", b =>
                {
                    b.HasOne("Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Entidades.EntidadesVenta.Pago", b =>
                {
                    b.HasOne("Entidades.EntidadesClientes.Cliente", "Cliente")
                        .WithMany("Pagos")
                        .HasForeignKey("ClienteIdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.EntidadesVenta.MetodoDePago", "MetodoDePago")
                        .WithMany()
                        .HasForeignKey("MetodoDePagoIdMetodoDePago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.EntidadesVenta.Pedido", "Pedido")
                        .WithOne("Pago")
                        .HasForeignKey("Entidades.EntidadesVenta.Pago", "PedidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("MetodoDePago");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Entidades.EntidadesVenta.Pedido", b =>
                {
                    b.HasOne("Entidades.EntidadesVendedores.Publicacion", "Publicacion")
                        .WithMany()
                        .HasForeignKey("PublicacionIdPublicacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.EntidadesClientes.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("idCliente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entidades.EntidadesVendedores.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("idVendedor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Publicacion");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Entidades.Seguridad2.Formulario", b =>
                {
                    b.HasOne("Entidades.Seguridad2.Modulo", "Modulo")
                        .WithMany()
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modulo");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.HasOne("Entidades.Seguridad.EstadoUsuario", "EstadoUsuario")
                        .WithMany()
                        .HasForeignKey("EstadoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoUsuario");
                });

            modelBuilder.Entity("Entidades.Grupo", b =>
                {
                    b.HasOne("Entidades.Seguridad2.EstadoGrupo", "EstadoGrupo")
                        .WithMany()
                        .HasForeignKey("EstadoGrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoGrupo");
                });

            modelBuilder.Entity("Entidades.Seguridad2.Accion", b =>
                {
                    b.HasOne("Entidades.Seguridad2.Formulario", "Formulario")
                        .WithMany("AccionesPosibles")
                        .HasForeignKey("FormularioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Grupo", null)
                        .WithMany("Acciones")
                        .HasForeignKey("GrupoId");

                    b.Navigation("Formulario");
                });

            modelBuilder.Entity("Entidades.EntidadesClientes.CarritoDeCompra", b =>
                {
                    b.Navigation("Publicaciones");
                });

            modelBuilder.Entity("Entidades.EntidadesClientes.Cliente", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Entidades.EntidadesVendedores.Vendedor", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Entidades.EntidadesVenta.Pedido", b =>
                {
                    b.Navigation("Pago")
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.Seguridad2.Formulario", b =>
                {
                    b.Navigation("AccionesPosibles");
                });

            modelBuilder.Entity("Entidades.Grupo", b =>
                {
                    b.Navigation("Acciones");
                });
#pragma warning restore 612, 618
        }
    }
}
