📖 [English](README.en.md)

# Mikroservis E-Ticaret Projesi

## 📦 Proje Hakkında
Bu proje ASP.NET Core ve mikroservis mimarisi kullanılarak geliştirilen bir e-ticaret projesidir. Bu projede her servis bağımsız olarak geliştiriliyor ve farklı teknolojilerle entegre edilecek.

### 🛒 Catalog Service
Ürün ve kategorilerin yönetimini sağlayan mikroservis. MongoDB veritabanı kullanarak belge tabanlı veri saklama yapılır.

**Teknolojiler**
-	.NET 8
-	MongoDB
-	AutoMapper

**Özellikleri**
-	Ürün ekleme, listeleme, güncelleme ve silme
-	Kategori yönetimi
-	Ürün detayları ve görselleri
-	NoSQL veritabanı ile hızlı veri işleme

**Yapı**

-	Entities:
    -	 Product (Ürün bilgileri)
    -	Category (Kategori bilgileri)
    -	ProductDetail (Ürün detayları)
    -	ProductImage (Ürün görselleri)

-	Services:
    -  	ProductService (Ürün işlemleri)
    -  	CategoryService (Kategori işlemleri)
    -  	ProductDetailService (Ürün detay işlemleri)
    -  	ProductImageService (Ürün görsel işlemleri)

-	DTOs: Veri transfer nesneleri

-	Settings: MongoDB bağlantı ayarları

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
