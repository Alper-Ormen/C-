using System;
using System.Collections.Generic;

namespace c_.Models;

public partial class Todo
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public ulong? IsComplated { get; set; }
}
