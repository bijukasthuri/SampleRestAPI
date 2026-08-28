using Microsoft.AspNetCore.Mvc;
using SampleRestAPI.Models;

namespace SampleRestAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    // In-memory storage for demo purposes
    private static List<Product> Products = new()
    {
        new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 999.99m, Quantity = 10 },
        new Product { Id = 2, Name = "Mouse", Description = "Wireless mouse", Price = 29.99m, Quantity = 50 },
        new Product { Id = 3, Name = "Keyboard", Description = "Mechanical keyboard", Price = 79.99m, Quantity = 25 }
    };

    /// <summary>
    /// Get all products
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        return Ok(Products);
    }

    /// <summary>
    /// Get a product by ID
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    /// <summary>
    /// Create a new product
    /// </summary>
    [HttpPost]
    public ActionResult<Product> CreateProduct(Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Name))
        {
            return BadRequest("Product name is required");
        }

        product.Id = Products.Max(p => p.Id) + 1;
        product.CreatedAt = DateTime.UtcNow;
        Products.Add(product);

        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }

    /// <summary>
    /// Update an existing product
    /// </summary>
    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, Product product)
    {
        var existingProduct = Products.FirstOrDefault(p => p.Id == id);
        if (existingProduct == null)
        {
            return NotFound();
        }

        existingProduct.Name = product.Name;
        existingProduct.Description = product.Description;
        existingProduct.Price = product.Price;
        existingProduct.Quantity = product.Quantity;

        return NoContent();
    }

    /// <summary>
    /// Delete a product
    /// </summary>
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        Products.Remove(product);
        return NoContent();
    }
}