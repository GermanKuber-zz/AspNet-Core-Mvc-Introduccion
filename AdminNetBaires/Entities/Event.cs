using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdminNetBaires.Entities.Relations;

namespace AdminNetBaires.Entities
{
    public class Event
    {
        public int Id { get; set; }
        [MaxLength(5),Required]
        public string Name { get; set; }
        [ Required]
        public string Description { get; set; }

       
        public TimeSpan Start { get; set; }

        public TimeSpan End { get; set; }
        public List<EventOrganizers> Organizers { get; set; }
        public List<Talk> Talks { get; set; }
    }


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
