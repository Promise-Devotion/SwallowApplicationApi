using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwallowApplicationApi.Models;

namespace SwallowApplicationApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<ValuesModel> GetValues()
        {
            List<ValuesModel> result = new List<ValuesModel>();
            result.Add(new ValuesModel() { Id = 1, Age = 18, UserName = "Sijun", Description = "He is husband", DateTime = DateTime.Now });
            result.Add(new ValuesModel() { Id = 1, Age = 20, UserName = "Sophie", Description = "She is wife", DateTime = DateTime.Now });
            return result;
        }
    }
}
