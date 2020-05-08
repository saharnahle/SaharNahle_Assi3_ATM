using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ATM.Models
{
    public class CheckingAccount
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(10)]
        [Column (TypeName ="varchar")]
        [Display(Name ="Account #")]
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name { get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }}
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}