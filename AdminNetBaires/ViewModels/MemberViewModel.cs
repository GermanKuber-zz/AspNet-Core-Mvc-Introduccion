using System.ComponentModel.DataAnnotations;

namespace AdminNetBaires.ViewModels
{
    
    public class MemberViewModel
    {
        //TODO : Paso 2 - Se agregan anotaciones
        [Required,MaxLength(50)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required, MaxLength(25), Display(Name = "Id Externo")]

        public string ExternaId { get; set; }

        public int Calification { get; set; }

    }
}