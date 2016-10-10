using System.Collections.Generic;
using System.Linq;
using AdminNetBaires.Context;
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


    public class MembersSqlLiteService : IMembersService
    {
        //TODO : Paso 4 - Agrego nuevo servicio de Members contra Sql
        private readonly NetBairesContext _netBairesContext;


        MembersSqlLiteService(NetBairesContext netBairesContext)
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