using System.Collections.Generic;
using System.Linq;
using AdminNetBaires.Entities;

namespace AdminNetBaires.Services
{
    public class MembersMemoryService : IMembersService
    {

        private static readonly List<Member> Members;
        static MembersMemoryService()
        {
            Members = new List<Member>
            {
                new  Member { Id = 1,Name = "Matias", LastName = "Apellido", Email = "matigas@gmail.com", Image = "http://media.gettyimages.com/videos/facial-expression-of-angry-adult-man-on-blue-background-video-id502798246?s=640x640"},
                new  Member { Id = 2,Name = "Federico", LastName = "Marin", Email = "fedemarin@gmail.com", Image = "http://hairstyleonpoint.com/wp-content/uploads/2015/04/indigobloomdesigns-blogspot-com-OVAL.jpg"},
                new  Member { Id = 3,Name = "Maria", LastName = "Paz", Email = "mpaz@gmail.com" , Image = "http://media.gettyimages.com/videos/businessman-showing-red-business-card-video-id472920593?s=640x640"}
            };
        }

        public IEnumerable<Member> GetAll()
        {
            return Members;
        }

        public Member GetById(int id)
        {

            return Members.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Member member)
        {
            member.Id = Members.Max(r => r.Id) + 1;
            Members.Add(member);

        }

        public int Commit()
        {
            return 0;
        }

        public void Update(Member member)
        {
            Members.Remove(member);
            Members.Add(member);
        }
    }
}