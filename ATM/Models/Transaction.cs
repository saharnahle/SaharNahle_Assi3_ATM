using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM.Models
{
    public class Transaction
    {
  

        public int ID { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Amount { get; set; }

        [ForeignKey("CheckingAccount")]
        public virtual CheckingAccount CheckingAccount { get; set; }

        [ForeignKey ("CheckingAccount")]
        public int CheckingAccountId { get; set; }
    }
}