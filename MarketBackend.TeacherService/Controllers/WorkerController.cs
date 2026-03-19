using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MarketBackend.WorkerService.DTOs;
using MarketBackend.WorkerService.Services;

namespace MarketBackend.WorkerService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _service;

        public WorkerController(IWorkerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<WorkerDto>> GetAllWorkers() => await _service.GetAllWorkers();

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkerDto>> GetWorkerById(int id)
        {
            var Worker = await _service.GetWorkerById(id);
            if (Worker == null) return NotFound();
            return Ok(Worker);
        }

        [HttpGet("{id}/lessons")]
        public async Task<IEnumerable<LessonDto>> GetLessonsByWorker(int id) => await _service.GetLessonsByWorker(id);

        [HttpGet("lessons/{lessonId}/students")]
        public async Task<IEnumerable<StudentDto>> GetStudentsByLesson(int lessonId) => await _service.GetStudentsByLesson(lessonId);
    }
}
