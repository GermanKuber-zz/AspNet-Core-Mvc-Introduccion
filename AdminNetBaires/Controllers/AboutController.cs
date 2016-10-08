using Microsoft.AspNetCore.Mvc;

namespace AdminNetBaires.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "+549-11-2345-2278";
        }
        public string Country()
        {
            return "Arg";
        }
    }
}
