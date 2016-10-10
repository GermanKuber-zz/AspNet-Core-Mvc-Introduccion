using System.Collections.Generic;
using System.Linq;
using AdminNetBaires.Context;
using AdminNetBaires.Entities;

namespace AdminNetBaires.Services
{
    public class MembersSqlLiteService : IMembersService
    {
        //TODO : Paso 4 - Agrego nuevo servicio de Members contra Sql
        private readonly NetBairesContext _netBairesContext;


        public MembersSqlLiteService()
        {
            
        }
        public MembersSqlLiteService(NetBairesContext netBairesContext)
        {
            _netBairesContext = netBairesContext;
        }

        public IEnumerable<Member> GetAll()
        {
            return _netBairesContext.Members.ToList();
        }

        public Member GetById(int id)
        {

            return _netBairesContext.Members.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Member member)
        {
            _netBairesContext.Members.Add(member);
        }

        public int Commit()
        {
            return _netBairesContext.SaveChanges();
        }
    }
}