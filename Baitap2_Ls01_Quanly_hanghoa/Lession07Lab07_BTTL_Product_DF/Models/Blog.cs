using System;
using System.Collections.Generic;

namespace Lession07Lab07_BTTL_Product_DF.Models;

public partial class Blog
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Status { get; set; }

    public int? Prioty { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }
}
