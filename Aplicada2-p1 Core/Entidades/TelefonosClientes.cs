using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicada2p1Core.Entidades
{
    public class TelefonosClientes
    {
        [Key]
        public int IdTelefono { get; set; }
        public int IdCliente { get; set; }
        public string Tipo{ get; set; }
        public string Telefono { get; set; }
    }
}
