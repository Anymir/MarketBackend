using MarketBackend.ScheduleService.DTOs;

namespace MarketBackend.ScheduleService.Services
{
    public interface IScheduleService
    {
        Task<IEnumerable<ScheduleDto>> GetAllSchedules();
        Task<ScheduleDto> GetScheduleById(int id);
        Task<ScheduleDto> CreateSchedule(ScheduleDto dto);
    }
}
