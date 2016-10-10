using System.ComponentModel.DataAnnotations;
using AdminNetBaires.Entities;

namespace AdminNetBaires.ViewModels
{
    
    public class MemberViewModel
    {
        //TODO : Paso 2 - Agergo la propieda Id

        public string Id { get; set; }

        [Required,MaxLength(50)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        //TODO : Paso 1 - Agergo propieda de imagen
        [Required, MaxLength(150)]
        [Display(Name = "Imagen")]
        public string Image { get; set; }

        [Required, MaxLength(50)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required, MaxLength(25), Display(Name = "Id Externo")]
        [RegularExpression(@"[^\s]+")]

        public string ExternaId { get; set; }

        public int Calification { get; set; }


        public MemberViewModel(Member member)
        {
            this.Name = member.Name;
            this.LastName = member.LastName;
            this.Email = member.Email;
            this.ExternaId = member.ExternaId;
            this.Calification = member.Calification;
            this.Image = member.Image;
            this.Id = member.Id.ToString();
        }

        public MemberViewModel()
        {
            
        }
    }
}