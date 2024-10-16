using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SenorMQ135.Data;
using SenorMQ135.Models;
using System.Threading.Tasks;

namespace SenorMQ135.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class SensorDataController : ControllerBase
    {
        private readonly SensorDataContext _context;

        public SensorDataController(SensorDataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<SensorData>> PostSensorData(SensorData sensorData)
        {
            sensorData.Timestamp = DateTime.UtcNow; // Adicionar timestamp
            _context.SensorData.Add(sensorData); // Adicionando ao DbSet
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(PostSensorData), new { id = sensorData.Id }, sensorData);
        }
    }
}

