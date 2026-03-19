using Microsoft.EntityFrameworkCore;
using MarketBackend.ScheduleService.Data;
using MarketBackend.ScheduleService.DTOs;
using MarketBackend.ScheduleService.Models;

namespace MarketBackend.ScheduleService.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly ScheduleDbContext _context;

        public ScheduleService(ScheduleDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ScheduleDto>> GetAllSchedules()
        {
            return await _context.Schedules
                .Select(s => new ScheduleDto
                {
                    Id = s.Id,
                    WorkerId = s.WorkerId,
                    LessonId = s.LessonId,
                    ScheduledAt = s.ScheduledAt
                }).ToListAsync();
        }

        public async Task<ScheduleDto> GetScheduleById(int id)
        {
            var s = await _context.Schedules.FindAsync(id);
            if (s == null) return null;

            return new ScheduleDto
            {
                Id = s.Id,
                WorkerId = s.WorkerId,
                LessonId = s.LessonId,
                ScheduledAt = s.ScheduledAt
            };
        }

        public async Task<ScheduleDto> CreateSchedule(ScheduleDto dto)
        {
            var schedule = new Schedule
            {
                WorkerId = dto.WorkerId,
                LessonId = dto.LessonId,
                ScheduledAt = dto.ScheduledAt
            };

            _context.Schedules.Add(schedule);
            await _context.SaveChangesAsync();

            dto.Id = schedule.Id;
            return dto;
        }
    }
}
