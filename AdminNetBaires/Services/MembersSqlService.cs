using System.Collections.Generic;
using System.Linq;
using AdminNetBaires.Entities;

namespace AdminNetBaires.Services
{
    //TODO : Paso 3 - Creo una nueva implementacion de IMembersService
    public class MembersSqlService : IMembersService
    {
        private readonly AdminNetDbContext _adminNetDbContext;

 
        MembersSqlService(AdminNetDbContext adminNetDbContext)
        {
            _adminNetDbContext = adminNetDbContext;
        }

        public IEnumerable<Member> GetAll()
        {
            return _adminNetDbContext.Members.ToList();
        }

        public Member GetById(int id)
        {

            return _adminNetDbContext.Members.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Member member)
        {

            _adminNetDbContext.Members.Add(member);

        }
    }
}