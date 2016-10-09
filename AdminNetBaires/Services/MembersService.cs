using System.Collections.Generic;
using System.Linq;
using AdminNetBaires.Entities;

namespace AdminNetBaires.Services
{
    //TODO : Paso 1 - Renombro mi implementacion del serviio a MembersMemoryService
    public class MembersMemoryService : IMembersService
    {

        static readonly List<Member> _members;
        static MembersMemoryService()
        {
            _members = new List<Member>
            {
                new  Member { Id = 1,Name = "Matias", LastName = "Apellido", Email = "matigas@gmail.com" },
                new  Member { Id = 2,Name = "Federico", LastName = "Marin", Email = "fedemarin@gmail.com" },
                new  Member { Id = 3,Name = "Maria", LastName = "Paz", Email = "mpaz@gmail.com" }
            };
        }

        public IEnumerable<Member> GetAll()
        {
            return _members;
        }

        public Member GetById(int id)
        {

            return _members.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Member member)
        {
            member.Id = _members.Max(r => r.Id) + 1;
            _members.Add(member);

        }
    }
}