using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderApp.Shared;
using WorkOrderApp.Shared.Models;

namespace WorkOrderApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        OrderDataContext db = new OrderDataContext();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WorkOrder> Get()
        {
            return db.WorkOrder.ToList();
        }
        [HttpPost]
        public void Post([FromBody] List<WorkOrder> value)
        {
            //update db
            try
            {
                db.WorkOrder.AddRange(value);
                db.SaveChanges();
                db.WorkOrder.AddRange(value);
            }
            catch
            {
                throw;
            }

            }
        }
}
