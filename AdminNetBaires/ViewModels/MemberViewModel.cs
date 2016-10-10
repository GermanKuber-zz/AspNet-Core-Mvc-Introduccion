using System.ComponentModel.DataAnnotations;
using AdminNetBaires.Entities;

namespace AdminNetBaires.ViewModels
{
    
    public class MemberViewModel
    {
   
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
        //TODO : Paso 10 - Se agrega validacion al External ID
        [RegularExpression(@"[^\s]+")]

        public string ExternaId { get; set; }

        public int Calification { get; set; }


        public MemberViewModel(Member member)
        {
            //TODO : Paso 07 - Creo un constructor y seteo los valores 
            this.Name = member.Name;
            this.LastName = member.LastName;
            this.Email = member.Email;
            this.ExternaId = member.ExternaId;
            this.Calification = member.Calification;

        }

        public MemberViewModel()
        {
            
        }
    }
}