﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgoAPI.Entity.Item.BusinessModels
{
    [Table("cit.Customer")]
    public class CustomerModel
    {
        public int  CustomerId { get; set; }
        public string ? CustomerName { get; set; }
        public string ? Address { get; set; }
        public string ? ContactNumber { get; set; }
        public string ? Email { get; set; }
        public string ? DataSource { get; set; }
        public int ? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int ? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get;set; }
        public int ? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? IsDeleted { get; set; }

    }
}