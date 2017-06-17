using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicada2p1Core.Entidades
{
    public class Clientes
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCliente { get; set; }
        public DateTime FechaNacimiento {get;set;}
        public string Nombres { get; set; }
        public int CantidadTelefonos { get; set; }

        public ICollection<TelefonosClientes> TelefonosClientes { get; set; }
    }
}
