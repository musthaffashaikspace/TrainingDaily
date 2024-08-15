using System;
using System.Collections.Generic;

namespace RestAPI.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string? Productname { get; set; }

    public int? Categoryid { get; set; }

    public virtual Category? Category { get; set; }
}
