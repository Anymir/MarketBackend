using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MarketBackend.ScheduleService.DTOs;
using MarketBackend.ScheduleService.Services;

namespace MarketBackend.ScheduleService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _service;

        public ScheduleController(IScheduleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<ScheduleDto>> GetAllSchedules() => await _service.GetAllSchedules();

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleDto>> GetScheduleById(int id)
        {
            var schedule = await _service.GetScheduleById(id);
            if (schedule == null) return NotFound();
            return Ok(schedule);
        }

        [HttpPost]
        public async Task<ActionResult<ScheduleDto>> CreateSchedule(ScheduleDto dto)
        {
            var created = await _service.CreateSchedule(dto);
            return CreatedAtAction(nameof(GetScheduleById), new { id = created.Id }, created);
        }
    }
}
