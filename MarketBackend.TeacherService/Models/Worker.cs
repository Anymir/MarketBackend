namespace MarketBackend.WorkerService.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
    }
}
