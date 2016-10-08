using System.Collections.Generic;
using AdminNetBaires.Models;

namespace AdminNetBaires.Services
{
    public interface IMembersService
    {
        IEnumerable<MemberViewModel> GetAll();
    }
}