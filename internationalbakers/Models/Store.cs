using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace internationalbakers.Models
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Country { get; set; }

        [InverseProperty(nameof(Order.Store))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
