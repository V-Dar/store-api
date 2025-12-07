using Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    [ApiController]
    [Route("api/[controller]/[Action]")] //Преобразуется в api/Store/Get
    public class StoreController : ControllerBase
    {
        protected readonly AppDbContext dbContext;

        public StoreController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}