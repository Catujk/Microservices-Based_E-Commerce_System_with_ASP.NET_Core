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
