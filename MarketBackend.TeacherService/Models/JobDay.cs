namespace MarketBackend.WorkerService.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
