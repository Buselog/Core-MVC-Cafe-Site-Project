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

    - Sitede abonelik için mail adresini giren kullanıcıya isteğinin gönderilip gönderilmediğine dair modern alert içeriği eklenmiştir.

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


### Coffylab Cafe Site

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

###### ✅ Alert Dialog (Subscription Request Sent Successfully)

<img src="https://github.com/user-attachments/assets/8a3090bd-5929-4139-b188-99e3675210c2" width:700>

###### ❌ Alert Dialog (Invalid Email Entered for Subscription Request)

<img src="https://github.com/user-attachments/assets/cb799667-3f73-44b9-b1ca-98d00ed6cac0" width:700>

###### ❓ 404 Error Page 

<img src="https://github.com/user-attachments/assets/043377af-0f59-477d-bb30-8196ff5b0c5d" width:700>





-----


### Admin Panel Section



###### 🏠 Login Page

<img src="https://github.com/user-attachments/assets/5520374a-ec69-443b-a9fd-77309c4a992c" width:700>

###### 🏠 Login Page (With Validation)

<img src="https://github.com/user-attachments/assets/7ce6451f-a1fe-4aca-9d47-4c2065ec7a80" width:700>

######  Admin Profile Page

<img src="https://github.com/user-attachments/assets/9722f0e9-b355-4b8c-9cdd-5d1d6651286e" width:700>

###### 🧷 Change Password Page (With Validation)

<img src="https://github.com/user-attachments/assets/581664af-fd8b-46bb-b53f-7173049cda9a" width:700>

###### 📧 Subscribe Request Notifications

<img src="https://github.com/user-attachments/assets/2d96e421-2507-4aba-87ec-89103687ba96" width:700>

###### 🔔 Notifications

<img src="https://github.com/user-attachments/assets/b542d183-e9b5-4337-abe4-90089d97094b" width:700>

###### 📈 Dashboard Page

<img src="https://github.com/user-attachments/assets/868398a3-e02b-42f0-9f5b-8a3f6e64a472" width:700>

###### 📝 Category Page

<img src="https://github.com/user-attachments/assets/7bd95f3c-b6f0-40a1-bba7-85a6bde209c4" width:700>

###### ☕️ Product Page

<img src="https://github.com/user-attachments/assets/37b30fb0-ff0c-4d59-ab31-dcee65aff21d" width:700>

###### 🍵 Update Product Page (With Validation)

<img src="https://github.com/user-attachments/assets/fc357b31-84ad-4cc6-ae47-ce669cfd7fed" width:700>

###### 🏠 Testimonial Page

<img src="https://github.com/user-attachments/assets/00abfa21-4863-4e1b-bf85-98af6a478658" width:700>

###### 🏠 Add Testimonial Page (With Validation)

<img src="https://github.com/user-attachments/assets/ce83f028-4b4a-4714-b085-20c30813f078" width:700>

###### 📧 Subscribe Page (The request is confirmed with the Update button.)

<img src="https://github.com/user-attachments/assets/650d3eb3-6a06-48e8-a3c2-142e2692d8a9" width:700>

###### 📷 Gallery Page

<img src="https://github.com/user-attachments/assets/5f33b106-07ad-4454-b0b1-a2b0b6c7ca8c" width:700>

###### 📍 Address Page

<img src="https://github.com/user-attachments/assets/45e13d51-948f-40ac-8eda-6b68da5750a1" width:700>

###### 📍 Update Address Page (With Validation)

<img src="https://github.com/user-attachments/assets/aeb937d6-ea01-4766-af04-4a0c8a62f5b9" width:700>

###### 📱 Social Media Page

<img src="https://github.com/user-attachments/assets/a9977a2f-0299-4a42-b3cf-7f986a46b35b" width:700>

###### 📲 Add Social Media Page (With Validation)

<img src="https://github.com/user-attachments/assets/ab6c0cef-9428-414c-8ae0-8184e4cd3cca" width:700>









    


    
    
    
