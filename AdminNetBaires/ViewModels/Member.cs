using System.ComponentModel.DataAnnotations;

namespace AdminNetBaires.ViewModels
{
    //TODO: Paso 6 - Genero MemberViewModel
    public class MemberViewModel
    {
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Id Externo")]
        public string ExternaId { get; set; }
        public int Calification { get; set; }

    }
}