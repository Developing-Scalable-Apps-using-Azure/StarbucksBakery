using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace internationalbakers.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        [Key]
        public int Id { get; set; }
        public DateTimeOffset? Date { get; set; }
        public double? Price { get; set; }
        [StringLength(150)]
        public string Status { get; set; }
        public int? StoreId { get; set; }

        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Orders")]
        public virtual Store Store { get; set; }
        [InverseProperty(nameof(OrderLine.Order))]
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
