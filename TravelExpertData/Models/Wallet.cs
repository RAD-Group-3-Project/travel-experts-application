using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertData.Models;

[Index("CustomerId", Name = "IX_Wallets_CustomerId")]
public partial class Wallet
{
    [Key]
    public Guid Id { get; set; }

    public int CustomerId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Balance { get; set; }

    public DateTime LastUpdated { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Wallets")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("Wallet")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
