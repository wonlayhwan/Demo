using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Database.Schema
{
    /// <summary>
    /// 党员
    /// </summary>
    public class Communist
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(30)]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 党龄
        /// </summary>
        public int PartyStanding { get; set; }
    }
}
