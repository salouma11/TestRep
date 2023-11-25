using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestGit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public void Get()
        {
            var a = "hello";
            var a1  = "hello";
        }
    }
}
