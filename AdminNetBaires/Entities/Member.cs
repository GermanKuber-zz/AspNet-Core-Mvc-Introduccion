using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdminNetBaires.Entities.Relations;

namespace AdminNetBaires.Entities
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string ExternaId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Calification { get; set; }
        //public List<EventOrganizers> Events { get; set; }

        //public List<MemberTalk> Talks { get; set; }

    }
}