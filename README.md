# Sample REST API

A sample ASP.NET Core REST API project demonstrating a complete CRUD (Create, Read, Update, Delete) implementation for managing products.

## Features

- ✅ **ASP.NET Core 8.0** - Latest .NET framework
- ✅ **RESTful API** - Full CRUD operations
- ✅ **Swagger UI** - Interactive API documentation
- ✅ **OpenAPI Support** - Standard API specification
- ✅ **Model Validation** - Input validation
- ✅ **HTTP Methods** - GET, POST, PUT, DELETE

## Project Structure

```
SampleRestAPI/
├── Controllers/
│   └── ProductsController.cs    # API endpoints
├── Models/
│   └── Product.cs               # Data model
├── Properties/
│   └── launchSettings.json       # Launch configuration
├── Program.cs                    # Application entry point
├── appsettings.json             # Configuration
└── SampleRestAPI.csproj         # Project file
```

## Getting Started

### Prerequisites

- Visual Studio 2022 (or later)
- .NET 8.0 SDK
- or Visual Studio Code with C# extension

### Running the Project

1. **Clone the repository**
   ```bash
   git clone https://github.com/bijukasthuri/SampleRestAPI.git
   cd SampleRestAPI
   ```

2. **Open in Visual Studio 2022**
   - File → Open → Select the project folder
   - Wait for NuGet packages to restore

3. **Run the application**
   - Press `F5` or click the "Run" button
   - Swagger UI will open automatically at `https://localhost:5001/swagger`

4. **Test the API**
   - Use Swagger UI to test endpoints
   - Or use a tool like Postman or cURL

## API Endpoints

### Products

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/products` | Get all products |
| GET | `/api/products/{id}` | Get product by ID |
| POST | `/api/products` | Create a new product |
| PUT | `/api/products/{id}` | Update a product |
| DELETE | `/api/products/{id}` | Delete a product |

### Example Requests

#### Get all products
```bash
curl https://localhost:5001/api/products
```

#### Get a specific product
```bash
curl https://localhost:5001/api/products/1
```

#### Create a new product
```bash
curl -X POST https://localhost:5001/api/products \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Monitor",
    "description": "4K Monitor",
    "price": 299.99,
    "quantity": 15
  }'
```

#### Update a product
```bash
curl -X PUT https://localhost:5001/api/products/1 \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Updated Laptop",
    "description": "High-performance laptop",
    "price": 1099.99,
    "quantity": 8
  }'
```

#### Delete a product
```bash
curl -X DELETE https://localhost:5001/api/products/1
```

## Data Model

The `Product` model includes:

```csharp
public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

## Technologies Used

- **Framework**: ASP.NET Core 8.0
- **API Documentation**: Swagger/Swashbuckle
- **Language**: C# with nullable reference types enabled
- **HTTP**: RESTful API design

## Future Enhancements

- [ ] Add Entity Framework Core for database persistence
- [ ] Implement SQL Server/PostgreSQL integration
- [ ] Add authentication and authorization
- [ ] Add input validation with FluentValidation
- [ ] Implement logging
- [ ] Add unit tests
- [ ] Deploy to Azure

## License

This project is open source and available under the MIT License.

## Author

Created for learning and demonstration purposes.