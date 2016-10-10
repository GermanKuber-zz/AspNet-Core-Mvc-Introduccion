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
}
