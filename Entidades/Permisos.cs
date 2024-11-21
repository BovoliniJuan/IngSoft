using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permisos
    {
        private int idPermiso;
        private bool pvendedor;
        private bool pcliente;
        private bool padministrador;

        [Key]
        public int IdPermiso { get { return idPermiso; } set { idPermiso = value; } }
        public bool pVendedor { get { return pvendedor; } set { value = pvendedor; } }
        public bool pCliente { get { return pcliente; } set { value = pcliente; } }
        public bool pAdministrador { get { return padministrador; } set { value = padministrador; } }

        public Permisos() { }
        public bool TienePermiso(string permiso)
        {
            return permiso switch
            {
                "Vendedor" => pVendedor,
                "Cliente" => pCliente,
                "Administrador" => pAdministrador,
                _ => false,
            };
        }
    }
}
