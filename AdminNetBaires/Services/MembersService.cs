using System.Collections.Generic;
using System.Linq;
using AdminNetBaires.Entities;

namespace AdminNetBaires.Services
{
    public class MembersService : IMembersService
    {
        //TODO: Paso 3 - Miembro static
        static readonly List<Member> _members;
        static MembersService()
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
            //TODO: Paso 4 - Implemento la interface
            member.Id = _members.Max(r => r.Id) + 1;
            _members.Add(member);
         
        }
    }
}