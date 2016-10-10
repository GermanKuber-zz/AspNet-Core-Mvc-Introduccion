using System;
using System.Collections.Generic;
using AdminNetBaires.Entities.Relations;

namespace AdminNetBaires.Entities
{
    public class Talk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public string Description { get; set; }
        public List<MemberTalk> Speakers { get; set; }
    }
}