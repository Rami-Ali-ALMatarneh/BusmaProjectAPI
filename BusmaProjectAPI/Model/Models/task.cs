namespace BusmaProjectAPI.Model.Models
    {
    public class task
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CurrnetTime { get; set; } = DateTime.Now;
        public DateTime UploadTime {get; set; }
        public User user { get; set; }
        public int UserId { get; set; }
        }
    }
