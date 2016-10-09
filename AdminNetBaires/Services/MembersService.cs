using System.Collections.Generic;
using AdminNetBaires.Entities;
using AdminNetBaires.ViewModels;

namespace AdminNetBaires.Services
{
    public class MembersService : IMembersService
    {
        
        public MembersService()
        {
            _members = new List<Member>
            {
                new  Member { Name = "Matias", LastName = "Apellido", Email = "matigas@gmail.com" },
                new  Member { Name = "Federico", LastName = "Marin", Email = "fedemarin@gmail.com" },
                new  Member { Name = "Maria", LastName = "Paz", Email = "mpaz@gmail.com" }
            };
        }

        public IEnumerable<Member> GetAll()
        {
            return _members;
        }

        List<Member> _members;
    }
}