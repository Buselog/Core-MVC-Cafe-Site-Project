namespace CoffylabMVCProject.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public string  BackgroundColor { get; set; }
        public string Icon { get; set; }

    }
}
