using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LscWebApp.Models
{
    public class EmployeeDataModel
    {
        [Required]
        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Designation")]
        public string Designation { get; set; }

        [DisplayName("Age")]
        public int Age { get; set; }
    }
}
