using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwallowApplicationApi.Models;
using System;

namespace SwallowApplicationApi.Controllers
{
    [Route("api/[controller]/GetBillList")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly CoreDbContext _coreDbContext;
        public BillController(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }
        [HttpGet]
        public List<BillModel> GetBillList()
        {
            return _coreDbContext.Set<BillModel>().ToList();
        }
    }
}
