namespace ActivityLog.Models
{
    public class Activity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        public Activity()
        {
            
        }
    }
}
