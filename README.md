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

### 🧾 Discount Service  
İndirim kuponlarının yönetildiği servistir. Kupon ekleme, güncelleme, silme ve listeleme işlemleri yapılır. Veriler MSSQL veritabanında tutulur ve Dapper ile erişilir.

**Kullanılan Teknolojiler:**
- .NET 8  
- MSSQL  
- Dapper 

### 📦 Order Service

Mikroservis mimarisi tabanlı e-ticaret sistemi içinde sipariş yönetimini sağlayan servis.

Teknolojiler
•	.NET 8
•	Entity Framework Core 9.0
•	MediatR 12.5
•	SQL Server
•	Clean Architecture
Özellikleri
•	Sipariş oluşturma ve yönetme
•	Sipariş detaylarını izleme
•	Müşteri adres bilgilerini yönetme
•	CQRS pattern ile geliştirme
Katmanlar
•	Domain: Temel varlıklar (Ordering, OrderDetail, Address)
•	Application: İş mantığı, CQRS komutları ve sorguları
•	Persistence: Veritabanı işlemleri ve repository
•	WebAPI: RESTful API endpoint'leri
API
Swagger üzerinden tüm sipariş, adres ve detay işlemleri yapılabilir.
