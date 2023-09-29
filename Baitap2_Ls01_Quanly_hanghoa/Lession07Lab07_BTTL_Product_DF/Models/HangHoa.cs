using System;
using System.Collections.Generic;

namespace Lession07Lab07_BTTL_Product_DF.Models;

public partial class HangHoa
{
    public int MaHangHoa { get; set; }

    public string? TenHangHoa { get; set; }

    public int? Soluong { get; set; }

    public double? DonGiaNhap { get; set; }

    public double? DonGiaBan { get; set; }

    public string? Anh { get; set; }

    public string? GhiChu { get; set; }
}
