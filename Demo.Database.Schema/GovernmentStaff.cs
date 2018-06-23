using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Database.Schema
{
    /// <summary>
    /// 公职人员
    /// </summary>
    public class GovernmentStaff
    {

        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(30)]
        public string IdCardNumber { get; set; }

        [StringLength(150)]
        public string Position { get; set; }
    }
}
