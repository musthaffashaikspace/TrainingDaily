using System;
using System.Collections.Generic;

namespace RestAPI.Models;

public partial class Login
{
    public string Username { get; set; } = null!;

    public string? Password { get; set; }
}
