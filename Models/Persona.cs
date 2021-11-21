using System;
using System.Collections.Generic;

#nullable disable

namespace CrudmySQL.Models
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Programa { get; set; }
    }
}
