using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminNetBaires.Entities
{
    public class EventViewModel
    {
        
        public int Id { get; set; }
        [Display(Name = "Comienza")]
        [DataType(DataType.Time)]
        public TimeSpan Start { get; set; }
        [Display(Name = "Termina")]
        [DataType(DataType.Time)]
        public TimeSpan End { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Display(Name = "Organizadores")]

        public List<string> OrganizersId { get; set; } = new List<string>();
        [Display(Name = "Charlas")]
        public List<TalkViewModel> Talks { get; set; } = new List<TalkViewModel>();
    }
}