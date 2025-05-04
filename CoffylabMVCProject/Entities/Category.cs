namespace CoffylabMVCProject.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public List<Product>? Products { get; set; } // İlişkili tablolar oluşturma (Ctegory-Product)
        // Her category'de birden fazla product bulunur, bu yüzden List<> kullandık.
        // public virtual List<Product> şeklinde yazmadık. Mvc'de lazy loading için yazılır. Core'da virtual yazımına gerek yok. 
    }
}
