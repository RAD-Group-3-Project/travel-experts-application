using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertData.Models;

[Index("WalletId", Name = "IX_Transactions_WalletId")]
public partial class Transaction
{
    [Key]
    public Guid TransactionId { get; set; }

    public Guid WalletId { get; set; }

    public int TransactionType { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    public string Description { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    [ForeignKey("WalletId")]
    [InverseProperty("Transactions")]
    public virtual Wallet Wallet { get; set; } = null!;
}
