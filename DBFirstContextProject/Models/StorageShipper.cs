using System;
using System.Collections.Generic;

namespace DBFirstContextProject.Models;

public partial class StorageShipper
{
    public int KargoId { get; set; }

    public string? KargoAdi { get; set; }

    public string? KargoTel { get; set; }
}
