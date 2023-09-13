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

★*Veritabanı bağlantı ayarlarınızı appsettings.json dosyasında yapılandırın. Özellikle veritabanı türünü  ve bağlantı dizesini ayarlayın.*

★*Veritabanını oluşturmak için aşağıdaki komutları kullanın:*

➜Enable-Migrations<br>
➜Add-migration 'your-database'<br>
➜Update-database
