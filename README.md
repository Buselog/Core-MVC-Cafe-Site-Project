# 🚀 Asp .Net Core MVC ile Admin Panelli Kafe Sitesi Projesi

Bu proje, ASP.NET Core MVC ve Code First yöntemi kullanılarak geliştirilmiş admin panelli dinamik bir kafe sitesidir. Site içerisinde kafe ile ilgili görseller, zengin bir içerik barındıran menü, referanslar ve dinamik bir abonelik istek alanı mevcuttur. Abonelik istekleri admin paneline bildirim olarak gelmekte ve listeye kaydedilmektedir. Abonelik isteğinin başarılı olup olmadığına dair kullanıcıya gösterilen modern alert modelleri projeye dahil edilmiştir.
Kafe sitesi verilerinin yönetimi için kullanıcı dostu bir admin paneli de projede yer almaktadır. Panelde son bildirimler, abonelik isteklerinin bildirim olarak düştüğü notification alanları mevcuttur.

-----

## ☄️ Projenin Sahip Olduğu Kazanımlar

###### 🌟 ASP.NET Core MVC

 - ViewComponent kullanımı ve responsive tasarım prensipleriyle geliştirilen, modern ve ölçeklenebilir bir proje geliştirimi.

###### 🌟 Entity Framework Core ile Veritabanı İşlemleri( SQL Server - Code First Yaklaşım)

    - CoffylabContext sınıfı üzerinden veritabanı işlemleri gerçekleştirilmiştir. 
    - Admin girişleri, profil verileri ve güncellemeler Entity Framework Core ile yönetilmiştir.

###### 🌟 Authentication & Authorization 

    -  Cookie Authentication kullanılarak kimlik doğrulama yapılmıştır.
    - [Authorize] attribute'u ile Admin yetkilendirmesi sağlanmıştır.

###### 🌟 Session & Cookie Yönetimi 

    - Admin oturumu ve tercihlerini saklama

###### 🌟 FluentValidation ile Form Doğrulama

    - FluentValidation kütüphanesi ile kullanıcı girişlerinde form verilerinin doğruluğu kontrol edilmiştir.
    - Kullanıcıdan alınan verilerin belirlenen kurallara uygunluğu sağlanarak hata riskleri azaltılmıştır.
    - Admin panelindeki her ekleme ve güncelleme formu için validasyon kuralları entegre edilmiştir.

###### 🌟 SweetAlert2 İle Şık ve Modern Bildirimler

   - Sitede abonelik için mail adresini giren kullanıcıya isteğinin gönderilip
   gönderilmediğine dair modern alert içeriği eklenmiştir.

###### 🌟 Custom 404 Error Page
    - Her iki panel için de eklenmiş, modern 404 hata sayfası sistemi entegre edilmiştir.    

###### 🌟 Dosya Yükleme (Resim Upload) İşlemleri

    - Ürünlere resim yüklenmesi için sunucu tarafında dosya yükleme işlemi gerçekleştirilmiştir.
    - Kullanıcının seçtiği resim dosyası sunucunun wwwroot/images klasörüne kaydedilmiş ve veritabanında yolu tutulmuştur.

###### 🌟 Şifre Güncelleme İşlemi

    - Admin, mevcut şifresini doğrulayarak yeni şifre belirleyebilmektedir.
    - Şifre değişimi sırasında hata kontrolleri yapılmış (örneğin, mevcut şifrenin doğru girilmesi ve yeni şifrelerin eşleşmesi)


----- 


## ☄️ Projeye Genel Bakış

### Buselog Portfolio Site

###### 🏠 Home Section

<img src="https://github.com/user-attachments/assets/a4cbc3ec-e3ac-4310-87e6-775f0d4a7c71" width:700>


###### 🪪 About Section

<img src="https://github.com/user-attachments/assets/79230091-0308-43d7-b427-010793230be1" width:700>

###### 📋 Menu Section

<img src="https://github.com/user-attachments/assets/1445c45e-02f3-4c15-a129-24ada026edfb" width:700>

###### 🔎 Gallery Section

<img src="https://github.com/user-attachments/assets/d9634e83-1747-453f-8ab8-b952b8d9e4da" width:700>

###### 👤 Testimonial Section

<img src="https://github.com/user-attachments/assets/8c38a444-deb5-49bb-bad6-b151ace6394f" width:700>

###### ✉️ Footer Section

<img src="https://github.com/user-attachments/assets/06817c04-f677-448c-8b51-2407c03c1dc6" width:700>


-----


### Admin Panel Section



###### 🏠 Login Page

<img src="" width:700>

###### 🏠 Login Page (With Validation)

<img src="" width:700>
    


    
    
    
