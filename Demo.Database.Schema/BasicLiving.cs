using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Database.Schema
{
    /// <summary>
    /// 低保数据
    /// </summary>
    public class BasicLiving
    {

        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(30)]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 领取日期
        /// </summary>
        public DateTime GainDate { get; set; }

        /// <summary>
        /// 领取金额
        /// </summary>
        public double Amount { get; set; }
    }
}
