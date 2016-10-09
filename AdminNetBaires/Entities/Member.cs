using System.ComponentModel.DataAnnotations;

namespace AdminNetBaires.Entities
{
    //TODO : Paso 2 - Genero mi primera Entidad
    public class Member
    {
        public int Id { get; set; }
        [Display(Name = "Id Externo")]
        public string ExternaId { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        public int Calification { get; set; }

    }
}