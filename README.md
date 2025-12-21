📚 Dergi ve Gazete Otomasyonu
Dergi ve gazete yayıncılığı süreçlerini dijitalleştirmek, abone takibini kolaylaştırmak ve içerik yönetimini optimize etmek için geliştirilmiş uçtan uca bir yönetim sistemidir.

🚀 Özellikler
İçerik Yönetimi: Gazete ve dergi sayılarını oluşturma, düzenleme ve arşivleme.
Abone Takibi: Kullanıcı kayıtları, abonelik süreleri ve ödeme durumlarının yönetimi.
Yazar/Editör Paneli: Makale gönderimi ve onay süreçleri (Workflow).
Raporlama: Satış ve abone istatistiklerinin görselleştirilmesi.
Arama & Filtreleme: Geçmiş sayılar arasında hızlı arama yapabilme.
🛠️ Teknoloji Stack
Sistemin mimarisi modern ve ölçeklenebilir araçlar üzerine inşa edilmiştir:

Teknoloji	Kullanım Amacı	Alternatifler & Trade-offs
C# / .NET	Backend Business Logic	Java/Spring: Daha fazla kurumsal destek ama .NET ekosistemiyle hızlı geliştirme avantajı tercih edildi.
SQL Server	İlişkisel Veri Depolama	PostgreSQL: Açık kaynak olması avantajdı ancak mevcut ekosistem uyumu için MS SQL seçildi.
Entity Framework	ORM (Object Relational Mapping)	Dapper: Dapper daha hızlıdır ancak geliştirme hızı ve bakım kolaylığı (Maintainability) için EF tercih edildi.
📦 Kurulum
Bash
# Projeyi klonlayın
git clone https://github.com/aslanbaris13/Dergi_Gazete_Otomasyonu.git

# Proje dizinine gidin
cd Dergi_Gazete_Otomasyonu

# Veritabanı bağlantı dizesini (Connection String) güncelleyin
# appsettings.json veya ilgili config dosyasından düzenleme yapın

# Migration'ları uygulayın (Entity Framework kullanılıyorsa)
dotnet ef database update
📖 Kullanım
Uygulamayı çalıştırdıktan sonra admin girişi yaparak yayın türlerini (Gazete/Dergi) tanımlayın.
Yeni sayılar ekleyerek içerik girişlerini tamamlayın.
Abone modülü üzerinden yeni kullanıcı kayıtları oluşturun.
🤝 Katkıda Bulunma
Bu projeyi fork edin.
Yeni bir feature branch açın (git checkout -b feature/YeniOzellik).
Değişikliklerinizi commit edin (git commit -m 'Yeni özellik eklendi').
Branch'inizi push edin (git push origin feature/YeniOzellik).
Bir Pull Request açın.
📄 Lisans
Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için LICENSE dosyasına bakınız.

Developed with ❤️ by Barış Aslan
