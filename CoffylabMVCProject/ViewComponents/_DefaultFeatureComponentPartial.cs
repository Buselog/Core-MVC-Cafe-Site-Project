using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.ViewComponents
{

    // MVC'de  Index sayfamızdakileri uygun bir Controller'da PartialViewResult action'ı olarak ayırırken,
    // Core'da ise partial'lara ayırmak istediğimiz her alan için ViewComponents klasörü içinde bir class tanımlarız, 
    // yani aslında burada her partial bir mini Controller'a denk gelmiş olur, öyle davranır.

    // PartialView, Controller içinde yazılırdı yani ona bağlıydı, ViewComponent bir controller'a bağlı değil.
    // PartialView'i sitede çalıştırdığımızda css olmayan şekilde ilgili partial'ı sitede gösterirdi (Güvenlik açığı!)
    //Core'da ise ilgili bir ViewComponent sitede çalıştırıldığında hata verir. Daha güvenlidir. 

    // ViewComponent, veriyi hem çeker hem gösterir. Daha güçlüdür. Tekrar kullanılabilir, bağımsızdır.

    public class _DefaultFeatureComponentPartial : ViewComponent
    {

        // Invoke() sağ tıklayıp Add View ekleyememizin nedeni bunun bir Controller içinde olmaması.
        // Add View doğrudan eklenemediğinden, ViewComponent sırasıyla:

        // Views -> Shared -> Components -> _DefaultFeatureComponentPartial(ViewComponent İsimli Klasör) -> Default.cshtml
        // yoluna bakar ve burayı view'ler.


       // CoffylabContext db = new CoffylabContext();

        private readonly CoffylabContext _context; // field (alan)'dır. 
        // Eğer readonly kullanırsak, _context sadece constructor içinde bir kez atanabilir ve sonrasında değiştirilemez.
        // Bu durumda _context değişkeninin kendisi başka bir CoffylabContext nesnesi ile değiştirilemez.
        // Readonly sadece referansı sabit tutar, ancak nesnenin içeriğini değiştirmeye engel olmaz.
        // Bir metod içine yazılırsa variable (değişken) olurdu.
        // readonly, field'ın değerinin constructor dışında değiştirilmesini önler.
        // Başka bir nesne atanmamasını, bellek adresinin değiştirilmemesini sağlar.
        // Ancak, _context nesnesinin içindeki veriler üzerinde değişiklik yapabilirsiniz.



        // Constructor'a parametre olarak verilen CoffylabContext nesnesi, Program.cs tarafından verilir.
        // Yani dışarıdan gelen bu içerik, Program.cs tarafından verilmiştir.

        // Bu yöntemin adı Dependency Injection'dır
        // ve sürekli db = new Context() yazıp her yeni Controller'da veritabanından işlem yapmak için veritabanı bağlantısı oluşturmak yerine 
        // otomatik olarak Program.cs'ten isteyen ViewComponent'ler için gönderilir.
        public _DefaultFeatureComponentPartial(CoffylabContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Subtitle = _context.Tbl_Feature.Select(x => x.Subtitle).FirstOrDefault();
            return View();
        }
    }
}
