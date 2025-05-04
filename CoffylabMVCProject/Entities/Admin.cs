using System.ComponentModel.DataAnnotations.Schema;

namespace CoffylabMVCProject.Entities
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string? AdminName { get; set; }
        public string? Email { get; set; }
        public string? password { get; set; }

        [NotMapped]
        public string? CurrentPassword { get; set; }
        [NotMapped]
        public string? NewPassword { get; set; }
        [NotMapped]
        public string? ConfirmPassword { get; set; }
    }
}
