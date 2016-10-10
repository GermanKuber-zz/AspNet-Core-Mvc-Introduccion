using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminNetBaires.Entities
{
    public class TalkViewModel
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
     
        public List<int> SpeakersId { get; set; } = new List<int>();
    }
}