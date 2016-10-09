using System.Collections.Generic;
using AdminNetBaires.Entities;
using AdminNetBaires.ViewModels;

namespace AdminNetBaires.Services
{
    public interface IMembersService
    {
        IEnumerable<Member> GetAll();
    }
}