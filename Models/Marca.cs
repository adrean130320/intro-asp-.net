using System;
using System.Collections.Generic;

namespace introAsp.Models
{
    public partial class Marca
    {
        public Marca()
        {
            Cervezas = new HashSet<Cerveza>();
        }

        public int Id { get; set; }
        public string Marca1 { get; set; } = null!;

        public virtual ICollection<Cerveza> Cervezas { get; set; }
    }
}
