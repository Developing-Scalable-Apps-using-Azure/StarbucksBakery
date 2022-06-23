using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace internationalbakers.Models
{
    public partial class Cookie
    {
        public Cookie()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(150)]
        public string ImageUrl { get; set; }
        public double? Price { get; set; }

        [InverseProperty(nameof(OrderLine.Cookie))]
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
