using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }
    [Display(Name = "Supplier Name")]
    public string SupplierName { get; set; } = null!;
    [Display(Name = "Contact Name")]
    public string? ContactName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
    [Display(Name = "Postal Code")]
    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
