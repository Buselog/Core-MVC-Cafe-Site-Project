using System.ComponentModel.DataAnnotations.Schema;

namespace CoffylabMVCProject.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public double ProductPrice { get; set; }
        public string? ImageUrl { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public int? CategoryId { get; set; }  // İlişki tablolar (Category-Product)
        public Category? Category { get; set; }  // Üstte yazılan CategoryId'nin nereden geldiğini bildirme
        // public virtual Category Category yazmamıza gerek yok, virtual MVC tarafında yazılır lazy loading için.
    }
}
