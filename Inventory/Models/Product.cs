using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;

public partial class Product
{
    public int ProductId { get; set; }
    [Display(Name = "Product Name")]
    public string ProductName { get; set; } = null!;
    [Display(Name = "Category ID")]
    public int? CategoryId { get; set; }
    [Display(Name = "Supplier ID")]
    public int? SupplierId { get; set; }
    [Display(Name = "Quantity Per Unit")]
    public string? QuantityPerUnit { get; set; }
    [Display(Name = "Unit Price")]
    public decimal? UnitPrice { get; set; }
    [Display(Name = "Units In Stock")]
    public int? UnitsInStock { get; set; }
    [Display(Name = "Units On Order")]
    public int? UnitsOnOrder { get; set; }
    [Display(Name = "Reorder Level")]
    public int? ReorderLevel { get; set; }

    public bool? Discontinued { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Supplier? Supplier { get; set; }
}
