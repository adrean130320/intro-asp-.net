using System.ComponentModel.DataAnnotations;

namespace introAsp.Models.ViewModels
{
    public class CervezaViewModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Marca { get; set; }
        
    }
}
