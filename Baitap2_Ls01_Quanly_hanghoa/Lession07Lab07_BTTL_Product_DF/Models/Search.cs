using System;
using System.Collections.Generic;

namespace Lession07Lab07_BTTL_Product_DF.Models;

public partial class Search
{
    public string SearchString { get; set; } = null!;

    public string? SortCol { get; set; }

    public string? SortOrder { get; set; }

    public int? Page { get; set; }

    public int? PageSize { get; set; }
}
