namespace AdminNetBaires.Entities.Relations
{
    public class MemberTalk
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int TalkId { get; set; }
        public Talk Talk { get; set; }
    }
}