﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerWebApi.Models
{
    [Table("customer",Schema="dbo")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("customer_Id")]
        public int CustomerId { get; set; }
        [Column("customer_name")]
        public string CustomerName { get; set; }
        [Column("customer_phone")]
        public string CustomerPhone { get; set; }
        [Column("email")]
        public string CustomerEmail { get; set; }  
    }
}
