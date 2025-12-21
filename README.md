📚 Dergi ve Gazete Otomasyonu
Bu proje, C# programlama dili ve Windows Forms (WinForms) kullanılarak geliştirilmiş, yayıncılık süreçlerini yöneten bir masaüstü otomasyon sistemidir. Katmanlı mimari prensiplerine uygun olarak tasarlanmış olup, veri yönetimi ve kullanıcı etkileşimini merkezi bir yapıda toplar.

🛠 Teknik Mimari ve Teknolojiler
Core Stack
C# (.NET Framework/Core): Uygulamanın temel programlama dili.
Windows Forms (WinForms): Masaüstü grafik kullanıcı arayüzü (GUI) geliştirme aracı.
ADO.NET / Entity Framework: Veritabanı etkileşimi ve CRUD operasyonları için veri erişim katmanı.
MS SQL Server: İlişkisel veri depolama çözümü.
Mimari Kararlar ve Seçimler
WinForms: Kurumsal iç ağlarda (Intranet) hızlı deployment ve düşük donanım gereksinimi için tercih edilmiştir.
Trade-off: WPF veya Web tabanlı çözümlere göre UI özelleştirme imkanları kısıtlıdır ancak geliştirme hızı (Time-to-market) yüksektir.
N-Tier Design: İş mantığı (Business Logic), veri erişimi (Data Access) ve sunum (UI) katmanlarının birbirinden ayrılması amaçlanmıştır.
Trade-off: Küçük ölçekli projelerde başlangıçta karmaşıklık yaratsa da, projenin ölçeklenebilirliğini ve bakım kolaylığını (Maintainability) sağlar.

🚀 Temel Özellikler
Yayın Portföyü Yönetimi: Gazete ve dergilerin sisteme kaydedilmesi, stok ve fiyat takibi.
Abone ve Müşteri Modülü: Abonelik başlangıç/bitiş tarihleri ve ödeme durumlarının yönetimi.
Dinamik Raporlama: Satış verileri ve yayın istatistiklerinin kullanıcıya sunulması.
Data Persistence: Verilerin SQL Server üzerinde kalıcı olarak saklanması ve yönetilmesi.

📦 Kurulum ve Derleme
Gereksinimler
Visual Studio 2019/2022.
.NET SDK (Projenin hedeflediği versiyona uygun).
SQL Server (LocalDB veya Express).
Adımlar
Projeyi klonlayın: git clone https://github.com/aslanbaris13/Dergi_Gazete_Otomasyonu.git
Dergi_Gazete_Otomasyonu.sln dosyasını Visual Studio ile açın.
App.config veya bağlantı sınıfındaki Connection String bilgisini kendi yerel SQL Server ayarlarınıza göre güncelleyin.
NuGet paketlerini restore edin ve projeyi Build (F6) edin.
Uygulamayı Start (F5) ile çalıştırın.

📄 Lisans
Bu proje MIT Lisansı ile lisanslanmıştır.

Developed by Barış Aslan
