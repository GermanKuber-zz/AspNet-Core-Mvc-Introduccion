using System.Collections.Generic;
using AdminNetBaires.Entities;

namespace AdminNetBaires.ViewModels
{

    //TODO : Paso 1 - Creo mi ViewModel
    public class HomePageViewModel
    {
        public IEnumerable<Member> Members { get; set; }

        public string Message { get; set; }
    }
}