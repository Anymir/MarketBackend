using Microsoft.EntityFrameworkCore;
using MarketBackend.WorkerService.Data;
using MarketBackend.WorkerService.DTOs;
using MarketBackend.WorkerService.Models;

namespace MarketBackend.WorkerService.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly WorkerDbContext _context;

        public WorkerService(WorkerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WorkerDto>> GetAllWorkers()
        {
            return await _context.Workers
                .Select(t => new WorkerDto { Id = t.Id, FullName = t.FullName, Email = t.Email })
                .ToListAsync();
        }

        public async Task<WorkerDto> GetWorkerById(int id)
        {
            var t = await _context.Workers.FindAsync(id);
            if (t == null) return null;
            return new WorkerDto { Id = t.Id, FullName = t.FullName, Email = t.Email };
        }

        public async Task<IEnumerable<LessonDto>> GetLessonsByWorker(int WorkerId)
        {
            return await _context.Lessons
                .Where(l => l.WorkerId == WorkerId)
                .Select(l => new LessonDto { Id = l.Id, Subject = l.Subject, StartTime = l.StartTime, EndTime = l.EndTime })
                .ToListAsync();
        }

        public async Task<IEnumerable<StudentDto>> GetStudentsByLesson(int lessonId)
        {
            return await _context.Students
                .Where(s => s.LessonId == lessonId)
                .Select(s => new StudentDto { Id = s.Id, FullName = s.FullName, Email = s.Email })
                .ToListAsync();
        }
    }
}
