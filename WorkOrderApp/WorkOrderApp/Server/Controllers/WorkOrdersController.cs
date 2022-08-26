using System.Collections.Generic;
using WorkOrderApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkOrderApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrdersController : ControllerBase
    {
        private readonly OrderDataContext _db;

        public WorkOrdersController(OrderDataContext db)
        {
            _db = db;
        }

        [HttpGet, Route("")]
        public IEnumerable<WorkOrder> Get()
        {
            return _db.WorkOrder.ToList();
        }

        [HttpPost, Route("")]
        public async Task<ActionResult<List<WorkOrder>>> Post([FromBody] List<WorkOrder> value)
        {
            // change the status to "Saved"
            value.ForEach(x => x.Status = "Saved");
            _db.WorkOrder.AddRange(value);
            await _db.SaveChangesAsync();

            var orders = await _db.WorkOrder.ToListAsync();
            return Ok(orders);
        }
    }
}