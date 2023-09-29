using System;
using System.Collections.Generic;

namespace Lession07Lab07_BTTL_Product_DF.Models;

public partial class NguoiDung
{
    public string Id { get; set; } = null!;

    public string? TenDangNhap { get; set; }

    public int? LoaiNguoiDung { get; set; }

    public string? MaNguoiDung { get; set; }

    public string? TenNguoiDung { get; set; }

    public bool? GioiTinh { get; set; }
}
