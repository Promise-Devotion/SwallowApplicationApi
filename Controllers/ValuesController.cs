using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwallowApplicationApi.Models;
using System;

namespace SwallowApplicationApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;
        public ValuesController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }
        [HttpGet]
        public List<ValuesModel> GetValues()
        {
            List<ValuesModel> result = new List<ValuesModel>();
            result.Add(new ValuesModel() { Id = 1, Age = 18, UserName = "Sijun", Description = "He is husband", DateTime = DateTime.Now });
            result.Add(new ValuesModel() { Id = 1, Age = 20, UserName = "Sophie", Description = "She is wife", DateTime = DateTime.Now });
            return result;
        }
        [HttpGet]
        public List<UserModel> GetUsers()
        {
            return _coreDbContext.Set<UserModel>().ToList();
        }
    }
}
