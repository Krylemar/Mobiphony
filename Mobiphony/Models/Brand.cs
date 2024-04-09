using System;
using System.Collections.Generic;

namespace Mobiphony.Models;

public partial class Brand
{
    public int Id { get; set; }

    public sbyte BrandName { get; set; }

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();
}
