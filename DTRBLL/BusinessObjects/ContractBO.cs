﻿using System.ComponentModel.DataAnnotations;

namespace DTRBLL.BusinessObjects
{
    public class ContractBO
    {
        [Required]
        public int GroupId { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public int ProjectId { get; set; }
        public bool IsApproved { get; set; }
    }
}