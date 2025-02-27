using Entidades.EntidadesVendedores;
using Entidades.EntidadesVenta;
using Entidades.Seguridad2;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Vendedor
{
    public class ControladoraReportes
    {
        private static ControladoraReportes instancia;


        public static ControladoraReportes Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraReportes();
                }
                return instancia;
            }
        }



        public ControladoraReportes()
        {
        }




        public ReadOnlyCollection<(Producto, int)> RecuperarProductosMasVendidos(Sesion sesion)
        {
         
            var productosVendidos = Context.Instancia.Pedidos
                .OfType<Pedido>()
                .Include(p => p.Publicacion.Producto)
                .Include(p => p.Publicacion.Vendedor) 
                .Where(p =>
                    p.Estado != null &&
                    p.Estado != "Cancelado" &&
                    p.Publicacion.Vendedor.Usuario == sesion.UsuarioSesion) 
                .AsEnumerable()
                .GroupBy(p => p.Publicacion.Producto)
                .Select(grupo => new
                {
                    Producto = grupo.Key,
                    CantidadVendida = grupo.Sum(p => p.Publicacion.Cantidad)
                })
                .OrderByDescending(resultado => resultado.CantidadVendida)
                .ToList();

            return productosVendidos.Select(p => (p.Producto, p.CantidadVendida)).ToList().AsReadOnly();
        }

        public ReadOnlyCollection<(Producto, int)> RecuperarProductosMenosVendidos(Sesion sesion)
        {

            var productosVendidos = Context.Instancia.Pedidos
                .OfType<Pedido>()
                .Include(p => p.Publicacion.Producto)
                .Include(p => p.Publicacion.Vendedor) 
                .Where(p =>
                    p.Estado != null &&
                    p.Estado != "Cancelado" &&
                    p.Publicacion.Vendedor.Usuario == sesion.UsuarioSesion) 
                .AsEnumerable()
                .GroupBy(p => p.Publicacion.Producto)
                .Select(grupo => new
                {
                    Producto = grupo.Key,
                    CantidadVendida = grupo.Sum(p => p.Publicacion.Cantidad)
                })
                .OrderBy(resultado => resultado.CantidadVendida) // Ordenar por cantidad vendida ascendente
                .ToList();

            return productosVendidos.Select(p => (p.Producto, p.CantidadVendida)).ToList().AsReadOnly();
        }

        public ReadOnlyCollection<(Producto, float)> RecuperarProductosMasRentables(Sesion sesion)
        {          

            // Filtrar los pedidos para el vendedor asociado a la sesión y calcular el ingreso total por producto
            var productosRentables = Context.Instancia.Pedidos
                .OfType<Pedido>()
                .Include(p => p.Publicacion.Producto)
                .Include(p => p.Publicacion.Vendedor) 
                .Where(p =>
                    p.Estado != null &&
                    p.Estado != "Cancelado" &&
                    p.Publicacion.Vendedor.Usuario == sesion.UsuarioSesion) // Filtrar por vendedor
                .AsEnumerable()
                .GroupBy(p => p.Publicacion.Producto)
                .Select(grupo => new
                {
                    Producto = grupo.Key,
                    IngresoTotal = grupo.Sum(p => p.Publicacion.Cantidad * p.Publicacion.Precio) // Calcular ingreso total
                })
                .OrderByDescending(resultado => resultado.IngresoTotal) // Ordenar por ingreso total descendente
                .ToList();

            return productosRentables.Select(p => (p.Producto, p.IngresoTotal)).ToList().AsReadOnly();
        }


    }
}
