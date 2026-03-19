namespace MarketBackend.ScheduleService.DTOs
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int LessonId { get; set; }
        public DateTime ScheduledAt { get; set; }
    }
}
