using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class Cliente
    {
        public Guid idUsuario { get; set; }
        public string Correo { get; set; } = string.Empty;
        public string Nombre { get; set; }
        public string Direccion { get; set; } 
        public string? MetodoPago { get; set; }

    }
}
