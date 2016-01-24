using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Required_Attribute
{

    public class Employee
    {
        public int EmployeeID { get; set; }
        [StringLength(50)]

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

    }




}
