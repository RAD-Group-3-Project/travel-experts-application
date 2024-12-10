using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertData.Models;

[Index("CartId", Name = "IX_CartItems_CartId")]
[Index("PackageId", Name = "IX_CartItems_PackageId")]
public partial class CartItem
{
    [Key]
    public int Id { get; set; }

    public int CartId { get; set; }

    public int PackageId { get; set; }

    public int Traveller { get; set; }

    public string TripTypeId { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [ForeignKey("CartId")]
    [InverseProperty("CartItems")]
    public virtual Cart Cart { get; set; } = null!;

    [ForeignKey("PackageId")]
    [InverseProperty("CartItems")]
    public virtual Package Package { get; set; } = null!;
}
