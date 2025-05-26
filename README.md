📖 [English](README.en.md)

# Mikroservis E-Ticaret Projesi

## 📦 Proje Hakkında
MicroShop, ASP.NET Core ve mikroservis mimarisi kullanılarak geliştirilmiş bir e-ticaret sistemidir. Bu projede her servis bağımsız olarak geliştirildi ve farklı teknolojilerle entegre edildi.

### 🛍️ Catalog Service  
Ürün ve kategori verilerinin yönetildiği servistir. MongoDB kullanılarak belge tabanlı veri saklama yapılır.

**Kullanılan Teknolojiler:**
- .NET 8  
- MongoDB  
- AutoMapper  

### 🏷️ Discount Service 
İndirim kuponlarının yönetimini sağlayan mikroservis. Kupon oluşturma, listeleme, güncelleme ve silme işlemleri bu servis üzerinden yapılır.

**Teknolojiler**
- .NET 8  
- MSSQL  
- Dapper

**Özellikleri**
- Kupon kodları oluşturma ve yönetme
- İndirim tutarlarını tanımlama
-	Kuponların geçerlilik sürelerini belirleme
-	Aktif/pasif kupon durumu kontrolü

**Yapı**
-	Entities: Kupon varlık modeli
- Services: Kupon işlemlerinin yönetildiği servisler
-	DTOs: Veri transfer nesneleri
-	Context: Dapper bağlantı yönetimi

### 📦 Order Service

Mikroservis mimarisi tabanlı e-ticaret sistemi içinde sipariş yönetimini sağlayan servis.

**Teknolojiler**
- .NET 8
- Entity Framework Core
- MediatR
- SQL Server
- Clean Architecture
  
**Özellikleri**
- Sipariş oluşturma ve yönetme
-	Sipariş detaylarını izleme
-	Müşteri adres bilgilerini yönetme
-	CQRS pattern ile geliştirme

**Katmanlar**
-	Domain: Temel varlıklar (Ordering, OrderDetail, Address)
-	Application: İş mantığı, CQRS komutları ve sorguları
-	Persistence: Veritabanı işlemleri ve repository
-	WebAPI: RESTful API endpoint'leri
