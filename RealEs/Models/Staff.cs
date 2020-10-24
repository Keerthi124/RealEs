using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEs.Models
{
    [Table("Staff_tbl")]
    public class Staff
    {
        [Key]
        public String StaffNo { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String Position { get; set; }
        public DateTime DOB { get; set; }
        public int Salary { get; set; }
        [Column("BranchNoRef")]
        public String Branch_BranchNo { get; set; }
        [ForeignKey("Branch_BranchNo")]
        public Branch Branches { get; set; }
    }
}