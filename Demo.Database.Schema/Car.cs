using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Database.Schema
{
    /// <summary>
    /// 车辆信息
    /// </summary>
    public class Car
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(30)]
        public string IdCardNumber { get; set; }

        [StringLength(80)]
        public string CarBrand { get; set; }
    }
}
