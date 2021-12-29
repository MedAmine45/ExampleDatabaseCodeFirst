using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCreateBase.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        public string Address { get; set; }
        
        public DateTime Datebirthday { get; set; }
        public int? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
