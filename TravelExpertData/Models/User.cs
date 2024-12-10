using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertData.Models;

[Keyless]
public partial class User
{
    [Column("CustomerId")]
    public int? Userid { get; set; }

    [Column("UserName")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserLogin { get; set; } = null!;

    [Column("PasswordHash")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserPassword { get; set; } = null!;

    [Column("is_admin")]
    public bool IsAdmin { get; set; }
}
