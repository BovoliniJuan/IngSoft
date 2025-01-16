using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoPedidos",
                columns: table => new
                {
                    IdEstadoPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPedidos", x => x.IdEstadoPedido);
                });

            migrationBuilder.CreateTable(
                name: "EstadosGrupo",
                columns: table => new
                {
                    EstadoGrupoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoGrupoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosGrupo", x => x.EstadoGrupoId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosUsuario",
                columns: table => new
                {
                    EstadoUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoUsuarioNombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosUsuario", x => x.EstadoUsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "MetodoDePagos",
                columns: table => new
                {
                    IdMetodoDePago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoDePagos", x => x.IdMetodoDePago);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    ModuloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreModulo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.ModuloId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoUsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_EstadosUsuario_EstadoUsuarioId",
                        column: x => x.EstadoUsuarioId,
                        principalTable: "EstadosUsuario",
                        principalColumn: "EstadoUsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    FormularioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreFormulario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.FormularioId);
                    table.ForeignKey(
                        name: "FK_Formularios_Modulos_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulos",
                        principalColumn: "ModuloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefono = table.Column<long>(type: "bigint", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    IdVendedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoEmpresa = table.Column<long>(type: "bigint", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.IdVendedor);
                    table.ForeignKey(
                        name: "FK_Vendedores_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Componente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdGrupo = table.Column<int>(type: "int", nullable: true),
                    NombreGrupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoGrupoId = table.Column<int>(type: "int", nullable: true),
                    FormularioId = table.Column<int>(type: "int", nullable: true),
                    GrupoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Componente_Componente_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Componente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Componente_EstadosGrupo_EstadoGrupoId",
                        column: x => x.EstadoGrupoId,
                        principalTable: "EstadosGrupo",
                        principalColumn: "EstadoGrupoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Componente_Formularios_FormularioId",
                        column: x => x.FormularioId,
                        principalTable: "Formularios",
                        principalColumn: "FormularioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarritoDeCompras",
                columns: table => new
                {
                    IdCarritoDeCompras = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoDeCompras", x => x.IdCarritoDeCompras);
                    table.ForeignKey(
                        name: "FK_CarritoDeCompras_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    VendedorIdPersona = table.Column<int>(type: "int", nullable: false),
                    VendedorIdVendedor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Vendedores_VendedorIdPersona",
                        column: x => x.VendedorIdPersona,
                        principalTable: "Vendedores",
                        principalColumn: "IdVendedor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Vendedores_VendedorIdVendedor",
                        column: x => x.VendedorIdVendedor,
                        principalTable: "Vendedores",
                        principalColumn: "IdVendedor");
                });

            migrationBuilder.CreateTable(
                name: "ComponenteGrupo",
                columns: table => new
                {
                    ComponentesId = table.Column<int>(type: "int", nullable: false),
                    GruposId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponenteGrupo", x => new { x.ComponentesId, x.GruposId });
                    table.ForeignKey(
                        name: "FK_ComponenteGrupo_Componente_ComponentesId",
                        column: x => x.ComponentesId,
                        principalTable: "Componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComponenteGrupo_Componente_GruposId",
                        column: x => x.GruposId,
                        principalTable: "Componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComponenteUsuario",
                columns: table => new
                {
                    ComponentesId = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponenteUsuario", x => new { x.ComponentesId, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_ComponenteUsuario_Componente_ComponentesId",
                        column: x => x.ComponentesId,
                        principalTable: "Componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponenteUsuario_Usuarios_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteIdPersona = table.Column<int>(type: "int", nullable: false),
                    CarritoDeCompraIdCarritoDeCompras = table.Column<int>(type: "int", nullable: false),
                    EstadoPedidoIdEstadoPedido = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    VendedorIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_CarritoDeCompras_CarritoDeCompraIdCarritoDeCompras",
                        column: x => x.CarritoDeCompraIdCarritoDeCompras,
                        principalTable: "CarritoDeCompras",
                        principalColumn: "IdCarritoDeCompras",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteIdPersona",
                        column: x => x.ClienteIdPersona,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_EstadoPedidos_EstadoPedidoIdEstadoPedido",
                        column: x => x.EstadoPedidoIdEstadoPedido,
                        principalTable: "EstadoPedidos",
                        principalColumn: "IdEstadoPedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Vendedores_VendedorIdPersona",
                        column: x => x.VendedorIdPersona,
                        principalTable: "Vendedores",
                        principalColumn: "IdVendedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    IdPublicacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    VendedorIdPersona = table.Column<int>(type: "int", nullable: false),
                    CarritoDeCompraIdCarritoDeCompras = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.IdPublicacion);
                    table.ForeignKey(
                        name: "FK_Publicaciones_CarritoDeCompras_CarritoDeCompraIdCarritoDeCompras",
                        column: x => x.CarritoDeCompraIdCarritoDeCompras,
                        principalTable: "CarritoDeCompras",
                        principalColumn: "IdCarritoDeCompras");
                    table.ForeignKey(
                        name: "FK_Publicaciones_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Vendedores_VendedorIdPersona",
                        column: x => x.VendedorIdPersona,
                        principalTable: "Vendedores",
                        principalColumn: "IdVendedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    MetodoDePagoIdMetodoDePago = table.Column<int>(type: "int", nullable: false),
                    EstadoPago = table.Column<bool>(type: "bit", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: false),
                    ReferenciaTransaccion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pagos_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_MetodoDePagos_MetodoDePagoIdMetodoDePago",
                        column: x => x.MetodoDePagoIdMetodoDePago,
                        principalTable: "MetodoDePagos",
                        principalColumn: "IdMetodoDePago",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarritoDeCompras_ClienteIdCliente",
                table: "CarritoDeCompras",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UsuarioIdUsuario",
                table: "Clientes",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Componente_EstadoGrupoId",
                table: "Componente",
                column: "EstadoGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Componente_FormularioId",
                table: "Componente",
                column: "FormularioId");

            migrationBuilder.CreateIndex(
                name: "IX_Componente_GrupoId",
                table: "Componente",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponenteGrupo_GruposId",
                table: "ComponenteGrupo",
                column: "GruposId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponenteUsuario_UsuariosIdUsuario",
                table: "ComponenteUsuario",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Formularios_ModuloId",
                table: "Formularios",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ClienteIdCliente",
                table: "Pagos",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_MetodoDePagoIdMetodoDePago",
                table: "Pagos",
                column: "MetodoDePagoIdMetodoDePago");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_PedidoId",
                table: "Pagos",
                column: "PedidoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CarritoDeCompraIdCarritoDeCompras",
                table: "Pedidos",
                column: "CarritoDeCompraIdCarritoDeCompras");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteIdPersona",
                table: "Pedidos",
                column: "ClienteIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EstadoPedidoIdEstadoPedido",
                table: "Pedidos",
                column: "EstadoPedidoIdEstadoPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_VendedorIdPersona",
                table: "Pedidos",
                column: "VendedorIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_VendedorIdPersona",
                table: "Productos",
                column: "VendedorIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_VendedorIdVendedor",
                table: "Productos",
                column: "VendedorIdVendedor");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_CarritoDeCompraIdCarritoDeCompras",
                table: "Publicaciones",
                column: "CarritoDeCompraIdCarritoDeCompras");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdProducto",
                table: "Publicaciones",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_VendedorIdPersona",
                table: "Publicaciones",
                column: "VendedorIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EstadoUsuarioId",
                table: "Usuarios",
                column: "EstadoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_UsuarioIdUsuario",
                table: "Vendedores",
                column: "UsuarioIdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponenteGrupo");

            migrationBuilder.DropTable(
                name: "ComponenteUsuario");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Componente");

            migrationBuilder.DropTable(
                name: "MetodoDePagos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "EstadosGrupo");

            migrationBuilder.DropTable(
                name: "Formularios");

            migrationBuilder.DropTable(
                name: "CarritoDeCompras");

            migrationBuilder.DropTable(
                name: "EstadoPedidos");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "EstadosUsuario");
        }
    }
}
