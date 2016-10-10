namespace AdminNetBaires.Entities.Relations
{
    public class EventOrganizers
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}