using MarketBackend.WorkerService.DTOs;

namespace MarketBackend.WorkerService.Services
{
    public interface IWorkerService
    {
        Task<IEnumerable<WorkerDto>> GetAllWorkers();
        Task<WorkerDto> GetWorkerById(int id);
        Task<IEnumerable<LessonDto>> GetLessonsByWorker(int WorkerId);
        Task<IEnumerable<StudentDto>> GetStudentsByLesson(int lessonId);
    }
}
