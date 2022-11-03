using System;
using System.Collections.Generic;

namespace introAsp.Models
{
    public partial class Cerveza
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Marca { get; set; }

        public virtual Marca MarcaNavigation { get; set; } = null!;
    }
}
