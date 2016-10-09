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
                new  Member { Id = 1,Name = "Matias", LastName = "Apellido", Email = "matigas@gmail.com" },
                new  Member { Id = 2,Name = "Federico", LastName = "Marin", Email = "fedemarin@gmail.com" },
                new  Member { Id = 3,Name = "Maria", LastName = "Paz", Email = "mpaz@gmail.com" }
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
    }
}