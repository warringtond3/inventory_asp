using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;

public partial class Category
{
    public int CategoryId { get; set; }
    [Display(Name = "Cagetory Name")]
    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
