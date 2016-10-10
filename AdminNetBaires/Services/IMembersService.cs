using System.Collections.Generic;
using AdminNetBaires.Entities;

namespace AdminNetBaires.Services
{
    public interface IMembersService
    {
        IEnumerable<Member> GetAll();
        Member GetById(int id);
        void Create(Member member);
        //TODO : Paso 5 - Agrego nuevo metodo commit para salvar los cambios
        int Commit( );
    }
}