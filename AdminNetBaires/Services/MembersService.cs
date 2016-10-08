using System.Collections.Generic;
using AdminNetBaires.Models;

namespace AdminNetBaires.Services
{
    public class MembersService : IMembersService
    {
        //TODO : Paso 1 - Creo servicio de Members / >
        public MembersService()
        {
            _members = new List<MemberViewModel>
            {
                new  MemberViewModel { Name = "Matias", LastName = "Apellido", Email = "matigas@gmail.com" },
                new  MemberViewModel { Name = "Federico", LastName = "Marin", Email = "fedemarin@gmail.com" },
                new  MemberViewModel { Name = "Maria", LastName = "Paz", Email = "mpaz@gmail.com" }
            };
        }

        public IEnumerable<MemberViewModel> GetAll()
        {
            return _members;
        }

        List<MemberViewModel> _members;
    }
}