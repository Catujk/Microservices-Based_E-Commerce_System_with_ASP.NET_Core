# Microservice E-Commerce Project

## 📦 About the Project
MicroShop is an e-commerce system built with ASP.NET Core and microservice architecture. In this project, each service is developed independently and integrated using different technologies.

### 🛒 Catalog Service
Manages products and categories with a document-based MongoDB database.

**Technologies**
- .NET 8
- MongoDB
- AutoMapper

**Features**
- Add, list, update, and delete products
- Category management
- Product details and images
- Fast data processing with NoSQL

**Structure**
- **Entities**  
  - Product (product information)  
  - Category (category information)  
  - ProductDetail (detailed product data)  
  - ProductImage (product images)

- **Services**  
  - ProductService (product operations)  
  - CategoryService (category operations)  
  - ProductDetailService (product detail operations)  
  - ProductImageService (product image operations)

- **DTOs**  
  Data Transfer Objects

- **Settings**  
  MongoDB connection settings

### 🏷️ Discount Service
Handles discount coupons: creation, listing, updating, and deletion.

**Technologies**
- .NET 8
- MSSQL
- Dapper

**Features**
- Create and manage coupon codes
- Define discount amounts
- Set coupon validity periods
- Active/inactive coupon status checks

**Structure**
- **Entities**: Coupon entity model  
- **Services**: Business logic for coupon operations  
- **DTOs**: Data Transfer Objects  
- **Context**: Dapper connection management  

### 📦 Order Service
A microservice for order management within the e-commerce system.

**Technologies**
- .NET 8
- Entity Framework Core
- MediatR
- SQL Server
- Clean Architecture

**Features**
- Create and manage orders
- Track order details
- Manage customer address information
- Developed using the CQRS pattern

**Layers**
- **Domain**: Core entities (Ordering, OrderDetail, Address)  
- **Application**: Business logic, CQRS commands and queries  
- **Persistence**: Database operations and repositories  
- **WebAPI**: RESTful API endpoints  
