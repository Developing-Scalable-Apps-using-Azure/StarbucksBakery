using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace internationalbakers.Models
{
    public partial class OrderLine
    {
        [Key]
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public int? CookieId { get; set; }
        public int? OrderId { get; set; }

        [ForeignKey(nameof(CookieId))]
        [InverseProperty("OrderLines")]
        public virtual Cookie Cookie { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderLines")]
        public virtual Order Order { get; set; }
    }
}
