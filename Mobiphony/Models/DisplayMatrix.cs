using System;
using System.Collections.Generic;

namespace Mobiphony.Models;

public partial class DisplayMatrix
{
    public int Id { get; set; }

    public string MatrixType { get; set; } = null!;

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();
}
