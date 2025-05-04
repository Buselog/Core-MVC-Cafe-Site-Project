namespace CoffylabMVCProject.Entities
{
    public class Subscribe
    {
        public int SubscribeId { get; set; }
        public string? Email { get; set; }
        public DateTime SendDate { get; set; }
        public bool ApprovalStatus { get; set; }
    }
}
