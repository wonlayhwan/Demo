using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Database.Schema
{
    /// <summary>
    /// 基本信息--户籍信息
    /// </summary>
    public class Profile
    { 
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(30)]
        public string IdCardNumber { get; set; }

        [StringLength(100)]
        public string BornPlace { get; set; }

        [StringLength(100)]
        public string LivingPlace { get; set; }

        public DateTime Birthday { get; set; }
    }
}
