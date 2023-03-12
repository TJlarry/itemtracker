using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace itemtracker.Models
{
    public class Expense
    { 
        [Key]
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [Required]
        public string FullName { get; set; }
        [Required]
        //[Range(1,int.MaxValue, ErrorMessage = "Amount must be gretaer than  0!")]
        [DisplayName("Bussiness Unit")]
        public string BussinessUnit { get; set; }
        [Required]
        public string Menu { get; set; }
        public string Allergy { get; set; }
        public DateTime Date { get; set; }



    }
}
