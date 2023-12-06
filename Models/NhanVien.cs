        using System;
using System.Collections.Generic;

namespace De_On_Tap_Kttx2_Lan1.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string? HoTen { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? GioiTinh { get; set; }

    public string? PhongBan { get; set; }

    public double? Hsluong { get; set; }
}
