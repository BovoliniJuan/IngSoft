using Entidades.Seguridad2;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Controladoras.Seguridad
{
    public class ControladoraAcciones
    {
        private static ControladoraAcciones instancia;


        public static ControladoraAcciones Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAcciones();
                }
                return instancia;
            }
        }


        public ControladoraAcciones()
        {
        }



        public ReadOnlyCollection<Accion> RecuperarAcciones()
        {
            try
            {
                return Context.Instancia.Acciones.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public Accion ObtenerAccionPorNombre(string nombreAccion)
        {
            return Context.Instancia.Acciones.FirstOrDefault(a => a.Nombre == nombreAccion);
        }


        public List<Accion> ObtenerAccionesPorGrupos(List<Grupo> gruposSeleccionados)
        {
            var acciones = Context.Instancia.Grupos
                .Where(g => gruposSeleccionados.Select(grupo => grupo.Id).Contains(g.Id))
                .SelectMany(g => g.Componentes)
                .OfType<Accion>() 
                .Distinct() 
                .ToList();

            return acciones;
        }



        public List<Accion> ObtenerAccionesPorModulo(string nombreModulo)
        {
            try
            {
                var acciones = Context.Instancia.Acciones.Include(a => a.Formulario)
                                      .ThenInclude(f => f.Modulo)  
                                      .Where(a => a.Formulario.Modulo.NombreModulo == nombreModulo)
                                      .ToList();

                return acciones;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las acciones del módulo: " + ex.Message);
                return new List<Accion>(); // Retorna una lista vacía en caso de error
            }
        }



        public List<Accion> ObtenerAccionesUsuario(Usuario usuario)
        {
            // Obtener las acciones personalizadas asociadas al usuario
            var acciones = usuario.Componentes
                .OfType<Accion>() // Filtrar solo acciones
                .Distinct() // Eliminar duplicados
                .ToList();

            return acciones;
        }



        public List<Accion> ObtenerAccionesGrupo(Grupo grupo)
        {
            var grupoExistente = Context.Instancia.Grupos
                .Include(g => g.Componentes) 
                .FirstOrDefault(g => g.Id == grupo.Id);

            var acciones = grupoExistente.Componentes
                .OfType<Accion>() 
                .Distinct() 
                .ToList();

            return acciones;
        }


    }
}
