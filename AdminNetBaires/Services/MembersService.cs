using System.Collections.Generic;
using System.Linq;
using AdminNetBaires.Entities;

namespace AdminNetBaires.Services
{
    public class MembersService : IMembersService
    {
        readonly List<Member> _members;
        public MembersService()
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
            //TODO : Paso 7 - Implemento el servicio para obtener por id / |>
            return this._members.FirstOrDefault(x => x.Id == id);
        }

        
    }
}