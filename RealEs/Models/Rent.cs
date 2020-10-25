using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEs.Models
{
    
    [Table("Rent_tbl")]
    public class Rent
    {
        [Key]
        public String PropertyNo { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String Ptype { get; set; }
        public int Rooms { get; set; }
        [Column("OwnerNoRef")]
        public String RefOwnerNo { get; set; }
        [ForeignKey("RefOwnerNo")]
        public Owner Owners { get; set; }
        [Column("StaffNoRef")]
        public String RefStaffNo { get; set; }
        [ForeignKey("RefStaffNo")]
        public Staff staffs { get; set; }
        [Column("BranchNoRef")]
        public String RefBranchNo { get; set; }
        [ForeignKey("RefBranchNo")]
        public Branch Branches { get; set; }
        public int Rents { get; set; }

    }
}