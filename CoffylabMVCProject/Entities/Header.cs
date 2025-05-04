namespace CoffylabMVCProject.Entities
{
    public class Header
    {
        public int HeaderId { get; set; }
        public string? Location { get; set; }
        public string? OpenHoursWeekdays { get; set; }
        public string? OpenHoursWeekends { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
