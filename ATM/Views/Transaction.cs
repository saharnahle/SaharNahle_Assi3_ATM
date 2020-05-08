using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM.Views
{
    public class Transaction
    {
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Ammount { get; set; }
        [ForeignKey("CheckingAccount")]
        public int CheckingAccountId { get; set; }
    }
}