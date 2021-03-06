﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEs.Models
{
   [Table("Branch_tbl")]
    public class Branch
    {
        [Key]
        public String BranchNo { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String Postcode { get; set; }
        public List<Staff> staffs { get; set; }
        public List<Rent> Rents { get; set; }
    }
}