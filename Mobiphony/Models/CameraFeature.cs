using System;
using System.Collections.Generic;

namespace Mobiphony.Models;

public partial class CameraFeature
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();
}
