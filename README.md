# LibraryApplication

🌟**Kütüphane Uygulaması README**<br>
*Bu belge, Kütüphane Uygulaması'nın temel işlevselliği, gereksinimleri ve kurulum talimatlarını içermektedir.*<br>

🌟**Proje Genel Bakışı**<br>
*Bu uygulama, bir kütüphanenin kitaplarını yönetmek ve ödünç vermek için kullanılan bir .NET Core MVC uygulamasıdır. Aşağıdaki ana özelliklere sahiptir:*<br>

➜  Kütüphanedeki kitapların takibi.<br>
➜  Kitapların mevcut durumunu (kütüphanede veya dışarıda) gösterme.<br>
➜  Kitapları alfabetik sırayla listeleyen bir giriş ekranı.<br>
➜  Kitapları ödünç verme ve geri alma işlemleri.<br>
➜  Yeni kitap eklemek için bir arayüz.<br>

🌟**Teknik Altyapılar**<br>

*Bu projede aşağıdaki teknik altyapılar kullanılmıştır:*<br>

➜ .NET Core MVC: Sunucu tarafı web uygulama çerçevesi.<br>
➜ Veritabanı: MSSQL veritabanı kullanıldı.<br>
➜ Entity Framework (EF): Veritabanı işlemleri için ORM (Nesne İlişkilendirme Yönetimi) aracı.<br>
➜ HTML5, Bootstrap: Ön yüz tasarımı için kullanılan teknolojiler.<br>

📦**Kurulum**<br>

★*Projeyi GitHub'dan klonlayın:*

✔️'git clone <repo_url>'

📦*Paket Kurulumları*<br>

➜**NuGet Paket Yöneticisini Açın: Tools➜NuGet Package Manager➜Manage NuGet Packages for Solution  yolunu izleyerek ilgili kısmı açın,Aşşağıdaki paketleri yükleyin:**<br>

>EntityFramework<br>
>Microsoft.EntityFrameworkCore<br>
>Microsoft.EntityFrameworkCore.Design<br>
>Microsoft.EntityFrameworkCore.SqlServer<br>
>Microsoft.EntityFrameworkCore.Tools<br>


★*Veritabanı bağlantı ayarlarınızı appsettings.json dosyasında yapılandırın. Özellikle veritabanı türünü  ve bağlantı dizesini ayarlayın.*

★* Code-first ile veritabanını oluşturmak için aşağıdaki komutları kullanın:*

➜Enable-Migrations<br>
➜Add-migration 'kullanacağınız-isim'<br>
➜Update-database

🌟**Kullanım**<br>

Uygulama başlatıldığında, ana ekran kütüphanedeki kitapları listeleyecektir. Kitapları eklemek, ödünç vermek için uygulama üzerindeki düğmeleri kullanabilirsiniz.<br>

★**Aşşağıdaki resimlerde uygulama içindeki resimler mevcut**<br>

<img src="https://github.com/demirciouzhan/LibraryApplication/blob/master/imagesforreadme/Anasayfa.png" width="auto"> <br>
➜*Bu kısımda kitapları liste halinde görebilirsiniz.* <br>

<img src="https://github.com/demirciouzhan/LibraryApplication/blob/master/imagesforreadme/KitapEkleme.png" width="auto">
➜*Bu kısımda kütüphaneye yeni kitap ekleyebilirsiniz.* <br>

<img src="https://github.com/demirciouzhan/LibraryApplication/blob/master/imagesforreadme/Odun%C3%A7ver.png" width="auto">
➜*Bu kısımda kütüphanede mevcut olan kitabı ödünç vererek, müşteri adı ve geri getireceği tarih girilir veri tabanına kaydedilir.* <br>

<img src="https://github.com/demirciouzhan/LibraryApplication/blob/master/imagesforreadme/SonAnasayfa.png" width="auto">
➜*Gördüğünüz gibi ödünç alınınan kitap dışarıda gözüküyor.Hangi müşteride olduğu ve geri getireceği tarih listeleniyor.* <br>

🌟**Kod Kalitesi ve Güvenlik**<br>

➜**Bu uygulama, güvenlik açısından en iyi uygulamaları takip eder.**

➜**Kod, temiz ve okunabilir olacak şekilde düzenlenmiştir. Ayrıca, bağımlılıklar için NuGet paketleri kullanılmıştır.**

